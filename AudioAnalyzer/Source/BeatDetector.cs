using System;

namespace AudioAnalyzer
{
    public abstract class BeatDetector
    {
        private float _beatThreshold = 0.25f;
        private int _minBeatGap = 100;
        private int _minBeatWidth = 1;
        private int _windowSize = 50;
        private bool _autoGainEnabled = true;
        private float _gain = float.MaxValue;
        protected float _maxGain = float.MinValue;
        protected float _maxPeakGain = float.MinValue;

        /// <summary>
        /// Beat detection threshold.
        /// </summary>
        public float BeatThreshold
        {
            get { return _beatThreshold; }
            set { _beatThreshold = value; }
        }

        /// <summary>
        /// Minimal time between the detected beats in milliseconds.
        /// </summary>
        public int MinBeatGap
        {
            get { return _minBeatGap; }
            set { _minBeatGap = value; }
        }

        /// <summary>
        /// Minimal width of the detected beats.
        /// </summary>
        public int MinBeatWidth
        {
            get { return _minBeatWidth; }
            set { _minBeatWidth = value; }
        }

        /// <summary>
        /// Width of the processing window;
        /// </summary>
        public int WindowSize
        {
            get { return _windowSize; }
            set { _windowSize = value; }
        }

        /// <summary>
        /// Sets whether automatic gain control is enabled.
        /// </summary>
        public bool AutoGainEnabled
        {
            get { return _autoGainEnabled; }
            set { _autoGainEnabled = value; }
        }

        public float Gain
        {
            get { return _gain; }
            set { _gain = value; }
        }

        /// <summary>
        /// Maximum gain achieved during processing.
        /// </summary>
        public float MaxGain
        {
            get { return _maxGain; }
            protected set { _maxGain = value; }
        }

        /// <summary>
        /// Maximum peak gain achieved during processing.
        /// </summary>
        public float MaxPeakGain
        {
            get { return _maxPeakGain; }
            protected set { _maxPeakGain = value; }
        }

        /// <summary>
        /// Time of the latest beat detection.
        /// </summary>
        public DateTime LastBeatTime { get; set; }

        /// <summary>
        /// Fires when a beat is detected.
        /// </summary>
        public event EventHandler<BeatDetectedEventArgs> BeatDetected;

        /// <summary>
        /// Process incoming audio samples and detect beat.
        /// </summary>
        /// <param name="samples">PCM sample buffer.</param>
        public abstract void ProcessData(float[] samples);

        protected void OnBeatDetected()
        {
            BeatDetected?.Invoke(this, new BeatDetectedEventArgs());
        }
    }
}
