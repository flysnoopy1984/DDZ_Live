using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Animations.TimeManipulation;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class AcceleratingStartBuilder<TParent>:
        AnimationBuilder<TParent, AcceleratingStartBuilder<TParent>>
    {
        private ProgressiveTimeMultiplier _animation;
        internal AcceleratingStartBuilder(TParent parent, ProgressiveTimeMultiplier animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndAcceleratingStart()
        {
            return Parent;
        }

        public override AcceleratingStartBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
