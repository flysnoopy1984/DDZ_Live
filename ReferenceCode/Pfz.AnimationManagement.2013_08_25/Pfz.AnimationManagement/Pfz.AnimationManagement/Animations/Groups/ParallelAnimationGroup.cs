using System;
using System.Collections.Generic;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.Groups
{
    public sealed class ParallelAnimationGroup:
        AnimationGroup
    {
        private List<IAnimation> _animations = new List<IAnimation>();
        private List<IAnimation> _runningAnimations = new List<IAnimation>();

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

        public override void Add(IAnimation animation)
        {
            if (animation == null)
                throw new ArgumentNullException("animation");

            _animations.Add(animation);
            _runningAnimations.Add(animation);
        }

        public override void Reset()
        {
            _RemoveUseless();

            foreach(var animation in _animations)
                animation.Reset();

            _runningAnimations.Clear();
            _runningAnimations.AddRange(_animations);
        }

        public override bool Update(TimeSpan elapsed)
        {
            bool anyOk = false;

            var copy = _runningAnimations.ToArray();
            foreach(var animation in copy)
			{
                if (animation.Update(elapsed))
                    anyOk = true;
				else
                {
                    _runningAnimations.Remove(animation);

                    if (MustRemoveEndedAnimations)
                        _animations.Remove(animation);
                }
			}

            _RemoveUseless();

            return anyOk;
        }

        private void _RemoveUseless()
        {
            for(int i=_animations.Count-1; i>=0; i--)
            {
                var animation = _animations[i];

                if (animation.IsUseless)
                {
                    _runningAnimations.Remove(animation);
                    _animations.RemoveAt(i);
                }
            }
        }
    }
}
