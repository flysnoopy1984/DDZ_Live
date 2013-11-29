using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
    public interface IAfterEndAwareAnimation:
        IAnimation
    {
        TimeSpan ElapsedTimeAfterEnd { get; }
    }
}
