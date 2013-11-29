using System;
using System.Collections.Generic;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
    public class ImperativeAnimation:
        IAfterEndAwareAnimation
    {
        [ThreadStatic]
        private static ImperativeAnimation _current;

        private List<IAnimation> _parallelAnimations = new List<IAnimation>();
        private IEnumerable<IAnimation> _animation;
        private IEnumerator<IAnimation> _enumerator;
        private IAnimation _innerAnimation;

        public ImperativeAnimation(IEnumerable<IAnimation> animation)
        {
            if (animation == null)
                throw new ArgumentNullException("animation");

            _animation = animation;
        }

        public void Dispose()
        {
            var innerAnimation = _innerAnimation;
            if (innerAnimation != null)
            {
                _innerAnimation = null;
                innerAnimation.Dispose();
            }

            var enumerator = _enumerator;
            if (enumerator != null)
            {
                _enumerator = null;
                enumerator.Dispose();
            }

            var parallelAnimations = _parallelAnimations;
            if (parallelAnimations != null)
            {
                _parallelAnimations = null;

                foreach(var animation in parallelAnimations)
                    animation.Reset();
            }

            _animation = null;
        }

        public bool IsUseless
        {
            get
            {
                return _animation == null;
            }
        }

        public TimeSpan ElapsedTimeAfterEnd { get; private set; }

        public void Reset()
        {
            var innerAnimation = _innerAnimation;
            if (innerAnimation != null)
            {
                _innerAnimation = null;
                innerAnimation.Reset();
            }

            var enumerator = _enumerator;
            if (enumerator != null)
            {
                _enumerator = null;
                enumerator.Dispose();
            }

            foreach(var animation in _parallelAnimations)
                animation.Reset();

            _parallelAnimations.Clear();

            _enumerator = _animation.GetEnumerator();
            _ended = false;
            ElapsedTimeAfterEnd = TimeSpan.Zero;
        }

        /// <summary>
        /// This method can only be invoked when an imperative animation is running.
        /// When it is invoked, it will add an animation to run in parallel to the actual imperative animation.
        /// Such animation is considered a subordinate, and so it will end abruptly if the main animation
        /// ends abruptly. Also, any time modifiers affecting the imperative animation will also
        /// affect the subordinated parallel animation.
        /// </summary>
        public static void AddSubordinatedParallel(IAnimation animation)
        {
            if (animation == null)
                throw new ArgumentNullException("animation");

            var current = _current;
            if (current == null)
                throw new InvalidOperationException("AddSubordinatedParallel can only be invoked when the ImperativeAnimation is running.");

            current._parallelAnimations.Add(animation);
        }

        private bool _ended;
        public bool Update(TimeSpan elapsed)
        {
            if (_ended)
            {
                ElapsedTimeAfterEnd += elapsed;
                return false;
            }

            var oldCurrent = _current;
            try
            {
                _current = this;

                var copy = _parallelAnimations.ToArray();
                foreach(var animation in copy)
                    if (animation.IsUseless || !animation.Update(elapsed))
                        _parallelAnimations.Remove(animation);

                while(true)
                {
                    var innerAnimation = _innerAnimation;
                    if (innerAnimation != null)
                    {
                        if (innerAnimation.Update(elapsed))
                            return true;

                        _innerAnimation = null;

                        var afterEnd = innerAnimation as IAfterEndAwareAnimation;
                        if (afterEnd == null)
                            return true;

                        elapsed = afterEnd.ElapsedTimeAfterEnd;
                        if (elapsed <= TimeSpan.Zero)
                            return true;
                    }

                    var enumerator = _enumerator;
                    if (enumerator == null)
                    {
                        enumerator = _animation.GetEnumerator();

                        if (enumerator == null)
                            throw new InvalidOperationException("The animation GetEnumerator() should never return null.");

                        _enumerator = enumerator;
                    }

                    bool result = enumerator.MoveNext();
                    if (!result)
                    {
                        _enumerator = null;
                        enumerator.Dispose();
                        _ended = true;
                        return false;
                    }

                    _innerAnimation = enumerator.Current;
                    if (_innerAnimation == null)
                        throw new InvalidOperationException("A frame based animation should never return null. If you only want to wait for the next frame, use the WaitNextFrame() method of the FrameBasedAnimationHelper.");
                }
            }
            finally
            {
                _current = oldCurrent;
            }
        }
    }
}
