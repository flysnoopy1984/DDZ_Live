using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.TimeManipulation
{
    public sealed class TimeMultiplier:
        AnimationDecorator
    {
        private readonly double _multiplier;
        public TimeMultiplier(double multiplier)
        {
            if (multiplier <= 0)
                throw new ArgumentException("multiplier must be bigger than 0.", "multiplier");

            _multiplier = multiplier;
        }

        public override TimeSpan ElapsedTimeAfterEnd
        {
            get
            {
                long ticks = base.ElapsedTimeAfterEnd.Ticks;
                double dividedTicks = ticks / _multiplier;
                return new TimeSpan((long)dividedTicks);
            }
        }

        private TimeSpan _total;
        public override void Reset()
        {
            base.Reset();
            _total = TimeSpan.Zero;
        }

        public override bool Update(TimeSpan elapsed)
        {
            var animation = InnerAnimation;
            if (animation == null)
                return false;

            var oldMultiplied = _MultiplyTime(_total, _multiplier);
            _total += elapsed;
            var newMultiplied = _MultiplyTime(_total, _multiplier);

            elapsed = newMultiplied - oldMultiplied;

            return animation.Update(elapsed);
        }

        private static TimeSpan _MultiplyTime(TimeSpan value, double multiplier)
        {
            long ticks = value.Ticks;
            double doubleValue = ticks * multiplier;
            long newTicks = (long)doubleValue;
            return new TimeSpan(newTicks);
        }
    }
}
