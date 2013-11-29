using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.TimeManipulation;
using System;
using Pfz.AnimationManagement.Animations.Groups;

namespace Pfz.AnimationManagement.AnimationBuilders
{
	public class SequenceBuilder<TParent, TThis>:
		AnimationBuilder<TParent, TThis>
	{
        private SequentialAnimationGroup _animation;
        internal SequenceBuilder(TParent parent, SequentialAnimationGroup animation):
            base(parent)
        {
            _animation = animation;
        }

        public override TThis Add(IAnimation animation)
        {
            _animation.Add(animation);
            return This;
        }

        public TThis Wait(double seconds)
        {
            return Wait(TimeSpan.FromSeconds(seconds));
        }
        public TThis Wait(TimeSpan waitTime)
        {
            var animation = new Wait(waitTime);
            return Add(animation);
        }
	}
    public sealed class SequenceBuilder<TParent>:
        SequenceBuilder<TParent, SequenceBuilder<TParent>>
    {
        internal SequenceBuilder(TParent parent, SequentialAnimationGroup animation):
            base(parent, animation)
        {
        }
        public TParent EndSequence()
        {
            return Parent;
        }
    }
}
