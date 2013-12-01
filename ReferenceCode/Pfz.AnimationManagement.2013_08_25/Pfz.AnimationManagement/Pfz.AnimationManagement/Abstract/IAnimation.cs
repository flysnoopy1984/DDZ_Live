using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
    public interface IAnimation:
        IDisposable
    {
        /// <summary>
        /// This property indicates if the animation is "useless", be it because
        /// it was disposed or because it was never fully configured (for example,
        /// an AnimationDecorator without an InnerAnimation).
        /// Such animations can't be resetted and should be removed from containers.
        /// </summary>
        bool IsUseless { get; }

        void Reset();
        bool Update(TimeSpan elapsed);
    }
}
