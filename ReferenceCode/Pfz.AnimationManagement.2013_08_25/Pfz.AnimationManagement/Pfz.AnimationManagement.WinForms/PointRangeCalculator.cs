using System;
using System.Drawing;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.WinForms
{
    public sealed class PointRangeCalculator:
        RangeCalculator<Point>
    {
        static PointRangeCalculator()
        {
            Initializer.Initialize();
        }

        private static readonly PointRangeCalculator _instance = new PointRangeCalculator();

        public static PointRangeCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private PointRangeCalculator()
        {
        }

        public override Point Calculate(Point initialValue, Point finalValue, TimeSpan actual, TimeSpan duration)
        {
            double initialMultiplier = (duration - actual).TotalSeconds;
            double finalMultiplier = actual.TotalSeconds;
            double totalDivider = duration.TotalSeconds;

            double x = (((initialValue.X * initialMultiplier) + (finalValue.X * finalMultiplier)) / totalDivider);
            double y = (((initialValue.Y * initialMultiplier) + (finalValue.Y * finalMultiplier)) / totalDivider);
            return new Point((int)x, (int)y);
        }
    }
}
