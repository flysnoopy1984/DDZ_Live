using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Animations.Groups;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.AnimationBuilders
{
	public sealed class RangesBuilder<TParent, TValue>:
		SequenceBuilder<TParent, RangesBuilder<TParent, TValue>>
	{
		private SequentialAnimationGroup _animation;
		private TValue _lastValue;
		private readonly Action<TValue> _update;
		internal RangesBuilder(TParent parent, SequentialAnimationGroup animation, TValue initialValue, Action<TValue> update):
			base(parent, animation)
		{
			if (update == null)
				throw new ArgumentNullException("update");

			_animation = animation;
			_update = update;
			_lastValue = initialValue;
		}
		public TParent EndRanges()
		{
			return Parent;
		}

		public RangesBuilder<TParent, TValue> To(TValue value, double durationInSeconds)
		{
			Range(_lastValue, value, durationInSeconds, _update);
			_lastValue = value;
			return this;
		}
		public RangesBuilder<TParent, TValue> To(TValue value, TimeSpan duration)
		{
			Range(_lastValue, value, duration, _update);
			_lastValue = value;
			return this;
		}

		public RangesBuilder<TParent, TValue> ChangeInitialValue(TValue value)
		{
			_lastValue = value;
			return this;
		}
	}
}
