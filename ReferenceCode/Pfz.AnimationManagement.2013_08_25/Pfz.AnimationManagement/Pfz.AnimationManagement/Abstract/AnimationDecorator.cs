using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
    public abstract class AnimationDecorator:
        IAfterEndAwareAnimation
    {
        public virtual void Dispose()
        {
            var innerAnimation = _innerAnimation;
            if (innerAnimation != null)
            {
                _innerAnimation = null;
                innerAnimation.Dispose();
            }
        }

        public bool IsUseless
        {
            get
            {
                var innerAnimation = _innerAnimation;

                if (innerAnimation == null)
                    return true;

                if (innerAnimation.IsUseless)
                {
                    _innerAnimation = null;
                    innerAnimation.Dispose();
                    return true;
                }

                return false;
            }
        }

        private IAnimation _innerAnimation;
        public IAnimation InnerAnimation
        {
            get
            {
                return _innerAnimation;
            }
            set
            {
                if (_innerAnimation != null)
                    throw new InvalidOperationException(GetType().Name + " already has an inner animation.");

                _innerAnimation = value;

                Reset();
            }
        }

        public virtual TimeSpan ElapsedTimeAfterEnd
        {
            get
            {
                var afterEnd = InnerAnimation as IAfterEndAwareAnimation;

                if (afterEnd == null)
                    return TimeSpan.Zero;

                return afterEnd.ElapsedTimeAfterEnd;
            }
        }

        public virtual void Reset()
        {
            var innerAnimation = InnerAnimation;
            if (innerAnimation != null)
                innerAnimation.Reset();
        }

        public abstract bool Update(TimeSpan elapsed);
    }
}
