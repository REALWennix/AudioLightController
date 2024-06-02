using System;
using System.IO.Ports;
using System.Windows.Forms;
using LightController.Settings;

namespace LightController.Commands
{
    public class SerialCommunication
    {
        private static SerialCommunication instance;
        private SerialPort serialPort;
        private DateTime lastErrorMessageTime;
        private TimeSpan errorMessageCooldown = TimeSpan.FromSeconds(10);

        private static readonly object lockObject = new object();

        private SerialCommunication()
        {
            serialPort = new SerialPort();
        }

        public static SerialCommunication Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new SerialCommunication();
                        }
                    }
                }
                return instance;
            }
        }

        public void Initialize()
        {
            // Get default serial communication settings from SettingsClass class
            string portName = Settings.SettingsClass.Instance.PortName;
            int baudRate = Settings.SettingsClass.Instance.BaudRate;

            SetPortName(portName);
            SetBaudRate(baudRate);

            // Check if the port is already open before attempting to open it
            if (!serialPort.IsOpen)
            {
                OpenPort();
            }
        }


        private void SetPortName(string portName)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.PortName = portName;
        }

        private void SetBaudRate(int baudRate)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
            serialPort.BaudRate = baudRate;
        }

        private void OpenPort()
        {
            try
            {
                if (!serialPort.IsOpen)
                {
                    serialPort.Open();
                    MessageBox.Show("Port opened successfully: " + serialPort.PortName, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendCommand(SerialCommand command)
        {
            ExecuteCommand(command);
        }

        private void ExecuteCommand(SerialCommand command)
        {
            if (!serialPort.IsOpen)
            {
                ShowErrorMessage("Port is not open.");
                return;
            }

            try
            {
                serialPort.WriteLine(command.ToString());

            }
            catch (Exception ex)
            {
                ShowErrorMessage("Error executing command: " + ex.Message);
            }
        }

        private void ShowErrorMessage(string message)
        {
            if (DateTime.Now - lastErrorMessageTime > errorMessageCooldown)
            {
                MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lastErrorMessageTime = DateTime.Now;
            }
        }

        public void Close()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        public void Connect(string portName, int baudRate)
        {
            SetPortName(portName);
            SetBaudRate(baudRate);
            OpenPort();
        }
    }
}
