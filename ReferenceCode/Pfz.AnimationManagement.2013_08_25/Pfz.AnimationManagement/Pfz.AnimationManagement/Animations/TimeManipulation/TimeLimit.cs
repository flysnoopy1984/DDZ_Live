using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.TimeManipulation
{
	public sealed class TimeLimit:
		AnimationDecorator
	{
		private readonly TimeSpan _duration;
		public TimeLimit(TimeSpan duration)
		{
			if (duration <= TimeSpan.Zero)
				throw new ArgumentOutOfRangeException("duration");
			
			_duration = duration;
		}

		public override void Reset()
		{
			base.Reset();
			_total = TimeSpan.Zero;
		}
		public override TimeSpan ElapsedTimeAfterEnd
		{
			get
			{
				return _total - _duration;
			}
		}

		private TimeSpan _total;
		public override bool Update(TimeSpan elapsed)
		{
			TimeSpan oldTotal = _total;
			_total += elapsed;

			var innerAnimation = InnerAnimation;
			if (innerAnimation == null || oldTotal >= _duration)
				return false;

			if (_total > _duration)
				elapsed = _duration - oldTotal;

			bool result = innerAnimation.Update(elapsed);

			if (!result)
			{
				var afterEnd = innerAnimation as IAfterEndAwareAnimation;
				if (afterEnd != null)
					_total += afterEnd.ElapsedTimeAfterEnd;
			}

			return result;
		}
	}
}
