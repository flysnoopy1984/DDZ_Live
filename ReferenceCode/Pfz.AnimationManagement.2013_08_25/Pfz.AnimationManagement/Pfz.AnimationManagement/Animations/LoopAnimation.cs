using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
    public sealed class LoopAnimation:
        AnimationDecorator
    {
        private readonly int _repetitionCount;
        private int _executed;

        /// <summary>
        /// Creates a new Loop animation that will loop the given animation
        /// the given amount of times. If the value is -1 it will be an infinite
        /// loop.
        /// </summary>
        public LoopAnimation(int repetitionCount=-1)
        {
            if (repetitionCount < -1)
                throw new ArgumentException("Repetition count can be -1 to say that it is infinite, but it can't be another negative value.", "repetitionCount");

            _repetitionCount = repetitionCount;
        }

        public override void Reset()
        {
            base.Reset();

            _executed = 0;
            _ended = false;
        }

        private bool _ended;
        public override bool Update(TimeSpan elapsed)
        {
            var innerAnimation = InnerAnimation;
            if (_ended || innerAnimation == null)
                return false;

            while(!innerAnimation.Update(elapsed))
            {
                if (_repetitionCount != -1)
                {
                    _executed ++;

                    if (_executed >= _repetitionCount)
                    {
                        _ended = true;
                        return false;
                    }
                }

                var afterEndAware = innerAnimation as IAfterEndAwareAnimation;
                if (afterEndAware == null)
                {
                    innerAnimation.Reset();
                    break;
                }

                var elapsedAfterEnd = afterEndAware.ElapsedTimeAfterEnd;

                elapsed = elapsedAfterEnd;

                afterEndAware.Reset();
                if (elapsed <= TimeSpan.Zero)
                    break;
            }

            return true;
        }
    }
}
