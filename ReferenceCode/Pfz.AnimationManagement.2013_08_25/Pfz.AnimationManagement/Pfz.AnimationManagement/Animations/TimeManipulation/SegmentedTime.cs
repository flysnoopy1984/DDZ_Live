using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.TimeManipulation
{
	/// <summary>
	/// This class segments elapsed times in maximum sizes, yet it applies the
	/// entire elapsed time to its inner animations, including values that are in-between
	/// the segments.
	/// This is useful if you have time-based animations and frame-based animations, so
	/// the collision detection will work consistently at certain intervals, in which all
	/// objects will be updated, yet it will allow time-based animations to accept 
	/// intermediate (more precise) values to be presented.
	/// </summary>
	public sealed class SegmentedTime:
		AnimationDecorator
	{
		public SegmentedTime(TimeSpan segmentDuration)
		{
			if (segmentDuration <= TimeSpan.Zero)
				throw new ArgumentOutOfRangeException("segmentDuration");

			SegmentDuration = segmentDuration;
		}

		public TimeSpan SegmentDuration { get; private set; }
		public Action SegmentCompleted { get; set; }

		private TimeSpan _additionalAfterEnd;
		private TimeSpan _accumulated;

		public override void Reset()
		{
			base.Reset();

			_accumulated = TimeSpan.Zero;
			_additionalAfterEnd = TimeSpan.Zero;
		}

		public override TimeSpan ElapsedTimeAfterEnd
		{
			get
			{
				return base.ElapsedTimeAfterEnd + _additionalAfterEnd;
			}
		}

		public override bool Update(TimeSpan elapsed)
		{
			var innerAnimation = InnerAnimation;

			if (innerAnimation == null)
				return false;

			if (_accumulated > TimeSpan.Zero)
			{
				TimeSpan remaining = SegmentDuration - _accumulated;

				if (elapsed >= remaining)
				{
					bool result = _SegmentCompleted(remaining);

					elapsed -= remaining;
					_accumulated = TimeSpan.Zero;

					if (!result)
					{
						_additionalAfterEnd = elapsed;
						return false;
					}
				}
			}

			while(elapsed >= SegmentDuration)
			{
				bool result = _SegmentCompleted(SegmentDuration);
				elapsed -= SegmentDuration;

				if (!result)
				{
					_additionalAfterEnd = elapsed;
					return false;
				}
			}

			if (elapsed > TimeSpan.Zero)
			{
				_accumulated = elapsed;
				return innerAnimation.Update(elapsed);
			}

			return true;
		}

		private bool _SegmentCompleted(TimeSpan elapsed)
		{
			bool result = InnerAnimation.Update(elapsed);

			if (!result)
				return false;

			var completed = SegmentCompleted;
			if (completed != null)
				completed();

			return true;
		}
	}
}
