using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class DoubleSpeedToDurationCalculator:
        SpeedToDurationCalculator<double>
    {
        private static readonly DoubleSpeedToDurationCalculator _instance = new DoubleSpeedToDurationCalculator();
        public static DoubleSpeedToDurationCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private DoubleSpeedToDurationCalculator()
        {
        }

        public override TimeSpan CalculateDuration(double initialValue, double finalValue, double speed)
        {
            double durationInSeconds = Math.Abs(finalValue - initialValue) / speed;
            return TimeSpan.FromSeconds(durationInSeconds);
        }
    }
}
