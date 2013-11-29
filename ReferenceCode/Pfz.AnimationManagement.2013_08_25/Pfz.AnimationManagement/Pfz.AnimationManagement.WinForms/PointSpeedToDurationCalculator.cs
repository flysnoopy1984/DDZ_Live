using System;
using System.Drawing;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.WinForms
{
    public sealed class PointSpeedToDurationCalculator:
        SpeedToDurationCalculator<Point>
    {
        static PointSpeedToDurationCalculator()
        {
            Initializer.Initialize();
        }

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
