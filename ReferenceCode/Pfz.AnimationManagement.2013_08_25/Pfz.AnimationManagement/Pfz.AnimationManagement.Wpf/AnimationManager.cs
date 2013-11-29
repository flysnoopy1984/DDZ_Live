using System;
using System.Diagnostics;
using System.Windows.Media;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Groups;

namespace Pfz.AnimationManagement.Wpf
{
	public static class AnimationManager
	{
		private static readonly ParallelAnimationGroup _group = new ParallelAnimationGroup();

		static AnimationManager()
        {
            Initializer.Initialize();

			_group.MustRemoveEndedAnimations = true;
			CompositionTarget.Rendering += new EventHandler(_Rendering);
			_stopwatch.Start();
        }

		private static readonly Stopwatch _stopwatch = new Stopwatch();
        private static readonly TimeSpan _1second = TimeSpan.FromSeconds(1);
		private static TimeSpan _totalTime;
		private static void _Rendering(object sender, EventArgs e)
		{
			var newTotalTime = _stopwatch.Elapsed;
			var elapsed = newTotalTime - _totalTime;
			_totalTime = newTotalTime;

            if (elapsed > _1second)
                elapsed = _1second;

			_group.Update(elapsed);
		}

        public static void Add(IAnimation animation)
        {
            _group.Add(animation);
        }
	}
}
