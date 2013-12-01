using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement
{
    public sealed class FrameBasedAnimationHelper
    {
        private readonly _Animation _animation = new _Animation();
        private readonly TimeSpan _intervalBetweenFrames;

        public static FrameBasedAnimationHelper CreateByFps(double framesPerSecond)
        {
            if (framesPerSecond < 1)
                throw new ArgumentException("framesPerSecond must be at least one.", "framesPerSecond");

            TimeSpan interval = TimeSpan.FromMilliseconds(1000.0 / framesPerSecond);
            var result = new FrameBasedAnimationHelper(interval);
            return result;
        }

        public static FrameBasedAnimationHelper CreateByTime(TimeSpan intervalBetweenFrames)
        {
            var result = new FrameBasedAnimationHelper(intervalBetweenFrames);
            return result;
        }

        private FrameBasedAnimationHelper(TimeSpan intervalBetweenFrames)
        {
            if (intervalBetweenFrames <= TimeSpan.Zero)
                throw new ArgumentException("intervalBetweenFrames must be greater than zero.", "intervalBetweenFrames");

            _intervalBetweenFrames = intervalBetweenFrames;
        }

        public IAnimation WaitNextFrame()
        {
            _animation.Reset();
            _animation._waitTime = _intervalBetweenFrames;
            return _animation;
        }
        public IAnimation Wait(double timeInSeconds)
        {
            return Wait(TimeSpan.FromSeconds(timeInSeconds));
        }
        public IAnimation Wait(TimeSpan time)
        {
            if (time < TimeSpan.Zero)
                throw new ArgumentException("time must be at least 0.", "time");

            _animation.Reset();
            _animation._waitTime = time;
            return _animation;
        }

        private sealed class _Animation:
            IAfterEndAwareAnimation
        {
            internal TimeSpan _waitTime;

            public bool IsUseless
            {
                get
                {
                    return false;
                }
            }

            private TimeSpan _endedAt;
            private TimeSpan _accumulated;
            public void Reset()
            {
                _accumulated = TimeSpan.Zero;
                _endedAt = TimeSpan.Zero;
            }

            public bool Update(TimeSpan elapsed)
            {
                _accumulated += elapsed;
                if (_accumulated < _waitTime)
                    return true;

                _endedAt = _waitTime;
                return false;
            }

            public void Dispose()
            {
            }

            public TimeSpan ElapsedTimeAfterEnd
            {
                get
                {
                    return _accumulated - _endedAt;
                }
            }
        }
    }
}
