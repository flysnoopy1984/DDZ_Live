using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.RangeCalculators;

#if SILVERLIGHT
using System.Windows.Media;
using System.Windows;
#endif

namespace Pfz.AnimationManagement.Abstract
{
    internal static class SpeedToDurationCalculator
    {
        static SpeedToDurationCalculator()
        {
            SpeedToDurationCalculator<int>.Default = Int32SpeedToDurationCalculator.Instance;
            SpeedToDurationCalculator<double>.Default = DoubleSpeedToDurationCalculator.Instance;

			#if SILVERLIGHT
				SpeedToDurationCalculator<Color>.Default = ColorSpeedToDurationCalculator.Instance;
				SpeedToDurationCalculator<Point>.Default = PointSpeedToDurationCalculator.Instance;
			#endif
        }

        internal static void Initialize()
        {
        }
    }
    public abstract class SpeedToDurationCalculator<T>:
        ISpeedToDurationCalculator<T>
    {
        static SpeedToDurationCalculator()
        {
            SpeedToDurationCalculator.Initialize();
        }

        public static ISpeedToDurationCalculator<T> Default { get; set; }

        public abstract TimeSpan CalculateDuration(T initialValue, T finalValue, double speed);

        Type ISpeedToDurationCalculator.DataType
        {
            get
            {
                return typeof(T);
            }
        }

        TimeSpan ISpeedToDurationCalculator.CalculateDuration(object initialValue, object finalValue, double speed)
        {
            return CalculateDuration((T)initialValue, (T)finalValue, speed);
        }
    }
}
