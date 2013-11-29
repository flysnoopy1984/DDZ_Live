using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
	public sealed class Int32RangeCalculator:
		RangeCalculator<int>
	{
        private static readonly Int32RangeCalculator _instance = new Int32RangeCalculator();
        public static Int32RangeCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private Int32RangeCalculator()
        {
        }

		public override int Calculate(int initialValue, int finalValue, TimeSpan actualTime, TimeSpan duration)
		{
			double durationMilliseconds = duration.TotalMilliseconds;
			double actualMilliseconds = actualTime.TotalMilliseconds;
			double initialMultiplier = durationMilliseconds - actualMilliseconds;

			double result = ((initialValue * initialMultiplier) + (finalValue * actualMilliseconds)) / durationMilliseconds;
			return (int)result;
		}
	}
}
