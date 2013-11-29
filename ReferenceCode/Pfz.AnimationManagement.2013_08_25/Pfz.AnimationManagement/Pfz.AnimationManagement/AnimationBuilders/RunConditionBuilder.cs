using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Conditions;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class RunConditionBuilder<TParent>:
        AnimationBuilder<TParent, RunConditionBuilder<TParent>>
    {
        private readonly RunCondition _animation;
        internal RunConditionBuilder(TParent parent, RunCondition animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndRunCondition()
        {
            return Parent;
        }

        public override RunConditionBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return this;
        }
    }
}
