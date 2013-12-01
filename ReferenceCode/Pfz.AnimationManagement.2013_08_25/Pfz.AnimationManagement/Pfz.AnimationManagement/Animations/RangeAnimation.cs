using System;
using Pfz.AnimationManagement.RangeCalculators;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
    public sealed class RangeAnimation<T>:
        IAfterEndAwareAnimation
    {
        private readonly Action<T> _update;
		public RangeAnimation(T initialValue, T finalValue, double durationInSeconds, Action<T> update):
			this(initialValue, finalValue, TimeSpan.FromSeconds(durationInSeconds), update)
		{
		}
		public RangeAnimation(T initialValue, T finalValue, TimeSpan duration, Action<T> update):
			this(initialValue, finalValue, duration, update, null)
		{
		}
        public RangeAnimation(T initialValue, T finalValue, double durationInSeconds, Action<T> update, IRangeCalculator<T> calculator):
            this(initialValue, finalValue, TimeSpan.FromSeconds(durationInSeconds), update, calculator)
        {
        }
        public RangeAnimation(T initialValue, T finalValue, TimeSpan duration, Action<T> update, IRangeCalculator<T> calculator)
		{
			if (duration < TimeSpan.Zero)	
				throw new ArgumentException("duration must be at least zero.", "duration");

			if (update == null)
				throw new ArgumentNullException("update");

			if (calculator == null)
            {
                calculator = RangeCalculator<T>.Default;

                if (calculator == null)
			    	throw new InvalidOperationException("A range calculator for the type " + typeof(T).FullName + " was not given and a default one is not registered.");
            }

			InitialValue = initialValue;
			FinalValue = finalValue;
			Duration = duration;
			_update = update;
			Calculator = calculator;
		}
        public void Dispose()
        {
            IsUseless = true;
        }

		public T InitialValue { get; private set; }
		public T FinalValue { get; private set; }
		public TimeSpan Duration { get; private set; }
		public IRangeCalculator<T> Calculator { get; private set; }
        public bool IsUseless { get; private set; }

        private TimeSpan _total;
        public TimeSpan ElapsedTimeAfterEnd
        {
            get
            {
                return _total - Duration;
            }
        }

        public void Reset()
        {
            _total = TimeSpan.Zero;
        }

        public bool Update(TimeSpan elapsed)
        {
            _total += elapsed;

            if (_total >= Duration)
            {
                _update(FinalValue);
                return false;
            }

            T value = Calculator.Calculate(InitialValue, FinalValue, _total, Duration);
            _update(value);
            return true;
        }
    }
}
