using System;
using System.Collections.Generic;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.AnimationBuilders;
using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Animations.Conditions;
using Pfz.AnimationManagement.Animations.Groups;
using Pfz.AnimationManagement.Animations.TimeManipulation;

namespace Pfz.AnimationManagement
{
    public static class AnimationBuilder
    {
		public static RangeAnimation<T> Range<T>(T initialValue, T finalValue, TimeSpan duration, Action<T> update)
		{
			return new RangeAnimation<T>(initialValue, finalValue, duration, update);
		}
		public static RangeAnimation<T> Range<T>(T initialValue, T finalValue, TimeSpan duration, Action<T> update, IRangeCalculator<T> calculator)
		{
			return new RangeAnimation<T>(initialValue, finalValue, duration, update, calculator);
		}
		public static RangeAnimation<T> Range<T>(T initialValue, T finalValue, double durationInSeconds, Action<T> update)
		{
			return new RangeAnimation<T>(initialValue, finalValue, durationInSeconds, update);
		}
		public static RangeAnimation<T> Range<T>(T initialValue, T finalValue, double durationInSeconds, Action<T> update, IRangeCalculator<T> calculator)
		{
			return new RangeAnimation<T>(initialValue, finalValue, durationInSeconds, update, calculator);
		}

        public static RangeAnimation<T> RangeBySpeed<T>(T initialValue, T finalValue, double speed, Action<T> update)
        {
            return RangeBySpeed(initialValue, finalValue, speed, update, null);
        }
        public static RangeAnimation<T> RangeBySpeed<T>(T initialValue, T finalValue, double speed, Action<T> update, IRangeCalculator<T> calculator)
        {
            if (speed <= 0)
                throw new ArgumentException("speed must be greater than zero.", "speed");

            var speedToDurationCalculator = SpeedToDurationCalculator<T>.Default;
            if (speedToDurationCalculator == null)
                  throw new InvalidOperationException("There is no default SpeedToDurationCalculator for the type: " + typeof(T).FullName + ".");

            var duration = speedToDurationCalculator.CalculateDuration(initialValue, finalValue, speed);
            var result = Range(initialValue, finalValue, duration, update, calculator);
            return result;
        }

        public static IAnimation RangeBySpeed<T>(Func<T> initialValueGetter, T finalValue, double speed, Action<T> update)
        {
            return RangeBySpeed(initialValueGetter, finalValue, speed, update, null);
        }
        public static IAnimation RangeBySpeed<T>(Func<T> initialValueGetter, T finalValue, double speed, Action<T> update, IRangeCalculator<T> calculator)
        {
            if (initialValueGetter == null)
                throw new ArgumentNullException("initialValueGetter");

            if (update == null)
                throw new ArgumentNullException("update");

            return new ImperativeAnimation(_LazyRangeBySpeed(initialValueGetter, finalValue, speed, update, calculator));
        }

        private static IEnumerable<IAnimation> _LazyRangeBySpeed<T>(Func<T> initialValueGetter, T finalValue, double speed, Action<T> update, IRangeCalculator<T> calculator)
        {
            T initialValue = initialValueGetter();
            yield return RangeBySpeed(initialValue, finalValue, speed, update, calculator);
        }

        public static LoopBuilder<LoopAnimation> BeginLoop(int repetitionCount=-1)
        {
            var loopAnimation = new LoopAnimation(repetitionCount);
            return new LoopBuilder<LoopAnimation>(null, loopAnimation);
        }

        public static SegmentedTimeBuilder<SegmentedTime> BeginSegmentedTime(TimeSpan segmentDuration, Action segmentCompleted=null)
        {
            var animation = new SegmentedTime(segmentDuration);
			animation.SegmentCompleted = segmentCompleted;
            return new SegmentedTimeBuilder<SegmentedTime>(null, animation);
        }

        public static SequenceBuilder<SequentialAnimationGroup> BeginSequence(bool disposeEndedAnimations=false)
        {
            var animation = new SequentialAnimationGroup();
            animation.MustRemoveEndedAnimations = disposeEndedAnimations;
            return new SequenceBuilder<SequentialAnimationGroup>(animation, animation);
        }
        public static ParallelBuilder<ParallelAnimationGroup> BeginParallel(bool disposeEndedAnimations=false)
        {
            var animation = new ParallelAnimationGroup();
            animation.MustRemoveEndedAnimations = disposeEndedAnimations;
            return new ParallelBuilder<ParallelAnimationGroup>(animation, animation);
        }

