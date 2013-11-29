using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class LoopBuilder<TParent>:
        AnimationBuilder<TParent, LoopBuilder<TParent>>
    {
        private LoopAnimation _animation;
        internal LoopBuilder(TParent parent, LoopAnimation animation):
            base(parent)
        {
            _animation = animation;
        }
        public TParent EndLoop()
        {
            if (Parent != null)
                return Parent;

            if (_animation.InnerAnimation == null)
                throw new InvalidOperationException("No animation was added to this loop.");

            object result = _animation;
            return (TParent)result;
        }

        public override LoopBuilder<TParent> Add(IAnimation animation)
        {
            _animation.InnerAnimation = animation;
            return This;
        }
    }
}
