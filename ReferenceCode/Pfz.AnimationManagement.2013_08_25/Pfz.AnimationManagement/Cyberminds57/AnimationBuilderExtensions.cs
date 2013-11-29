using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement;
using System.Windows;
using System.Windows.Controls;
using Pfz.AnimationManagement.Animations;
using System.Windows.Media;
using System.IO;

namespace Cyberminds57
{
    public static class AnimationBuilderExtensions
    {
        private static readonly Size _infiniteSize = new Size(double.PositiveInfinity, double.PositiveInfinity);
        public static T Say<T>(this T animationBuilder, double duration, string message, HorizontalAlignment alignment, params ICharacterImage[] characters)
        where
            T: IAnimationBuilder
        {
            var page = MainPage.Instance;
            var baloon = page.baloon;

            Action<double> setOpacity = (value) => page.baloon.Opacity = value;
            var animation = 
                AnimationBuilder.
                    BeginSequence().
                        Add
                        (
                            () => 
                            {
                                baloon.MinWidth = 0;

                                page.baloonText.Text = message;
                                baloon.InvalidateMeasure();
                                baloon.Measure(_infiniteSize);
                                Size baloonSize = baloon.DesiredSize;

                                double minTop = page.ActualHeight;
                                double minPosition = 700-baloonSize.Width;
                                double maxPosition = 0;
                                foreach(var character in characters)
                                {
                                    var element = (FrameworkElement)character;
                                    double left = Canvas.GetLeft(element);
                                    double right = left + element.Width;
                                    double top = Canvas.GetTop(element);

                                    if (right < minPosition)
                                        minPosition = right;

                                    if (left > maxPosition)
                                        maxPosition = left;

                                    if (top < minTop)
                                        minTop = top;
                                }

                                Canvas.SetTop(baloon, minTop-baloonSize.Height);
                                switch(alignment)
                                {
                                    case HorizontalAlignment.Left:
                                        Canvas.SetLeft(baloon, maxPosition-baloonSize.Width);
                                        baloon.CornerRadius = new CornerRadius(30, 30, 0, 30);
                                        break;

                                    case HorizontalAlignment.Center:
                                        baloon.MinWidth = maxPosition-minPosition;
                                        baloon.InvalidateMeasure();
                                        baloon.Measure(_infiniteSize);
                                        baloonSize = baloon.DesiredSize;

                                        Canvas.SetLeft(baloon, minPosition + ((maxPosition-minPosition)/2) - (baloonSize.Width/2));
                                        baloon.CornerRadius = new CornerRadius(30, 30, 0, 0);
                                        break;

                                    case HorizontalAlignment.Right:
                                        Canvas.SetLeft(baloon, minPosition);
                                        baloon.CornerRadius = new CornerRadius(30, 30, 30, 0);
                                        break;

                                    default:
                                        throw new InvalidOperationException("The AddMessage only support Left, Center and Right alignments.");
                                }
                            }
                        ).
                        Range(0, 1, 0.3, setOpacity).
                        Wait(duration).
                        Range(1, 0, 0.3, setOpacity).
                    EndSequence();

            animationBuilder.Add(animation);

            return animationBuilder;
        }

        public static T Walk<T>(this T animationBuilder, ICharacterImage character, LookDirection direction, double finalPosition)
        where
            T: IAnimationBuilder
        {
            bool walking = true;

            Func<double> getInitialPosition;
            Action<double> setPosition;

            switch (direction)
            {
                case LookDirection.Left:
                case LookDirection.Right:
                    getInitialPosition = () => character.Left;
                    setPosition = (value) => character.Left = value;
                    break;

                case LookDirection.Up:
                case LookDirection.Down:
                    getInitialPosition = () => character.Top;
                    setPosition = (value) => character.Top = value;
                    break;

                default:
                    throw new ArgumentException("Invalid direction.", "direction");
            }

            var animation =
                AnimationBuilder.
                    BeginParallel().
                        BeginPrematureEndCondition(() => !walking).
                            BeginLoop().
								BeginParallel().
									Range(0, character.FrameCount - 0.001, 0.4, (value) => character.FrameIndex = (int)value).
									PlaySound("Footstep", 0.5).
								EndParallel().
                            EndLoop().
                        EndPrematureEndCondition().
                        Add(() => character.LookDirection = direction).
                        BeginSequence().
                            RangeBySpeed(getInitialPosition, finalPosition, 60, setPosition).
                            Add(() => { walking = false; character.FrameIndex = 0; }).
                        EndSequence().
                    EndParallel();

            animationBuilder.Add(animation);
            return animationBuilder;
        }

        public static T Countdown<T>(this T animationBuilder, int count)
        where 
            T: IAnimationBuilder
        {
            var animation = new ImperativeAnimation(_Countdown(count));
            animationBuilder.Add(animation);
            return animationBuilder;
        }
        private static IEnumerable<IAnimation> _Countdown(int count)
        {
            MainPage.Instance.globalText.Opacity = 1;
            MainPage.Instance.globalText.Foreground = new SolidColorBrush(Colors.Red);

            Action<int> update = (value) => MainPage.Instance.globalText.FontSize = value;
            while (count > 0)
            {
                MainPage.Instance.globalText.Text = count.ToString();

                yield return AnimationBuilder.Range(180, 10, 1, update);

                count--;
            }

            MainPage.Instance.globalText.Opacity = 0;
        }

        public static T GlobalMessage<T>(this T animationBuilder, string message, Color color, double size, double duration)
        where
            T: IAnimationBuilder
        {
            Action initialize =
                () =>
                {
                    var globalText = MainPage.Instance.globalText;
                    globalText.Text = message;
                    globalText.FontSize = size;
                    globalText.Foreground = new SolidColorBrush(color);
                };

            Action<double> setOpacity = (value) => MainPage.Instance.globalText.Opacity = value;

            var animation =
                AnimationBuilder.
                    BeginSequence().
                        Add(initialize).
                        Range(0, 1, 0.5, setOpacity).
                        Wait(duration).
                        Range(1, 0, 0.5, setOpacity).
                    EndSequence();

            animationBuilder.Add(animation);

            return animationBuilder;
        }

		public static T PlaySound<T>(this T animationBuilder, string soundName, double volume)
		where
			T: IAnimationBuilder
		{
			var animation = new DelegatedAnimation();
			animation.Updating = (ignore) =>
				{
					try
					{
						MediaElement media = new MediaElement();
						media.Volume = volume;
						Stream stream = Application.GetResourceStream(new Uri("Cyberminds57;component/Sounds/" + soundName + ".mp3", UriKind.Relative)).Stream;
						media.SetSource(stream);
					}
					catch
					{
					}

					return false;
				};

			animationBuilder.Add(animation);
			return animationBuilder;
		}
    }
}
