using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class TimeLimitBuilder<TParent>:
        AnimationBuilder<TParent, TimeLimitBuilder<TParent>>
    {
        private TimeLimit _animation;
        internal TimeLimitBuilder(TParent parent, TimeLimit animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndTimeLimit()
        {
            return Parent;
        }

        public override TimeLimitBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
