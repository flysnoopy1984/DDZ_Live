using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.TimeManipulation
{
    public sealed class Wait:
        IAfterEndAwareAnimation
    {
        private readonly TimeSpan _waitTime;
        public Wait(TimeSpan waitTime)
        {
            if (waitTime < TimeSpan.Zero)
                throw new ArgumentOutOfRangeException("waitTime");

            _waitTime = waitTime;
        }
        public void Dispose()
        {
            IsUseless = true;
        }
        public bool IsUseless { get; private set; }

        private TimeSpan _total;
        public void Reset()
        {
            _total = TimeSpan.Zero;
        }

        public bool Update(TimeSpan elapsed)
        {
            _total += elapsed;

            return _total < _waitTime;
        }

        public TimeSpan ElapsedTimeAfterEnd
        {
            get
            {
                return _total - _waitTime;
            }
        }
    }
}
