using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Animations.TimeManipulation;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public class DeacceleratingEndBuilder<TParent>:
        AnimationBuilder<TParent, DeacceleratingEndBuilder<TParent>>
    {
        private AnimationDecorator _animation;
        internal DeacceleratingEndBuilder(TParent parent, AnimationDecorator animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndDeacceleratingEnd()
        {
            return Parent;
        }

        public override DeacceleratingEndBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
