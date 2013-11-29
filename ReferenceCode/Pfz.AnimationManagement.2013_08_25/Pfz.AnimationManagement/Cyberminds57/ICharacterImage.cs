
namespace Cyberminds57
{
    public interface ICharacterImage
    {
        LookDirection LookDirection { get; set; }

        int FrameCount { get; }
        int FrameIndex { get; set; }

        double Left { get; set; }
        double Top { get; set; }
    }
}
