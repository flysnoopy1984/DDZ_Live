using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.Conditions
{
    /// <summary>
    /// This condition will immediately terminate an animation if
    /// the condition delegate returns true.
    /// </summary>
    public sealed class PrematureEndCondition:
        AnimationDecorator
    {
        private readonly Func<bool> _condition;
        public PrematureEndCondition(Func<bool> condition, bool resetOnPrematureEnd=false)
        {
            if (condition == null)
                throw new ArgumentNullException("condition");

            _condition = condition;
			ResetOnPrematureEnd = resetOnPrematureEnd;
        }

		public bool ResetOnPrematureEnd { get; private set; }

        private bool _ended;
        public override void Reset()
        {
            base.Reset();
            _ended = false;
        }

        public override bool Update(TimeSpan elapsed)
        {
            var innerAnimation = InnerAnimation;

            if (innerAnimation == null || _ended)
                return false;

            if (_condition())
            {
                _ended = true;

				if (ResetOnPrematureEnd)
					innerAnimation.Reset();

                return false;
            }
            
            bool result = innerAnimation.Update(elapsed);

            if (!result)
                _ended = true;

            return result;
        }
    }
}
