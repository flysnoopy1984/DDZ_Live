using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pfz.AnimationManagement.Abstract
{
	public interface IAnimationGroup:
		IAnimation
	{
		bool MustRemoveEndedAnimations { get; set; }

		void Add(IAnimation animation);
        void Add(IEnumerable<IAnimation> animation);
	}
}
