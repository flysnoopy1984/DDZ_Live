using System;
using Pfz.AnimationManagement.Abstract;

namespace Pfz.AnimationManagement.Animations
{
	/// <summary>
	/// This is only a reference to another animation.
	/// This is useful if you want to build an entire animation flux where
	/// an specific part appear more than once, but you don't know that
	/// specific part yet.
	/// </summary>
	public sealed class AnimationReference:
		AnimationDecorator
	{
		public override bool Update(TimeSpan elapsed)
		{
			var innerAnimation = InnerAnimation;
			if (innerAnimation == null)
				return false;

			return innerAnimation.Update(elapsed);
		}
	}
}
