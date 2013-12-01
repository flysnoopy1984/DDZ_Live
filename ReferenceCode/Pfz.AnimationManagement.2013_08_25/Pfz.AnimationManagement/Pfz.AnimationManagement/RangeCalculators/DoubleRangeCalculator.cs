using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
	public sealed class DoubleRangeCalculator:
		RangeCalculator<double>
	{
        private static readonly DoubleRangeCalculator _instance = new DoubleRangeCalculator();
        public static DoubleRangeCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private DoubleRangeCalculator()
        {
        }

		public override double Calculate(double initialValue, double finalValue, TimeSpan actualTime, TimeSpan duration)
		{
			double durationMilliseconds = duration.TotalMilliseconds;
			double actualMilliseconds = actualTime.TotalMilliseconds;
			double initialMultiplier = durationMilliseconds - actualMilliseconds;

			double result = ((initialValue * initialMultiplier) + (finalValue * actualMilliseconds)) / durationMilliseconds;
			return result;
		}
	}
}