        public static TimeMultiplierBuilder<TimeMultiplier> BeginTimeMultiplier(double multiplier)
        {
            var animation = new TimeMultiplier(multiplier);
            return new TimeMultiplierBuilder<TimeMultiplier>(animation, animation);
        }


        public static AcceleratingStartBuilder<ProgressiveTimeMultiplier> BeginAcceleratingStart(double accelerationDurationInSeconds)
        {
			TimeSpan accelerationDuration = TimeSpan.FromSeconds(accelerationDurationInSeconds);
			return BeginAcceleratingStart(accelerationDuration);
        }
        public static AcceleratingStartBuilder<ProgressiveTimeMultiplier> BeginAcceleratingStart(TimeSpan accelerationDuration)
        {
            var animation = new ProgressiveTimeMultiplier(accelerationDuration, 0.2, 1);
            return new AcceleratingStartBuilder<ProgressiveTimeMultiplier>(animation, animation);
        }
        public static DeacceleratingEndBuilder<IAnimation> BeginDeacceleratingEnd(double deaccelerationDurationInSeconds)
        {
			TimeSpan deaccelerationDuration = TimeSpan.FromSeconds(deaccelerationDurationInSeconds);
			return BeginDeacceleratingEnd(deaccelerationDuration);
        }
        public static DeacceleratingEndBuilder<IAnimation> BeginDeacceleratingEnd(TimeSpan deaccelerationDuration)
        {
            var animation = new ProgressiveTimeMultiplier(deaccelerationDuration, 1, 0.2);
            return new DeacceleratingEndBuilder<IAnimation>(animation, animation);
        }
        public static DeacceleratingEndBuilder<IAnimation> BeginDeacceleratingEnd(double deaccelerationDurationInSeconds, double totalDurationInSeconds)
        {
			TimeSpan deaccelerationDuration = TimeSpan.FromSeconds(deaccelerationDurationInSeconds);
			TimeSpan totalDuration = TimeSpan.FromSeconds(totalDurationInSeconds);
			return BeginDeacceleratingEnd(deaccelerationDuration, totalDuration);
        }
        public static DeacceleratingEndBuilder<IAnimation> BeginDeacceleratingEnd(TimeSpan deaccelerationDuration, TimeSpan totalDuration)
        {
			if (totalDuration < deaccelerationDuration)
				throw new ArgumentException("totalDuration must be at least equal to deaccelerationDuration", "totalDuration");

			if (totalDuration == deaccelerationDuration)
				return BeginDeacceleratingEnd(deaccelerationDuration);

			var reference = new AnimationReference();

			TimeSpan initialWait = totalDuration - deaccelerationDuration;
			var timeLimit = new TimeLimit(initialWait);
			timeLimit.InnerAnimation = reference;

			var end = new ProgressiveTimeMultiplier(deaccelerationDuration, 1, 0.2);
			end.InnerAnimation = reference;

			var sequence = new SequentialAnimationGroup();
			sequence.Add(timeLimit);
			sequence.Add(end);

            return new DeacceleratingEndBuilder<IAnimation>(sequence, reference);
        }


        public static DisposeOnEndBuilder<DisposeOnEndAnimation> BeginDisposeOnEnd()
        {
            var animation = new DisposeOnEndAnimation();
            return new DisposeOnEndBuilder<DisposeOnEndAnimation>(animation, animation);
        }

        public static RunConditionBuilder<RunCondition> BeginRunCondition(Func<bool> condition)
        {
            var animation = new RunCondition(condition);
            return new RunConditionBuilder<RunCondition>(animation, animation);
        }
        public static PrematureEndConditionBuilder<PrematureEndCondition> BeginPrematureEndCondition(Func<bool> condition, bool resetOnPrematureEnd=false)
        {
            var animation = new PrematureEndCondition(condition, resetOnPrematureEnd);
            return new PrematureEndConditionBuilder<PrematureEndCondition>(animation, animation);
        }
        public static PauseConditionBuilder<PauseCondition> BeginPauseCondition(Func<bool> condition)
        {
            var animation = new PauseCondition(condition);
            return new PauseConditionBuilder<PauseCondition>(animation, animation);
        }

