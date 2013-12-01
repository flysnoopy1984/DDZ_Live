using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations.TimeManipulation
{
	public sealed class ProgressiveTimeMultiplier:
		AnimationDecorator
	{
		private readonly long _innerDurations;
		private readonly double[] _multipliers = new double[9];
		private readonly double _finalMultiplier;

		public ProgressiveTimeMultiplier(TimeSpan innerDuration, double initialMultiplier, double finalMultiplier)
		{
			if (innerDuration <= TimeSpan.Zero)
				throw new ArgumentException("innerDuration must be bigger than zero.", "innerDuration");

			if (initialMultiplier <= 0)
				throw new ArgumentException("initialMultiplier must be bigger than zero.", "initialMultiplier");

			if (finalMultiplier <= 0)
				throw new ArgumentException("finalMultiplier must be bigger than zero.", "finalMultiplier");

			_finalMultiplier = finalMultiplier;

			double totalDuration = 0;
			for(int i=0; i<9; i++)
			{
				double percentualPosition = (i + 1.0) / 10.0;

				double actualMultiplier = ((1.0-percentualPosition) * initialMultiplier) + (percentualPosition * finalMultiplier);
				_multipliers[i] = actualMultiplier;
				
				totalDuration += innerDuration.Ticks / actualMultiplier;
			}

			long totalTicks = (long)(totalDuration / 9);
			TimeSpan outerTime = new TimeSpan(totalTicks);
			_innerDurations = totalTicks / 9;
		}

		public override void Reset()
		{
			base.Reset();
			_total = 0;
		}
		public override TimeSpan ElapsedTimeAfterEnd
		{
			get
			{
				return TimeSpan.FromMilliseconds(base.ElapsedTimeAfterEnd.TotalMilliseconds / _finalMultiplier);
			}
		}

		private long _total = 0;
		public override bool Update(TimeSpan elapsed)
		{
			var innerAnimation = InnerAnimation;
			if (innerAnimation == null)
				return false;
			
			long newTotal = _total + elapsed.Ticks;

			double calculatedOldInnerTime = _CalculateInnerTime(_total);
			double calculatedNewInnerTime = _CalculateInnerTime(newTotal);
			var newElapsed = new TimeSpan((long)(calculatedNewInnerTime - calculatedOldInnerTime));

			_total = newTotal;
			return innerAnimation.Update(newElapsed);
		}

		private double _CalculateInnerTime(long value)
		{
			double result = 0;

			for(int i=0; i<9; i++)
			{
				double multiplier = _multipliers[i];

				if (value <= _innerDurations)
				{
					result += value * multiplier;
					return result;
				}

				result += _innerDurations * multiplier;
				value -= _innerDurations;
			}

			result += value * _finalMultiplier;
			return result;
		}
	}
}
