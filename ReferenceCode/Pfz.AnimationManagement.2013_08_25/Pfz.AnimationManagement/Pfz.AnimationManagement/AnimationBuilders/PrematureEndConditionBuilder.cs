using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Conditions;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class PrematureEndConditionBuilder<TParent>:
        AnimationBuilder<TParent, PrematureEndConditionBuilder<TParent>>
    {
        private readonly PrematureEndCondition _animation;
        internal PrematureEndConditionBuilder(TParent parent, PrematureEndCondition animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndPrematureEndCondition()
        {
            return Parent;
        }

        public override PrematureEndConditionBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
