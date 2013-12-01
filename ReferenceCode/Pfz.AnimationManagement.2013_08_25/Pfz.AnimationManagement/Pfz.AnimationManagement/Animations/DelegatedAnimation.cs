using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
    public sealed class DelegatedAnimation:
        IAfterEndAwareAnimation
    {
        public bool IsUseless
        {
            get
            {
                return Resetting == null && Updating == null && Disposing == null;
            }
        }

        public Action Resetting { get; set; }
        public Func<TimeSpan, bool> Updating { get; set; }
        public Action Disposing { get; set; }
		public TimeSpan ElapsedTimeAfterEnd { get; private set; }

        public void Reset()
        {
			ElapsedTimeAfterEnd = TimeSpan.Zero;
            var resetAction = Resetting;
            if (resetAction != null)
                resetAction();
        }

        public bool Update(TimeSpan elapsed)
        {
            var updateFunction = Updating;
            if (updateFunction == null)
			{
				ElapsedTimeAfterEnd += elapsed;
                return false;
			}

			bool result = updateFunction(elapsed);

			if (!result)
				ElapsedTimeAfterEnd += elapsed;

            return result;
        }

        public void Dispose()
        {
            Updating = null;
            Resetting = null;

            var disposeAction = Disposing;
            if (disposeAction != null)
            {
                Disposing = null;
                disposeAction();
            }
        }
    }
}
