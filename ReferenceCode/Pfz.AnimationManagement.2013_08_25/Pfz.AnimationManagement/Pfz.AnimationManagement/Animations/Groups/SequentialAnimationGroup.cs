using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.Groups
{
    public sealed class SequentialAnimationGroup:
        AnimationGroup,
        IAfterEndAwareAnimation
    {
        private List<IAnimation> _animations = new List<IAnimation>();
        public override void Dispose()
        {
            var animations = _animations;
            if (animations != null)
            {
                _animations = null;

                foreach(var animation in animations)
                    animation.Dispose();
            }

            base.Dispose();
        }

        public TimeSpan ElapsedTimeAfterEnd { get; private set; }

        public override void Add(IAnimation animation)
        {
            if (animation == null)
                throw new ArgumentNullException("animation");

            _animations.Add(animation);
        }

        public override void Reset()
        {
			ElapsedTimeAfterEnd = TimeSpan.Zero;

            for(int i=_animations.Count-1; i>=0; i--)
            {
                var animation = _animations[i];

                if (animation.IsUseless)
                    _animations.RemoveAt(i);
            }

            _animationIndex = 0;
            foreach(var animation in _animations)
                animation.Reset();
        }

        private int _animationIndex;
        public override bool Update(TimeSpan elapsed)
        {
            if (_animations == null)
                return false;

            if (_animationIndex >= _animations.Count)
                return false;

            var animation = _animations[_animationIndex];
            if (!animation.IsUseless && animation.Update(elapsed))
                return true;

            while(true)
            {
                var afterEnd = animation as IAfterEndAwareAnimation;
                if (afterEnd != null)
                    ElapsedTimeAfterEnd = afterEnd.ElapsedTimeAfterEnd;
                else
                    ElapsedTimeAfterEnd = TimeSpan.Zero;

                if (MustRemoveEndedAnimations || animation.IsUseless)
                    _animations.RemoveAt(_animationIndex);
                else
                    _animationIndex++;

                while(true)
                {
                    if (_animationIndex >= _animations.Count)
                        return false;

                    animation = _animations[_animationIndex];

                    if (animation.IsUseless)
                    {
                        _animations.RemoveAt(_animationIndex);
                        continue;
                    }

                    if (ElapsedTimeAfterEnd <= TimeSpan.Zero)
                        return true;

                    if (animation.Update(ElapsedTimeAfterEnd))
                        return true;

                    break;
                }
            }
        }
    }
}
