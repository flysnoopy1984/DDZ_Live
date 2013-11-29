using System.Drawing;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.WinForms
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
