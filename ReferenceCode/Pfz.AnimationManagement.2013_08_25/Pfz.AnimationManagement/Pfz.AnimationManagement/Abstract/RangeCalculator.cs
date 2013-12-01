using System;
using Pfz.AnimationManagement.RangeCalculators;

#if SILVERLIGHT
using System.Windows.Media;
using System.Windows;
#endif

namespace Pfz.AnimationManagement.Abstract
{
    internal static class RangeCalculator
    {
        static RangeCalculator()
        {
            RangeCalculator<int>.Default = Int32RangeCalculator.Instance;
            RangeCalculator<double>.Default = DoubleRangeCalculator.Instance;

			#if SILVERLIGHT
				RangeCalculator<Color>.Default = ColorRangeCalculator.Instance;
				RangeCalculator<Point>.Default = PointRangeCalculator.Instance;
			#endif
        }

        internal static void _Initialize()
        {
        }
    }

    public abstract class RangeCalculator<T>:
        IRangeCalculator<T>
    {
        static RangeCalculator()
        {
            RangeCalculator._Initialize();
        }

        public static IRangeCalculator<T> Default { get; set; }

        public abstract T Calculate(T initialValue, T finalValue, TimeSpan actualTime, TimeSpan duration);

        Type IRangeCalculator.DataType
        {
            get
            {
                return typeof(T);
            }
        }

        object IRangeCalculator.Calculate(object initialValue, object finalValue, TimeSpan actualTime, TimeSpan duration)
        {
            return Calculate((T)initialValue, (T)finalValue, actualTime, duration);
        }
    }
}
