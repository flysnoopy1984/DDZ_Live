using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
    public sealed class DisposeOnEndAnimation:
        AnimationDecorator
    {
        public override void Reset()
        {
            Dispose();
        }
        public override bool Update(TimeSpan elapsed)
        {
            var innerAnimation = InnerAnimation;

            if (innerAnimation == null)
                return false;

            if (innerAnimation.IsUseless)
            {
                Dispose();
                return false;
            }

            bool result = innerAnimation.Update(elapsed);

            if (!result)
                Dispose();

            return result;
        }
    }
}
