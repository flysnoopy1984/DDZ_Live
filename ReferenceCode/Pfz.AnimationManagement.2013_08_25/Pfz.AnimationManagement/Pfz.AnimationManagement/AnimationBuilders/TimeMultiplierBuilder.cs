using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class TimeMultiplierBuilder<TParent>:
        AnimationBuilder<TParent, TimeMultiplierBuilder<TParent>>
    {
        private TimeMultiplier _animation;
        internal TimeMultiplierBuilder(TParent parent, TimeMultiplier animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndTimeMultiplier()
        {
            return Parent;
        }

        public override TimeMultiplierBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
