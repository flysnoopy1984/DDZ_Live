using Pfz.AnimationManagement;
using Pfz.AnimationManagement.Abstract;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Input;

namespace Cyberminds57
{
	public partial class MainPage : UserControl
	{
        public static MainPage Instance;
		public MainPage()
		{
			InitializeComponent();

            Instance = this;

			KeyDown += new System.Windows.Input.KeyEventHandler(MainPage_KeyDown);

            var characterImage = new BitmapImage();
            characterImage.ImageOpened += characterImage_ImageOpened;
            characterImage.ImageFailed += characterImage_ImageFailed;
            characterImage.CreateOptions = BitmapCreateOptions.None;
            characterImage.SetSource(Application.GetResourceStream(new Uri("Cyberminds57;component/Images/Character.png", UriKind.Relative)).Stream);
		}

		protected override void OnMouseMove(MouseEventArgs e)
		{
			base.OnMouseMove(e);

			pausePlayControl.KeepActive();
		}

		void MainPage_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
		{
			if (e.Key == Key.Space)
			{
				e.Handled = true;
				pausePlayControl.IsPaused = !pausePlayControl.IsPaused;
				pausePlayControl.KeepActive();
			}
		}

        void characterImage_ImageOpened(object sender, RoutedEventArgs e)
        {
            BitmapImage characterImage = (BitmapImage)sender;

            var canvasChildren = canvas.Children;
            var pfzCharacter = new SpriteSheetCharacter(characterImage);
            pfzCharacter.Top = 400;
            pfzCharacter.Left = -pfzCharacter.Width;
            canvasChildren.Add(pfzCharacter);

            var sboCharacter = new SpriteSheetCharacter(characterImage);
            sboCharacter.Top = 440;
            sboCharacter.Left = canvas.Width;
            canvasChildren.Add(sboCharacter);

			var animation =
				AnimationBuilder.
				BeginPauseCondition(() => pausePlayControl.IsPaused).
					BeginSequence().
						PlaySound("Thunder", 1).
						GlobalMessage("Cyberminds 57", Colors.Blue, 60, 2.5).

						BeginParallel().
							BeginSequence().
								Walk(pfzCharacter, LookDirection.Right, 180).
								Add(() => pfzCharacter.LookDirection = LookDirection.Down).
								Say(1.5, "Hi, my name is Paulo Zemek.", HorizontalAlignment.Right, pfzCharacter).
							EndSequence().
							BeginSequence().
								Walk(sboCharacter, LookDirection.Left, 497).
								Add(() => sboCharacter.LookDirection = LookDirection.Down).
							EndSequence().
						EndParallel().

						Say(1.5, "Hi, my name is Sébastien Boudreau.", HorizontalAlignment.Left, sboCharacter).

						Wait(1).
						Say(0.5, "Hummm...", HorizontalAlignment.Right, pfzCharacter).

						Add(() => pfzCharacter.LookDirection = LookDirection.Right).
						Say(3, "...don't you think it is too dark in here?\r\nI can't see my own edges.", HorizontalAlignment.Right, pfzCharacter).
						Add(() => sboCharacter.LookDirection = LookDirection.Left).
						Say(2, "Yeah. I will turn on the lights.", HorizontalAlignment.Left, sboCharacter).
						Walk(sboCharacter, LookDirection.Right, canvas.Width - sboCharacter.Width).

						PlaySound("Light", 1).
						BeginRanges((opacity) => rectangleLight.Opacity = opacity, 0.7).
							To(0, 0.25).
							Add(() => rectangleLight.Fill = new SolidColorBrush(Colors.White)).
							To(0.9, 0.25).
							Wait(0.25).
							To(0, 0.25).
							Add(() => rectangleLight.Fill = new SolidColorBrush(Colors.Black)).
							To(0.7, 0.2).
							To(0, 0.2).
							Add(() => rectangleLight.Fill = new SolidColorBrush(Colors.White)).
							To(0.9, 0.25).
							To(0, 0.25).
						EndRanges().

						Walk(sboCharacter, LookDirection.Left, 567).
						Say(3, "I think we should repair that.\r\nThe last time the entire city went off.", HorizontalAlignment.Left, sboCharacter).
						Say(3, "I don't think so.\r\nPeople need some time off.", HorizontalAlignment.Right, pfzCharacter).
						Say(3, "Humm... I am not really sure\r\nif that's the \"off time\" they need.", HorizontalAlignment.Left, sboCharacter).
						Say(3, "But that's not the point.\r\nLet's tell them?", HorizontalAlignment.Left, sboCharacter).
						Say(3, "Sure. In 3 seconds.", HorizontalAlignment.Right, pfzCharacter).

						Add(() => { pfzCharacter.LookDirection = LookDirection.Down; sboCharacter.LookDirection = LookDirection.Down; }).
						PlaySound("Psycho", 0.6).
						Countdown(3).
						Say(1.5, "We are aliens!", HorizontalAlignment.Center, pfzCharacter, sboCharacter).

						Wait(2).
						PlaySound("Cricket", 0.6).
						GlobalMessage("They wait for some minutes...", Color.FromArgb(255, 0, 255, 0), 40, 2).
						Wait(1).

						Add(() => sboCharacter.LookDirection = LookDirection.Left).
						Say(1.5, "OK. And now what?", HorizontalAlignment.Left, sboCharacter).
						Add(() => pfzCharacter.LookDirection = LookDirection.Right).
						Say(3, "I don't know.\r\nI think I will wait to see\r\nif there's any panic.", HorizontalAlignment.Right, pfzCharacter).
						Say(1.5, "Fine. See you soon.", HorizontalAlignment.Left, sboCharacter).

						BeginParallel().
							Walk(pfzCharacter, LookDirection.Left, -pfzCharacter.Width).
							Walk(sboCharacter, LookDirection.Right, canvas.Width).
						EndParallel().

						Add
						(
							() => 
							{ 
								pfzCharacter.Top = 430; 
								pfzCharacter.Left = 200; 
								pfzCharacter.Opacity = 0; 
								pfzCharacter.LookDirection = LookDirection.Right;
							}
						).
						PlaySound("TeleportShort", 0.8).
						Range(0.0, 1.0, 1, (value) => pfzCharacter.Opacity = value).
						Walk(pfzCharacter, LookDirection.Right, 270).
						Say(4, "Humm... it seems I teleported myself again.\r\nWhy was I walking after all?", HorizontalAlignment.Right, pfzCharacter).
						BeginParallel().
							Countdown(3).
							PlaySound("TeleportLong", 0.8).
							Add(_RandomMoves(pfzCharacter)).
							BeginSequence().
								Wait(3).
								Range(1.0, 0.0, 1, (value) => pfzCharacter.Opacity = value).
							EndSequence().
						EndParallel().

						Wait(1).
						GlobalMessage("To be continued...", Colors.White, 57, 3).

						Add(() => rectangleLight.Fill = new SolidColorBrush(Colors.Black)).
						Range(0.0, 1.0, 1, (opacity) => rectangleLight.Opacity = opacity).
					EndSequence().
				EndPauseCondition();

            AnimationManager.Add(animation);
        }

        private static IEnumerable<IAnimation> _RandomMoves(ICharacterImage character)
        {
            var random = new Random();
            var helper = FrameBasedAnimationHelper.CreateByFps(60);
            for (int i = 0; i < 60*4; i++)
            {
                double value = (i / 60.0) + 1;

                int x = random.Next(2);
                int y = random.Next(2);

                if (x == 0)
                    x = -1;

                if (y == 0)
                    y = -1;

                character.Left += x * value;
                character.Top += y * value;

                yield return helper.WaitNextFrame();
            }
        }

        void characterImage_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {
            MessageBox.Show("An important image failed to load: " + e.ErrorException);
        }
	}
}
