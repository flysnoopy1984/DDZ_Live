using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class ProgressiveTimeMultiplierBuilder<TParent>:
        AnimationBuilder<TParent, ProgressiveTimeMultiplierBuilder<TParent>>
    {
        private ProgressiveTimeMultiplier _animation;
        internal ProgressiveTimeMultiplierBuilder(TParent parent, ProgressiveTimeMultiplier animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndProgressiveTimeMultiplier()
        {
            return Parent;
        }

        public override ProgressiveTimeMultiplierBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
