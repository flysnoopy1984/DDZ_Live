using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Pfz.AnimationManagement;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement.Animations;
using Pfz.AnimationManagement.Wpf;

namespace WpfSample
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
        private IAnimation[] _basicAnimations;
        private IAnimation[] _intermediaryAnimations;
        internal IAnimation _animation;

        private ReadOnlyCollection<BitmapFrame> _waitingCharacter;
        private ReadOnlyCollection<BitmapFrame> _movingForwardCharacter;

		public MainWindow()
		{
			InitializeComponent();

            Pfz.AnimationManagement.Wpf.Initializer.Initialize();

            tabItemBasic.RequestBringIntoView += (a, b) => _SetBasicAnimation();
            tabItemIntermediary.RequestBringIntoView += (a, b) => _SetIntermediaryAnimation();

            _basicAnimations = 
                new IAnimation[]
                {
                    // Range
                    AnimationBuilder.Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)),

                    // Accelerating Start
                    AnimationBuilder.
                        BeginAcceleratingStart(1).
                            Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)).
                        EndAcceleratingStart(),

                    // Deaccelerating End
                    AnimationBuilder.
                        BeginDeacceleratingEnd(1, 3).
                            Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)).
                        EndDeacceleratingEnd(),

					// Multiple time multipliers
					AnimationBuilder.
						BeginProgressiveTimeMultipliers(0.1).
							Add(AnimationBuilder.Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value))).
							MultiplySpeed(1, 1).
							KeepSpeed(1).
							MultiplySpeed(0.1, 1).
						EndProgressiveTimeMultipliers(),

                    // Color Range
                    AnimationBuilder.Range(Colors.Black, Colors.Blue, 1, (value) => circle.Fill = new SolidColorBrush(value)),

                    // Many Color Ranges
                    AnimationBuilder.
                        BeginRanges((value) => circle.Fill = new SolidColorBrush(value), Colors.Black).
                            To(Colors.Blue, 1).
                            To(Colors.Red, 1).
                            To(Colors.Green, 1).
                            To(Colors.Yellow, 1).
                            To(Colors.Magenta, 1).
                            To(Colors.Black, 1).
                        EndRanges(),

                    // Parallel Animation
                    AnimationBuilder.
                        BeginParallel().
                            BeginLoop().
                                BeginRanges((value) => circle.Fill = new SolidColorBrush(value), Colors.Black).
                                    To(Colors.Blue, 1).
                                    To(Colors.Red, 1).
                                    To(Colors.Green, 1).
                                    To(Colors.Yellow, 1).
                                    To(Colors.Magenta, 1).
                                    To(Colors.Black, 1).
                                EndRanges().
                            EndLoop().
                            BeginLoop().
                                Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)).
                            EndLoop().
                        EndParallel(),

                    // Sequential Animation
                    AnimationBuilder.
                        BeginSequence().
                            Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)).
                            Range(Colors.Black, Colors.Green, 1, (value) => circle.Fill = new SolidColorBrush(value)).
                            Range(0, 450, 3, (value) => Canvas.SetTop(circle, value)).
                            Range(Colors.Green, Colors.Red, 1, (value) => circle.Fill = new SolidColorBrush(value)).
                            Range(450, 0, 3, (value) => Canvas.SetLeft(circle, value)).
                            Range(Colors.Red, Colors.Blue, 1, (value) => circle.Fill = new SolidColorBrush(value)).
                            Range(450, 0, 3, (value) => Canvas.SetTop(circle, value)).
                            Range(Colors.Blue, Colors.Black, 1, (value) => circle.Fill = new SolidColorBrush(value)).
                        EndSequence(),

					// Sequential Animation + Multiple Speeds
						AnimationBuilder.
							BeginProgressiveTimeMultipliers().
								KeepSpeed(1).
								MultiplySpeed(2, 3).
								KeepSpeed(1).
								MultiplySpeed(0.5, 2).
								KeepSpeedUntilEnd().
								BeginSequence().
									Range(0, 450, 3, (value) => Canvas.SetLeft(circle, value)).
									Range(Colors.Black, Colors.Green, 1, (value) => circle.Fill = new SolidColorBrush(value)).
									Range(0, 450, 3, (value) => Canvas.SetTop(circle, value)).
									Range(Colors.Green, Colors.Red, 1, (value) => circle.Fill = new SolidColorBrush(value)).
									Range(450, 0, 3, (value) => Canvas.SetLeft(circle, value)).
									Range(Colors.Red, Colors.Blue, 1, (value) => circle.Fill = new SolidColorBrush(value)).
									Range(450, 0, 3, (value) => Canvas.SetTop(circle, value)).
									Range(Colors.Blue, Colors.Black, 1, (value) => circle.Fill = new SolidColorBrush(value)).
								EndSequence().
							EndProgressiveTimeMultipliers(),


                    // Imperative Animation
                    new ImperativeAnimation(_ImperativeAnimation()),

                    // Frame-by-Frame Animation
                    new ImperativeAnimation(_FrameBasedAnimation())
                };

            AnimationManager.Add(new _ShowSelectedAnimation(this));
            listboxBasicAnimation.SelectionChanged += listboxBasicAnimation_SelectionChanged;
            _SetBasicAnimation();

            bool isGoing = true;
            _waitingCharacter = _LoadCharacter("Images\\Waiting.gif");
            _movingForwardCharacter = _LoadCharacter("Images\\MoveForward.gif");
            _intermediaryAnimations = 
                new IAnimation[]
                {
                    // Animate Character
                    AnimationBuilder.RangeBySpeed(0, _waitingCharacter.Count-1, 10, (index) => imageCharacter.Source = _waitingCharacter[index]),

                    // Move Character
                    AnimationBuilder.
                        BeginParallel().
                            BeginLoop().
                                RangeBySpeed(0, _movingForwardCharacter.Count-1, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                            EndLoop().
                            BeginLoop().
                                RangeBySpeed(0, 400, 70, (value) => imageCharacter.Left = value).
                            EndLoop().
                        EndParallel(),

                    // Move (Frame-by-Frame)
                    new ImperativeAnimation(_MoveFrameByFrame(_movingForwardCharacter)),

                    // Go and Return
                    AnimationBuilder.
                        BeginSequence().
                            Add(() => isGoing = true).
                            BeginParallel().
                                BeginPrematureEndCondition(() => !isGoing).
                                    BeginLoop(). // we need to loop the animation or else it will do a single "full-step" and then will 
                                                // only move forward without walking. But we need to end the animation sometime... we 
                                                // can cound the steps (bad, as the animation does not end at an exact step) or we can 
                                                // put a premature end over the entire loop (good).
                                        RangeBySpeed(0, _movingForwardCharacter.Count-1, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                                    EndLoop().
                                EndPrematureEndCondition().
                                BeginSequence().
                                    RangeBySpeed(0, 400, 70, (value) => imageCharacter.Left = value).
                                    Add(() => isGoing = false).
                                EndSequence().
                            EndParallel().
                            BeginParallel().
                                BeginPrematureEndCondition(() => isGoing).
                                    BeginLoop().
                                        RangeBySpeed(_movingForwardCharacter.Count-1, 0, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                                    EndLoop().
                                EndPrematureEndCondition().
                                BeginSequence().
                                    RangeBySpeed(400, 0, 70, (value) => imageCharacter.Left = value).
                                    Add(() => isGoing = true).
                                EndSequence().
                            EndParallel().
                        EndSequence(),

                    // Go, Turn and Return
                    AnimationBuilder.
                        BeginSequence().
                            Add(() => isGoing = true).
                            BeginParallel().
                                BeginPrematureEndCondition(() => !isGoing).
                                    BeginLoop(). // we need to loop the animation or else it will do a single "full-step" and then will 
                                                // only move forward without walking. But we need to end the animation sometime... we 
                                                // can cound the steps (bad, as the animation does not end at an exact step) or we can 
                                                // put a premature end over the entire loop (good).
                                        RangeBySpeed(0, _movingForwardCharacter.Count-1, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                                    EndLoop().
                                EndPrematureEndCondition().
                                BeginSequence().
                                    RangeBySpeed(0, 400, 70, (value) => imageCharacter.Left = value).
                                    Add(() => isGoing = false).
                                EndSequence().
                            EndParallel().
                            Range(1.0, -1.0, 1, (value) => imageCharacter.ScaleX = value).
                            BeginParallel().
                                BeginPrematureEndCondition(() => isGoing).
                                    BeginLoop().
                                        // Different from the last full-animation, we continue "going forward".
                                        RangeBySpeed(0, _movingForwardCharacter.Count-1, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                                    EndLoop().
                                EndPrematureEndCondition().
                                BeginSequence().
                                    RangeBySpeed(400, 0, 70, (value) => imageCharacter.Left = value).
                                    Add(() => isGoing = true).
                                EndSequence().
                            EndParallel().
                            Range(-1.0, 1.0, 1, (value) => imageCharacter.ScaleX = value).
                        EndSequence(),

                    // Go, Turn and Return (* walking while turning).
                    // This animation is similar to the previous 2, but in this case the character is always walking, even
                    // when the animation is "turning" to the opposite side.
                    AnimationBuilder.
                        BeginParallel().
                            BeginLoop().
                                RangeBySpeed(0, _movingForwardCharacter.Count-1, 10, (index) => imageCharacter.Source = _movingForwardCharacter[index]).
                            EndLoop().
                            BeginLoop().
                                BeginSequence().
                                    RangeBySpeed(0, 400, 70, (value) => imageCharacter.Left = value).
                                    Range(1.0, -1.0, 1, (value) => imageCharacter.ScaleX = value).
                                    RangeBySpeed(400, 0, 70, (value) => imageCharacter.Left = value).
                                    Range(-1.0, 1.0, 1, (value) => imageCharacter.ScaleX = value).
                                EndSequence().
                            EndLoop().
                        EndParallel()
                };

            listboxIntermediaryAnimation.SelectionChanged += listboxIntermediaryAnimation_SelectionChanged;
		}

        private IEnumerable<IAnimation> _ImperativeAnimation()
        {
            Random random = new Random();
            while(true)
            {
                Point origin = new Point(Canvas.GetLeft(circle), Canvas.GetTop(circle));
                Point destination = new Point(random.Next(450), random.Next(450));

                yield return AnimationBuilder.RangeBySpeed(origin, destination, 150, _SetLeftAndTop);
            }
        }
        private void _SetLeftAndTop(Point point)
        {
            Canvas.SetLeft(circle, point.X);
            Canvas.SetTop(circle, point.Y);
        }

        private IEnumerable<IAnimation> _FrameBasedAnimation()
        {
            var helper = FrameBasedAnimationHelper.CreateByFps(100);
            while(true)
            {
                double yPosition = 0;
                double xPosition = 0;
                double ySpeed = 0.5;
                while(yPosition < 500)
                {
                    xPosition++;
                    yPosition += ySpeed;
                    ySpeed += 0.1;
                    Canvas.SetLeft(circle, xPosition);
                    Canvas.SetTop(circle, yPosition);
                    yield return helper.WaitNextFrame();
                }
            }
        }

        private void listboxBasicAnimation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _SetBasicAnimation();
        }

        private void _SetBasicAnimation()
        {
            Canvas.SetLeft(circle, 0);
            Canvas.SetTop(circle, 0);
            circle.Fill = Brushes.Black;

            if (_animation != null)
                _animation.Reset();

            _animation = _basicAnimations[listboxBasicAnimation.SelectedIndex];
        }

        private void listboxIntermediaryAnimation_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _SetIntermediaryAnimation();
        }
        private void _SetIntermediaryAnimation()
        {
            imageCharacter.Left = 0;
            imageCharacter.Top = 0;

            imageCharacter.ScaleX = 1;

            if (_animation != null)
                _animation.Reset();

            _animation = _intermediaryAnimations[listboxIntermediaryAnimation.SelectedIndex];
        }

        private ReadOnlyCollection<BitmapFrame> _LoadCharacter(string path)
        {
            using(var stream = File.OpenRead(path))
            {
                var decoder = GifBitmapDecoder.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                var frames = decoder.Frames;
                return frames;
            }
        }

        private IEnumerable<IAnimation> _MoveFrameByFrame(ReadOnlyCollection<BitmapFrame> character)
        {
            var helper = FrameBasedAnimationHelper.CreateByFps(80);

            int frameCount = character.Count*7;
            int frameIndex = 0;
            imageCharacter.Top = canvasIntermediary.ActualHeight - character[0].Height;
            while(true)
            {
                for(int left=0; left<400; left++)
                {
                    frameIndex++;
                    if (frameIndex >= frameCount)
                        frameIndex = 0;

                    imageCharacter.Source = character[frameIndex/7];
                    imageCharacter.Left = left;
                    yield return helper.WaitNextFrame();
                }
            }
        }

        private void tabItemAdvanced_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
        {
            if (_animation != null)
                _animation.Reset();

            _animation = new ImperativeAnimation(_AdvancedAnimation());
        }

        private int _direction = 0;
		private bool _isUpPressed;
        private IEnumerable<IAnimation> _AdvancedAnimation()
        {
            var helper = FrameBasedAnimationHelper.CreateByFps(80);

            canvasAdvanced.Focus();
            var canvasChildren = canvasAdvanced.Children;

            double playerLeft = 0;
            double playerScale = 1;
            var playerCharacter = new ImageWithShadow();
            playerCharacter.Left = playerLeft;
            playerCharacter.Top = 300;

            var otherCharacter = new ImageWithShadow();
            otherCharacter.ScaleX = -1;
            otherCharacter.Left = 350;
            otherCharacter.Top = 300;

            var presentationAnimation = 
                AnimationBuilder.
                    BeginSequence().
                        Add(_ShowText("This is an interactive animation.\r\nPress the Left, Up and Right arrows to Move.")).
                        Add(_ShowText("Yet this is not a game, the other character will only flee from you.")).
                    EndSequence();

            bool ending = false;
			bool jumping = false;
            try
            {
                // This animation will run in parallel to the actual imperative animaion.
                // It is "subordinated" and so, if this animation is ended prematurely, such
                // parallel animation will also end prematurely.
                // This is different than adding the animation to the WpfAnimationManager directly.
                // Also, there is an additional difference, as time modifiers that are affecting
                // this animation will also affect its subordinated parallel (even if this is not
                // happening in this sample application).
                ImperativeAnimation.AddSubordinatedParallel(presentationAnimation);

                canvasChildren.Add(playerCharacter);
                canvasChildren.Add(otherCharacter);
                canvasAdvanced.PreviewKeyDown += canvasAdvanced_PreviewKeyDown;
                canvasAdvanced.PreviewKeyUp += canvasAdvanced_PreviewKeyUp;

                int actualMovingFrame = 0;
                int totalMovingFrames = _movingForwardCharacter.Count * 8;
                int totalWaitingFrames = _waitingCharacter.Count * 8;
                int actualWaitingFrame = totalWaitingFrames;
                bool running = true;
                while(running)
                {
                    actualWaitingFrame++;
                    if (actualWaitingFrame >= totalWaitingFrames)
                        actualWaitingFrame = 0;

                    int actualRealFrame = actualWaitingFrame / 8;
                    otherCharacter.Source = _waitingCharacter[actualRealFrame];

					if (_isUpPressed && !jumping)
					{
						jumping = true;

						Action<double> setTop = (value) => playerCharacter.JumpingHeight = value;
						var animation = 
							AnimationBuilder.BeginSequence().
								Range(0, 100, 0.3, setTop).
								Range(100, 0, 0.3, setTop).
								Add(() => jumping = false).
							EndSequence();

						ImperativeAnimation.AddSubordinatedParallel(animation);
					}

                    if (_direction == 0)
                        playerCharacter.Source = _waitingCharacter[actualRealFrame];
                    else
                    {
                        bool canMove = false;

                        if (_direction < 0)
                        {
                            if (playerScale > -1)
                            {
                                playerScale -= 0.1;

                                if (playerScale < -1)
                                    playerScale = -1;
                            }
                            else
                                canMove = true;

                            playerCharacter.ScaleX = playerScale;
                        }
                        else
                        {
                            if (playerScale < 1)
                            {
                                playerScale += 0.1;

                                if (playerScale > 1)
                                    playerScale = 1;
                            }
                            else
                                canMove = true;

                            playerCharacter.ScaleX = playerScale;
                        }

                        if (canMove)
                        {
                            actualMovingFrame++;
                            if (actualMovingFrame >= totalMovingFrames)
                                actualMovingFrame = 0;

                            playerCharacter.Source = _movingForwardCharacter[actualMovingFrame/8];

                            playerLeft += _direction * 1;
                            if (playerLeft < 0)
                                playerLeft = 0; // The typical invisible barrier in which the character 
                                                // continues walking without moving.

                            playerCharacter.Left = playerLeft;

                            if (playerLeft > 250 && !ending)
                            {
								// this is to avoid playing the ending animation more
								// than once.
								ending = true;

                                // and this is just in case the presentation is still running,
                                // as we don't want messages to overlap.
                                presentationAnimation.Dispose();

                                Action<double> setLeft = (value) => otherCharacter.Left = value;
                                Action<double> setTop = (value) => otherCharacter.Top = value;

                                var finalAnimation =                                         
                                    AnimationBuilder.
                                        BeginSequence().
                                            BeginParallel().
                                                Range(350, 370, 0.10, setLeft).
                                                Range(300, 280, 0.10, setTop).
                                            EndParallel().
                                            BeginParallel().
                                                Range(370, 390, 0.10, setLeft).
                                                Range(280, 300, 0.10, setTop).
                                            EndParallel().
                                            Range(-1.0, 1.0, 0.5, (value) => otherCharacter.ScaleX = value).
                                            Range(390, 510, 0.5, setLeft).
                                            Add(_ShowText("The other character fled from you...")).
                                            Add(_ShowText("... he is a COWARD!!!")).
                                            Add(() => running=false).
                                        EndSequence();

                                ImperativeAnimation.AddSubordinatedParallel(finalAnimation);
                            }
                        }
                    }

                    yield return helper.WaitNextFrame();
                }
            }
            finally
            {
                canvasAdvanced.PreviewKeyDown -= canvasAdvanced_PreviewKeyDown;
                canvasChildren.Remove(playerCharacter);
                canvasChildren.Remove(otherCharacter);
            }
        }

        void canvasAdvanced_PreviewKeyDown(object sender, KeyEventArgs e)
        {
			switch(e.Key)
			{
				case Key.Left:
					_direction = -1;
					e.Handled = true;
					break;

				case Key.Right:
					_direction = 1;
					e.Handled = true;
					break;

				case Key.Up:
					_isUpPressed = true;
					e.Handled = true;
					break;
			}
        }

        void canvasAdvanced_PreviewKeyUp(object sender, KeyEventArgs e)
        {
            switch(e.Key)
            {
                case Key.Left:
                case Key.Right:
                    e.Handled = true;
                    _direction = 0;
                    break;

				case Key.Up:
					e.Handled = true;
					_isUpPressed = false;
					break;
            }
        }


        private IEnumerable<IAnimation> _ShowText(string message)
        {
            var textBlock = new TextBlock();
            try
            {
                textBlock.Text = message;
                canvasAdvanced.Children.Add(textBlock);

                Action<double> setOpacity = (value) => textBlock.Opacity = value;
                yield return
                    AnimationBuilder.
                        BeginSequence().
                            Range(0.0, 1.0, 1, setOpacity).
                            Wait(2).
                            Range(1.0, 0.0, 1, setOpacity).
                        EndSequence();

            }
            finally
            {
                canvasAdvanced.Children.Remove(textBlock);
            }
        }
    }
}
