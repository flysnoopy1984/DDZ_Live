using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.Conditions
{
	public sealed class PauseCondition:
		AnimationDecorator
	{
		public PauseCondition(Func<bool> condition)
		{
			if (condition == null)
				throw new ArgumentNullException("condition");

			Condition = condition;
		}

		public Func<bool> Condition { get; private set; }


		public override bool Update(TimeSpan elapsed)
		{
			var innerAnimation = InnerAnimation;

			if (innerAnimation == null)
				return false;

			if (Condition())
				return true;

			return innerAnimation.Update(elapsed);
		}
	}
}
