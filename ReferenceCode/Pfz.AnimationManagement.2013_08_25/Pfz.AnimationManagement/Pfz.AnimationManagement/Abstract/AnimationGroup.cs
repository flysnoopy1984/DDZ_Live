using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Animations;

namespace Pfz.AnimationManagement.Abstract
{
    public abstract class AnimationGroup:
        IAnimationGroup
    {
		internal AnimationGroup()
		{
		}
        public virtual void Dispose()
        {
            IsUseless = true;
        }

        public bool IsUseless { get; private set; }
        public bool MustRemoveEndedAnimations { get; set; }

        public abstract void Reset();
        public abstract bool Update(TimeSpan elapsed);

        public abstract void Add(IAnimation animation);

        public void Add(IEnumerable<IAnimation> animation)
        {
            var frameBasedAnimation = new ImperativeAnimation(animation);
            Add(frameBasedAnimation);
        }
    }
}
