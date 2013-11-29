using System;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Animations.Groups;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement.AnimationBuilders
{
    public sealed class ProgressiveTimeMultipliersBuilder<TParent>:
		AnimationBuilder<TParent, ProgressiveTimeMultipliersBuilder<TParent>>
    {
		private readonly SequentialAnimationGroup _sequence;
		private readonly AnimationReference _reference = new AnimationReference();
		private double _actualMultiplier;
        internal ProgressiveTimeMultipliersBuilder(TParent parent, SequentialAnimationGroup sequence, double initialMultiplier):
			base(parent)
        {
			if (initialMultiplier <= 0)
				throw new ArgumentException("initialMultipliser must be bigger than zero.", "initialMultiplier");

            _sequence = sequence;
			_actualMultiplier = initialMultiplier;
        }
        public TParent EndProgressiveTimeMultipliers()
        {
            return Parent;
        }

        public override ProgressiveTimeMultipliersBuilder<TParent> Add(IAnimation animation)
        {
			if (animation == null)
				throw new ArgumentNullException("animation");

			if (_reference.InnerAnimation != null)
				throw new InvalidOperationException("Only a single animation can be added to the time multipliers builder.");

			_reference.InnerAnimation = animation;
            return this;
        }

		public ProgressiveTimeMultipliersBuilder<TParent> MultiplySpeed(double finalSpeed, double timeToAchiveNewSpeedInSeconds)
		{
			return MultiplySpeed(finalSpeed, TimeSpan.FromSeconds(timeToAchiveNewSpeedInSeconds));
		}
		public ProgressiveTimeMultipliersBuilder<TParent> MultiplySpeed(double finalSpeed, TimeSpan timeToAchiveNewSpeed)
		{
			var animation = new ProgressiveTimeMultiplier(timeToAchiveNewSpeed, _actualMultiplier, finalSpeed);
			var timeLimit = new TimeLimit(timeToAchiveNewSpeed);
			timeLimit.InnerAnimation = _reference;
			animation.InnerAnimation = timeLimit;
			_actualMultiplier = finalSpeed;
			_sequence.Add(animation);
			return this;
		}

		public ProgressiveTimeMultipliersBuilder<TParent> KeepSpeed(double innerTimeInSeconds)
		{
			return KeepSpeed(TimeSpan.FromSeconds(innerTimeInSeconds));
		}
		public ProgressiveTimeMultipliersBuilder<TParent> KeepSpeed(TimeSpan innerTime)
		{
			var timeLimit = new TimeLimit(innerTime);
			timeLimit.InnerAnimation = _reference;

			IAnimation animation = timeLimit;

			if (_actualMultiplier != 1)
			{
				var timeMultiplier = new TimeMultiplier(_actualMultiplier);
				timeMultiplier.InnerAnimation = animation;
				animation = timeMultiplier;
			}

			_sequence.Add(animation);
			return this;
		}

		public ProgressiveTimeMultipliersBuilder<TParent> KeepSpeedUntilEnd()
		{
			IAnimation animation = _reference;

			if (_actualMultiplier != 1)
			{
				var timeMultiplier = new TimeMultiplier(_actualMultiplier);
				timeMultiplier.InnerAnimation = animation;
				animation = timeMultiplier;
			}

			_sequence.Add(animation);
			return this;
		}
	}
}
