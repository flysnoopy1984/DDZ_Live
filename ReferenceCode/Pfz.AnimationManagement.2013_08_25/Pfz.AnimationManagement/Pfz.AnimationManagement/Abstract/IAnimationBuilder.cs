
namespace Pfz.AnimationManagement.Abstract
{
    /// <summary>
    /// Interface that can be used as the constraint to generate
    /// extension methods to the animation builder.
    /// </summary>
    public interface IAnimationBuilder
    {
        /// <summary>
        /// Adds a new animation to this builder.
        /// </summary>
        void Add(IAnimation animation);
    }
}
