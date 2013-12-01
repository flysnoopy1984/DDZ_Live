using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Groups;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class ParallelBuilder<TParent>:
        AnimationBuilder<TParent, ParallelBuilder<TParent>>
    {
        private ParallelAnimationGroup _animation;
        internal ParallelBuilder(TParent parent, ParallelAnimationGroup animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndParallel()
        {
            return Parent;
        }

        public override ParallelBuilder<TParent> Add(IAnimation animation)
        {
            _animation.Add(animation);
            return This;
        }
    }
}