		public static RangesBuilder<SequentialAnimationGroup, TValue> BeginRanges<TValue>(Action<TValue> update)
		{
			return BeginRanges<TValue>(update, default(TValue));
		}
		public static RangesBuilder<SequentialAnimationGroup, TValue> BeginRanges<TValue>(Action<TValue> update, TValue initialValue)
		{
			var animation = new SequentialAnimationGroup();
			return new RangesBuilder<SequentialAnimationGroup,TValue>(animation, animation, initialValue, update);
		}

		public static ProgressiveTimeMultipliersBuilder<IAnimation> BeginProgressiveTimeMultipliers(double initialMultiplier=1)
		{
			var animation = new SequentialAnimationGroup();
			return new ProgressiveTimeMultipliersBuilder<IAnimation>(animation, animation, initialMultiplier);
		}

		public static ProgressiveTimeMultiplierBuilder<ProgressiveTimeMultiplier> BeginProgressiveTimeMultiplier(double innerDurationInSeconds, double initialMultiplier, double finalMultiplier)
		{
			TimeSpan innerDuration = TimeSpan.FromSeconds(innerDurationInSeconds);
			return BeginProgressiveTimeMultiplier(innerDuration, initialMultiplier, finalMultiplier);
		}
		public static ProgressiveTimeMultiplierBuilder<ProgressiveTimeMultiplier> BeginProgressiveTimeMultiplier(TimeSpan innerDuration, double initialMultiplier, double finalMultiplier)
		{
			var animation = new ProgressiveTimeMultiplier(innerDuration, initialMultiplier, finalMultiplier);
			return new ProgressiveTimeMultiplierBuilder<ProgressiveTimeMultiplier>(animation, animation);
		}

