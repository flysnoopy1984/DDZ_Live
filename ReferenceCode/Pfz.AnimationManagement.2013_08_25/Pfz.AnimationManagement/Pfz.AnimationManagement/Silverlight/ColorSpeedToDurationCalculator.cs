using System;
using System.Windows.Media;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class ColorSpeedToDurationCalculator:
        SpeedToDurationCalculator<Color>
    {
        private static readonly ColorSpeedToDurationCalculator _instance = new ColorSpeedToDurationCalculator();
        public static ColorSpeedToDurationCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        public static void RegisterAsDefault()
        {
            Default = _instance;
        }

        private ColorSpeedToDurationCalculator()
        {
        }

        public override TimeSpan CalculateDuration(Color initialValue, Color finalValue, double speed)
        {
            double a = Math.Abs(finalValue.A - initialValue.A);
            double r = Math.Abs(finalValue.R - initialValue.R);
            double g = Math.Abs(finalValue.G - initialValue.G);
            double b = Math.Abs(finalValue.B - initialValue.B);

            double maxValue = Math.Max(a, Math.Max(r, Math.Max(g, b)));
            return TimeSpan.FromSeconds(maxValue / speed);
        }
    }
}
