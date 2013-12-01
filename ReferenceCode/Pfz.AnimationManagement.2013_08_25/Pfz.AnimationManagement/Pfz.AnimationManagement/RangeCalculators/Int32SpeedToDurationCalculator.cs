using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class Int32SpeedToDurationCalculator:
        SpeedToDurationCalculator<int>
    {
        private static readonly Int32SpeedToDurationCalculator _instance = new Int32SpeedToDurationCalculator();
        public static Int32SpeedToDurationCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private Int32SpeedToDurationCalculator()
        {
        }

        public override TimeSpan CalculateDuration(int initialValue, int finalValue, double speed)
        {
            double durationInSeconds = Math.Abs((double)finalValue - (double)initialValue) / speed;
            return TimeSpan.FromSeconds(durationInSeconds);
        }
    }
}
