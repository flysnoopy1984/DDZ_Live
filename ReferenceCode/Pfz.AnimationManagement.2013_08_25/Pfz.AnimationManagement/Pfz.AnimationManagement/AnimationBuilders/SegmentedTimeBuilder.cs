using System;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class SegmentedTimeBuilder<TParent>:
        AnimationBuilder<TParent, SegmentedTimeBuilder<TParent>>
    {
        private SegmentedTime _animation;
        internal SegmentedTimeBuilder(TParent parent, SegmentedTime animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndSegmentedTime()
        {
            if (Parent != null)
                return Parent;

            if (_animation.InnerAnimation == null)
                throw new InvalidOperationException("No animation was added to this segmented time.");

            object result = _animation;
            return (TParent)result;
        }

        public override SegmentedTimeBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
