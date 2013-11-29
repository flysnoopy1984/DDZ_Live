using System;
using System.Windows;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class PointRangeCalculator:
        RangeCalculator<Point>
    {
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

        public override Point Calculate(Point initialValue, Point finalValue, TimeSpan actualTime, TimeSpan duration)
        {
            double initialMultiplier = (duration - actualTime).TotalSeconds;
            double finalMultiplier = actualTime.TotalSeconds;
            double totalDivider = duration.TotalSeconds;

            double x = (((initialValue.X * initialMultiplier) + (finalValue.X * finalMultiplier)) / totalDivider);
            double y = (((initialValue.Y * initialMultiplier) + (finalValue.Y * finalMultiplier)) / totalDivider);
            return new Point(x, y);
        }
    }
}