        public static TimeLimitBuilder<TimeLimit> BeginTimeLimit(double durationInSeconds)
        {
            TimeSpan duration = TimeSpan.FromSeconds(durationInSeconds);
            return BeginTimeLimit(duration);
        }
        public static TimeLimitBuilder<TimeLimit> BeginTimeLimit(TimeSpan duration)
        {
            var animation = new TimeLimit(duration);
            return new TimeLimitBuilder<TimeLimit>(animation, animation);
        }
    }
    public abstract class AnimationBuilder<TParent, TThis>:
        IAnimationBuilder
    {
        protected AnimationBuilder(TParent parent)
        {
            Parent = parent;
            This = (TThis)((object)this);
        }

        protected TParent Parent { get; private set; }
        protected TThis This { get; private set; }

        public abstract TThis Add(IAnimation animation);
        public TThis Add(IEnumerable<IAnimation> animation)
        {
            var frameBasedAnimation = new ImperativeAnimation(animation);
            return Add(frameBasedAnimation);
        }

        public TThis Add(Action updateAction, Action resetAction=null, Action disposeAction=null)
        {
            var animation = new DelegatedAnimation();

            if (updateAction != null)
                animation.Updating = 
                    (ignored) => 
                    {
                        updateAction();
                        return false;
                    };

            animation.Resetting = resetAction;
            animation.Disposing = disposeAction;
            Add(animation);
            return This;
        }
        public TThis Add(Func<TimeSpan, bool> updateFunction, Action resetAction=null, Action disposeAction=null)
        {
            var animation = new DelegatedAnimation();
            animation.Updating = updateFunction;
            animation.Resetting = resetAction;
            animation.Disposing = disposeAction;
            Add(animation);
            return This;
        }

        public TThis Range<T>(T initialValue, T finalValue, TimeSpan duration, Action<T> update)
        {
            var rangeAnimation = AnimationBuilder.Range(initialValue, finalValue, duration, update);
            return Add(rangeAnimation);
        }
        public TThis Range<T>(T initialValue, T finalValue, TimeSpan duration, Action<T> update, IRangeCalculator<T> calculator)
        {
            var rangeAnimation = AnimationBuilder.Range(initialValue, finalValue, duration, update, calculator);
            return Add(rangeAnimation);
        }
        public TThis Range<T>(T initialValue, T finalValue, double durationInSeconds, Action<T> update)
        {
            var rangeAnimation = AnimationBuilder.Range(initialValue, finalValue, durationInSeconds, update);
            return Add(rangeAnimation);
        }
        public TThis Range<T>(T initialValue, T finalValue, double durationInSeconds, Action<T> update, IRangeCalculator<T> calculator)
        {
            var rangeAnimation = AnimationBuilder.Range(initialValue, finalValue, durationInSeconds, update, calculator);
            return Add(rangeAnimation);
        }

        public TThis RangeBySpeed<T>(T initialValue, T finalValue, double speed, Action<T> update)
        {
            var animation = AnimationBuilder.RangeBySpeed(initialValue, finalValue, speed, update);
            return Add(animation);
        }
        public TThis RangeBySpeed<T>(T initialValue, T finalValue, double speed, Action<T> update, IRangeCalculator<T> calculator)
        {
            var animation = AnimationBuilder.RangeBySpeed(initialValue, finalValue, speed, update, calculator);
            return Add(animation);
        }

        public TThis RangeBySpeed<T>(Func<T> initialValueGetter, T finalValue, double speed, Action<T> update)
        {
            var animation = AnimationBuilder.RangeBySpeed(initialValueGetter, finalValue, speed, update);
            return Add(animation);
        }
        public TThis RangeBySpeed<T>(Func<T> initialValueGetter, T finalValue, double speed, Action<T> update, IRangeCalculator<T> calculator)
        {
            var animation = AnimationBuilder.RangeBySpeed(initialValueGetter, finalValue, speed, update, calculator);
            return Add(animation);
        }


        public LoopBuilder<TThis> BeginLoop(int repetitionCount = -1)
        {
            var animation = new LoopAnimation(repetitionCount);
            Add(animation);
            return new LoopBuilder<TThis>(This, animation);
        }

        public SegmentedTimeBuilder<TThis> BeginSegmentedTime(TimeSpan segmentDuration, Action segmentCompleted=null)
        {
            var animation = new SegmentedTime(segmentDuration);
			animation.SegmentCompleted = segmentCompleted;
			Add(animation);
            return new SegmentedTimeBuilder<TThis>(This, animation);
        }

        public ParallelBuilder<TThis> BeginParallel(bool disposeEndedAnimations=false)
        {
            var animation = new ParallelAnimationGroup();
            animation.MustRemoveEndedAnimations = disposeEndedAnimations;
            Add(animation);
            return new ParallelBuilder<TThis>(This, animation);
        }
        public SequenceBuilder<TThis> BeginSequence(bool disposeEndedAnimations=false)
        {
            var animation = new SequentialAnimationGroup();
            animation.MustRemoveEndedAnimations = disposeEndedAnimations;
            Add(animation);
            return new SequenceBuilder<TThis>(This, animation);
        }

        public TimeMultiplierBuilder<TThis> BeginTimeMultiplier(double multiplier)
        {
            var animation = new TimeMultiplier(multiplier);
            Add(animation);
            return new TimeMultiplierBuilder<TThis>(This, animation);
        }

        public AcceleratingStartBuilder<TThis> BeginAcceleratingStart(double accelerationDurationInSeconds)
        {
			TimeSpan accelerationDuration = TimeSpan.FromSeconds(accelerationDurationInSeconds);
			return BeginAcceleratingStart(accelerationDuration);
        }
        public AcceleratingStartBuilder<TThis> BeginAcceleratingStart(TimeSpan accelerationDuration)
        {
            var animation = new ProgressiveTimeMultiplier(accelerationDuration, 0.2, 1);
			Add(animation);
            return new AcceleratingStartBuilder<TThis>(This, animation);
        }
        public DeacceleratingEndBuilder<TThis> BeginDeacceleratingEnd(double deaccelerationDurationInSeconds)
        {
			TimeSpan deaccelerationDuration = TimeSpan.FromSeconds(deaccelerationDurationInSeconds);
			return BeginDeacceleratingEnd(deaccelerationDuration);
        }
        public DeacceleratingEndBuilder<TThis> BeginDeacceleratingEnd(TimeSpan deaccelerationDuration)
        {
            var animation = new ProgressiveTimeMultiplier(deaccelerationDuration, 1, 0.2);
			Add(animation);
            return new DeacceleratingEndBuilder<TThis>(This, animation);
        }
        public DeacceleratingEndBuilder<TThis> BeginDeacceleratingEnd(double deaccelerationDurationInSeconds, double totalDurationInSeconds)
        {
			TimeSpan deaccelerationDuration = TimeSpan.FromSeconds(deaccelerationDurationInSeconds);
			TimeSpan totalDuration = TimeSpan.FromSeconds(totalDurationInSeconds);
			return BeginDeacceleratingEnd(deaccelerationDuration, totalDuration);
        }
        public DeacceleratingEndBuilder<TThis> BeginDeacceleratingEnd(TimeSpan deaccelerationDuration, TimeSpan totalDuration)
        {
			if (totalDuration < deaccelerationDuration)
				throw new ArgumentException("totalDuration must be at least equal to deaccelerationDuration", "totalDuration");

			if (totalDuration == deaccelerationDuration)
				return BeginDeacceleratingEnd(deaccelerationDuration);

			var reference = new AnimationReference();

			TimeSpan initialWait = totalDuration - deaccelerationDuration;
			var timeLimit = new TimeLimit(initialWait);
			timeLimit.InnerAnimation = reference;

			var end = new ProgressiveTimeMultiplier(deaccelerationDuration, 1, 0.2);
			end.InnerAnimation = reference;

			var sequence = new SequentialAnimationGroup();
			sequence.Add(timeLimit);
			sequence.Add(end);

			Add(sequence);
            return new DeacceleratingEndBuilder<TThis>(This, reference);
        }


        public DisposeOnEndBuilder<TThis> BeginDisposeOnEnd()
        {
            var animation = new DisposeOnEndAnimation();
            Add(animation);
            return new DisposeOnEndBuilder<TThis>(This, animation);
        }

        public RunConditionBuilder<TThis> BeginRunCondition(Func<bool> condition)
        {
            var animation = new RunCondition(condition);
            Add(animation);
            return new RunConditionBuilder<TThis>(This, animation);
        }
        public PrematureEndConditionBuilder<TThis> BeginPrematureEndCondition(Func<bool> condition, bool resetOnPrematureEnd=false)
        {
            var animation = new PrematureEndCondition(condition, resetOnPrematureEnd);
            Add(animation);
            return new PrematureEndConditionBuilder<TThis>(This, animation);
        }
        public PauseConditionBuilder<TThis> BeginPauseCondition(Func<bool> condition)
        {
            var animation = new PauseCondition(condition);
            Add(animation);
            return new PauseConditionBuilder<TThis>(This, animation);
        }

		public RangesBuilder<TThis, TValue> BeginRanges<TValue>(Action<TValue> update)
		{
			return BeginRanges<TValue>(update, default(TValue));
		}
		public RangesBuilder<TThis, TValue> BeginRanges<TValue>(Action<TValue> update, TValue initialValue)
		{
			var animation = new SequentialAnimationGroup();
			Add(animation);
			return new RangesBuilder<TThis, TValue>(This, animation, initialValue, update);
		}

		public ProgressiveTimeMultipliersBuilder<TThis> BeginProgressiveTimeMultipliers(double initialMutiplier=1)
		{
			var animation = new SequentialAnimationGroup();
			Add(animation);
			return new ProgressiveTimeMultipliersBuilder<TThis>(This, animation, initialMutiplier);
		}

		public ProgressiveTimeMultiplierBuilder<TThis> BeginProgressiveTimeMultiplier(double innerDurationInSeconds, double initialMultiplier, double finalMultiplier)
		{
			TimeSpan innerDuration = TimeSpan.FromSeconds(innerDurationInSeconds);
			return BeginProgressiveTimeMultiplier(innerDuration, initialMultiplier, finalMultiplier);
		}
		public ProgressiveTimeMultiplierBuilder<TThis> BeginProgressiveTimeMultiplier(TimeSpan innerDuration, double initialMultiplier, double finalMultiplier)
		{
			var animation = new ProgressiveTimeMultiplier(innerDuration, initialMultiplier, finalMultiplier);
			Add(animation);
			return new ProgressiveTimeMultiplierBuilder<TThis>(This, animation);
		}

        public TimeLimitBuilder<TThis> BeginTimeLimit(double durationInSeconds)
        {
            TimeSpan duration = TimeSpan.FromSeconds(durationInSeconds);
            return BeginTimeLimit(duration);
        }
        public TimeLimitBuilder<TThis> BeginTimeLimit(TimeSpan duration)
        {
            var animation = new TimeLimit(duration);
            Add(animation);
            return new TimeLimitBuilder<TThis>(This, animation);
        }

        void IAnimationBuilder.Add(IAnimation animation)
        {
            Add(animation);
        }
    }
}
