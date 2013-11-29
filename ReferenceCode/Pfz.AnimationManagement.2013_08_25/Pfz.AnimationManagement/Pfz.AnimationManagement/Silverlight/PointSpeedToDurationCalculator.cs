using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.RangeCalculators
{
    public sealed class PointSpeedToDurationCalculator:
        SpeedToDurationCalculator<Point>
    {
        private static readonly PointSpeedToDurationCalculator _instance = new PointSpeedToDurationCalculator();
        public static PointSpeedToDurationCalculator Instance
        {
            get
            {
                return _instance;
            }
        }

        private PointSpeedToDurationCalculator()
        {
        }

        public override TimeSpan CalculateDuration(Point initialValue, Point finalValue, double speed)
        {
            double xDifference = Math.Abs(finalValue.X - initialValue.X);
            double yDifference = Math.Abs(finalValue.Y - initialValue.Y);
            double maxDifference = Math.Max(xDifference, yDifference);
            return TimeSpan.FromSeconds(maxDifference / speed);
        }
    }
}
