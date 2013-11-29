using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;
using System.Windows.Media;
using System.Windows;

namespace Pfz.AnimationManagement.Wpf
{
    public static class Initializer
    {
        static Initializer()
        {
            RangeCalculator<Color>.Default = ColorRangeCalculator.Instance;
            SpeedToDurationCalculator<Color>.Default = ColorSpeedToDurationCalculator.Instance;
            RangeCalculator<Point>.Default = PointRangeCalculator.Instance;
            SpeedToDurationCalculator<Point>.Default = PointSpeedToDurationCalculator.Instance;
        }

        public static void Initialize()
        {
        }
    }
}
