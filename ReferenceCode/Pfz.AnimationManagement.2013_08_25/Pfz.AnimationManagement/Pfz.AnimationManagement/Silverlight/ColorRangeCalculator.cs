using System;
using System.Windows.Media;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class ColorRangeCalculator:
        RangeCalculator<Color>
    {
        private static readonly ColorRangeCalculator _instance = new ColorRangeCalculator();
        public static ColorRangeCalculator Instance
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

        private ColorRangeCalculator()
        {
        }

        public override Color Calculate(Color initialValue, Color finalValue, TimeSpan actualTime, TimeSpan duration)
        {
            if (actualTime >= duration)
                return finalValue;

            if (actualTime <= TimeSpan.Zero)
                return initialValue;

            double finalMultiplier = (double)actualTime.Ticks / (double)duration.Ticks;
            double initialMultiplier = 1 - finalMultiplier;

            double a = (initialValue.A * initialMultiplier) + (finalValue.A * finalMultiplier);
            double r = (initialValue.R * initialMultiplier) + (finalValue.R * finalMultiplier);
            double g = (initialValue.G * initialMultiplier) + (finalValue.G * finalMultiplier);
            double b = (initialValue.B * initialMultiplier) + (finalValue.B * finalMultiplier);

            return Color.FromArgb((byte)a, (byte)r, (byte)g, (byte)b);
        }
    }
}
