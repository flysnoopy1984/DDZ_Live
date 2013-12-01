using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class DisposeOnEndBuilder<TParent>:
        AnimationBuilder<TParent, DisposeOnEndBuilder<TParent>>
    {
        private readonly DisposeOnEndAnimation _animation;
        internal DisposeOnEndBuilder(TParent parent, DisposeOnEndAnimation animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndDisposeOnEnd()
        {
            return Parent;
        }

        public override DisposeOnEndBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return this;
        }
    }
}
