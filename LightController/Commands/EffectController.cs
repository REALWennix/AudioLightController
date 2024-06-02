using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightController.Commands
{
    public class EffectController
    {
        // Method to initialize serial communication
        public static void InitializeSerialCommunication(string portName, int baudRate)
        {
            SerialCommunication.Instance.Connect(portName, baudRate);
        }

        // Method to set brightness for all lights
        public static void SetBrightnessAll(int brightness)
        {
            SerialCommand command = new SerialCommand(CommandPrefix.BRIGHTNESS_ALL, brightness);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to clear all lights
        public static void ClearAll()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.CLEAR_ALL);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to set effect for all lights
        public static void SetEffectOnAll(int effectId)
        {
            SerialCommand command = new SerialCommand(CommandPrefix.SET_EFFECT_ON_ALL, effectId);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to add an ID
        public static void AddId(int id)
        {
            SerialCommand command = new SerialCommand(CommandPrefix.ADD_ID, id);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to execute all effects
        public static void ExecuteAll()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.EXEC_ALL);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to clear all effects
        public static void Clear()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.CLEAR);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to close serial communication
        public static void CloseSerialCommunication()
        {
            SerialCommunication.Instance.Close();
        }

        // Method to turn off all lights
        public static void TurnOff()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.OFF);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to turn on all lights
        public static void TurnOn()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.ON);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to set duration for all effects
        public static void SetDurationAll(int duration)
        {
            SerialCommand command = new SerialCommand(CommandPrefix.SET_DURATION_ALL, duration);
            SerialCommunication.Instance.SendCommand(command);
        }

        // Method to reset duration to default for all effects
        public static void ResetDurationAll()
        {
            SerialCommand command = new SerialCommand(CommandPrefix.RESET_DURATION_ALL);
            SerialCommunication.Instance.SendCommand(command);
        }
    }
}
