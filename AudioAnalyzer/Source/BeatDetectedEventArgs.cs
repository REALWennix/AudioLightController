using System;

namespace AudioAnalyzer
{
    public class BeatDetectedEventArgs : EventArgs
    {
        public float Value { get; set; }

        public BeatDetectedEventArgs()
        {

        }

        public BeatDetectedEventArgs(float value)
        {
            Value = value;
        }
    }
}