﻿using AudioAnalyzer.Utils;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AudioAnalyzer
{
    public class SoundEnergyDetector : BeatDetector
    {
        public CircularBuffer<float> energyBuffer, beatBuffer, gainBuffer;

        public SoundEnergyDetector()
        {
            energyBuffer = new CircularBuffer<float>(WindowSize);
            beatBuffer = new CircularBuffer<float>(WindowSize);
            gainBuffer = new CircularBuffer<float>(WindowSize);
        }

        public override void ProcessData(float[] samples)
        {
            float energy = 0;

            // Calculate sound energy
            for (int i = 0; i < samples.Length; i++)
            {
                energy += samples[i] * samples[i];
            }

            energy /= samples.Length;

            // Apply auto gain control
            if (AutoGainEnabled)
            {
                if (energy * Gain > 1)
                {
                    Gain = 1 / energy;
                }

                Gain *= 1.0005f;
            }

            // Store current gain in the gain buffer
            gainBuffer.Add(Gain);

            // Update max gain and max peak gain
            if (Gain > MaxGain)
            {
                MaxGain = Gain;
            }

            float maxPeak = gainBuffer.Max();
            if (maxPeak > MaxPeakGain)
            {
                MaxPeakGain = maxPeak;
            }

            energy *= Gain;

            energyBuffer.Add(energy);

            // Detect beat
            if (CheckBeatWidth(MinBeatWidth) &&
                (DateTime.Now.Subtract(LastBeatTime).TotalMilliseconds >= MinBeatGap) &&
                energy > BeatThreshold)
            {
                LastBeatTime = DateTime.Now;
                OnBeatDetected();
                beatBuffer.Add(energy);
            }
            else
            {
                beatBuffer.Add(0);
            }
        }

        private bool CheckBeatWidth(int minWidth)
        {
            float c = -0.0000015f * Variance(energyBuffer) + 1.5142857f;
            float thres = c * Average(energyBuffer);

            for (int i = 0; i < minWidth; i++)
            {
                if (energyBuffer[i] < thres)
                {
                    return false;
                }
            }

            return true;
        }

        private float Average(IEnumerable<float> buffer)
        {
            float avg = 0;
            int count = 0;
            foreach (float f in buffer)
            {
                avg += f;
                count++;
            }
            return avg / count;
        }

        private float Variance(IEnumerable<float> buffer)
        {
            float avg = Average(buffer);
            float var = 0;
            int count = 0;

            foreach (float f in buffer)
            {
                var += (f - avg) * (f - avg);
                count++;
            }

            return var / count;
        }
    }
}
