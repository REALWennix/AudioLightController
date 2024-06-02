using System;

namespace LightController.Settings
{
    public class SettingsClass
    {
        // Example settings properties
        public bool IsSoundEnabled { get; set; }
        public int LightBrightness { get; set; }
        public string ThemeColor { get; set; }

        // Serial communication settings
        public string PortName { get; set; }
        public int BaudRate { get; set; }

        // Hardware specifications
        public string MinProcessor { get; set; }
        public string MinRAM { get; set; }
        public string MinGraphicsCard { get; set; }
        public string RecommendedProcessor { get; set; }
        public string RecommendedRAM { get; set; }
        public string RecommendedGraphicsCard { get; set; }

        // Default delay setting
        public int DefaultDelay { get; set; }

        // Singleton instance using lazy initialization
        private static readonly Lazy<SettingsClass> lazyInstance = new Lazy<SettingsClass>(() => new SettingsClass());

        // Private constructor to prevent external instantiation
        private SettingsClass()
        {
            // Initialize default settings
            IsSoundEnabled = true;
            LightBrightness = 255;
            ThemeColor = "blue-black";

            // Initialize default serial communication settings
            PortName = "COM1"; // Default port name
            BaudRate = 9600;   // Default baud rate

            // Initialize default hardware specifications
            MinProcessor = "Intel Core i3 or equivalent";
            MinRAM = "4 GB";
            MinGraphicsCard = "NVIDIA GeForce GTX 750 or AMD Radeon HD 7850";
            RecommendedProcessor = "Intel Core i5 or equivalent";
            RecommendedRAM = "8 GB";
            RecommendedGraphicsCard = "NVIDIA GeForce GTX 1060 or AMD Radeon RX 580";

            DefaultDelay = 90;
        }

        // Singleton pattern to ensure only one instance of SettingsClass exists
        public static SettingsClass Instance => lazyInstance.Value;
    }
}
