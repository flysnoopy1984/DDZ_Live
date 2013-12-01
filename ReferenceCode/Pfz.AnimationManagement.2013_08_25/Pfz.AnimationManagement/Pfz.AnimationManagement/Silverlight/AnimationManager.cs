using System;
using System.Windows.Media;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations.Groups;

namespace Pfz.AnimationManagement
{
	public static class AnimationManager
	{
		private static readonly ParallelAnimationGroup _group = new ParallelAnimationGroup();

		static AnimationManager()
        {
			_group.MustRemoveEndedAnimations = true;
			CompositionTarget.Rendering += new EventHandler(_Rendering);
			_totalTime = Environment.TickCount;
        }

        private static readonly TimeSpan _1second = TimeSpan.FromSeconds(1);
		private static int _totalTime;
		private static void _Rendering(object sender, EventArgs e)
		{
			var newTotalTime = Environment.TickCount;
			var elapsed = TimeSpan.FromMilliseconds(newTotalTime - _totalTime);
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
