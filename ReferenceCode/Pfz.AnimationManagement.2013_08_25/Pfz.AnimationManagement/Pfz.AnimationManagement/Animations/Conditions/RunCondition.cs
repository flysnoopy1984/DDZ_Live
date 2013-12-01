using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.Conditions
{
    /// <summary>
    /// This Condition animation will only start another animation if the condition
    /// is true. Note that after the inner animation is started the condition
    /// can change but the animation will continue to run.
    /// </summary>
    public sealed class RunCondition:
        AnimationDecorator
    {
        private readonly Func<bool> _condition;

        public RunCondition(Func<bool> condition)
        {
            if (condition == null)
                throw new ArgumentNullException("condition");

            _condition = condition;
        }

        private bool _started;
        private bool _ended;
        public override void Reset()
        {
            base.Reset();
            _started = false;
            _ended = false;
        }
		public override TimeSpan ElapsedTimeAfterEnd
		{
			get
			{
				if (_ended)
					return base.ElapsedTimeAfterEnd;

				return TimeSpan.Zero;
			}
		}

        public override bool Update(TimeSpan elapsed)
        {
            var innerAnimation = InnerAnimation;

            if (innerAnimation == null || _ended)
                return false;

            if (!_started)
            {
                _started = true;

                if (!_condition())
                {
                    _ended = true;
                    return false;
                }
            }

            bool result = innerAnimation.Update(elapsed);

            if (!result)
                _ended = true;

            return result;
        }
    }
}
