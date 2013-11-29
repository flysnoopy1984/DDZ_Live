using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Conditions;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class PauseConditionBuilder<TParent>:
        AnimationBuilder<TParent, PauseConditionBuilder<TParent>>
    {
        private readonly PauseCondition _animation;
        internal PauseConditionBuilder(TParent parent, PauseCondition animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndPauseCondition()
        {
            return Parent;
        }

        public override PauseConditionBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
