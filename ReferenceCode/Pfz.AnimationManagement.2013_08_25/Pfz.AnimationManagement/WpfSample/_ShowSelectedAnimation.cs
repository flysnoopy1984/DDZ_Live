using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;

namespace WpfSample
{
    internal sealed class _ShowSelectedAnimation:
        IAnimation
    {

        private readonly MainWindow _window;
        public _ShowSelectedAnimation(MainWindow window)
        {
            _window = window;
        }

        public bool IsUseless
        {
            get
            {
                return false;
            }
        }

        public void Reset()
        {
            _window._animation.Reset();
        }

        public bool Update(TimeSpan elapsed)
        {
            if (!_window._animation.Update(elapsed))
                _window._animation.Reset();

            return true;
        }

        public void Dispose()
        {
        }
    }
}
