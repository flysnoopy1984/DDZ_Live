using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.WinForms
{
    /// <summary>
    /// This is a an Animation Manager for windows forms.
    /// Unfortunately, it is very processor intensive when there are animations running.
    /// Using normal timers was not giving smoth animations, so this solution keeps generating
    /// messages effectively forcing the application to remain active.
    /// But when there are no animations it will keep the application in wait mode.
    /// </summary>
	public static class AnimationManager
	{
		private static List<IAnimation> _animations = new List<IAnimation>();

		static AnimationManager()
        {
            Initializer.Initialize();
        }

        private static void _OnApplicationIdle(object sender, EventArgs e)
        {
            foreach(Form form in Application.OpenForms)
            {
                if (form.IsDisposed)
                    continue;

                form.BeginInvoke(_update);
                break;
            }
        }

        private static readonly TimeSpan _1millisecond = TimeSpan.FromMilliseconds(1);
        private static readonly TimeSpan _1second = TimeSpan.FromSeconds(1);
        private static readonly Action _update = _Update;
		private static readonly Stopwatch _stopwatch = new Stopwatch();
		private static TimeSpan _totalTime;
        private static void _Update()
		{
			var newTotalTime = _stopwatch.Elapsed;
			var elapsed = newTotalTime - _totalTime;

            if (elapsed < _1millisecond)
                return;

            _totalTime = newTotalTime;

            if (elapsed > _1second)
                elapsed = _1second;

            var animations = _animations;
            _animations = new List<IAnimation>();
            foreach(var animation in animations)
                if (animation.Update(elapsed))
                    _animations.Add(animation);

            if (_animations.Count == 0)
			{
                Application.Idle -= _OnApplicationIdle;
				_stopwatch.Stop();
				_totalTime = TimeSpan.Zero;
			}
		}

        public static void Add(IAnimation animation)
        {
            _animations.Add(animation);

            if (_animations.Count == 1)
			{
				_stopwatch.Reset();
				_stopwatch.Start();
                Application.Idle += _OnApplicationIdle;
			}
        }
	}
}
