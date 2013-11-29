using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using Pfz.AnimationManagement.Abstract;
using Pfz.AnimationManagement;

namespace Cyberminds57
{
	public partial class PausePlayControl:
		UserControl
	{
		private enum ImageType
		{
			Disabled,
			Hot,
			Pressed
		}

		private static readonly BitmapImage[] _pauseImages = new BitmapImage[3];
		private static readonly BitmapImage[] _playImages = new BitmapImage[3];

		static PausePlayControl()
		{
			_LoadImages(_pauseImages, "Pause");
			_LoadImages(_playImages, "Play");
		}

		private static void _LoadImages(BitmapImage[] images, string type)
		{
			int index = -1;
			foreach(string name in Enum.GetNames(typeof(ImageType)))
			{
				index++;

				string uriPath = "Cyberminds57;component/Images/" + type + "-" + name + "-icon.png";
				Uri uri = new Uri(uriPath, UriKind.Relative);
				var stream = Application.GetResourceStream(uri).Stream;

				var image = new BitmapImage();
				image.CreateOptions = BitmapCreateOptions.None;
				image.SetSource(stream);

				images[index] = image;
			}
		}

		public PausePlayControl()
		{
			InitializeComponent();

			image.Source = _pauseImages[0];
			image.MouseEnter += new MouseEventHandler(image_MouseEnter);
			image.MouseLeave += new MouseEventHandler(image_MouseLeave);
			image.MouseLeftButtonDown += new MouseButtonEventHandler(image_MouseLeftButtonDown);
			image.MouseLeftButtonUp += new MouseButtonEventHandler(image_MouseLeftButtonUp);

			_setOpacityDelegate = (value) => Opacity = value;
			_CreateDisappearingAnimation();
		}

		private readonly Action<double> _setOpacityDelegate;
		private IAnimation _disappearAnimation;
		private void _CreateDisappearingAnimation()
		{
			if (_disappearAnimation != null)
				_disappearAnimation.Dispose();

			_disappearAnimation =
				AnimationBuilder.BeginSequence().
					Wait(1.5).
					RangeBySpeed(1, 0, 2, _setOpacityDelegate).
				EndSequence();

			AnimationManager.Add(_disappearAnimation);
		}

		private bool _isPaused;
		public bool IsPaused
		{
			get
			{
				return _isPaused;
			}
			set
			{
				_isPaused = value;
				_Refresh();
			}
		}


		void image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			_isMouseDown = true;
			image.CaptureMouse();
			KeepActive();
			_Refresh();
		}
		void image_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			_isMouseDown = false;
			image.ReleaseMouseCapture();

			if (_isMouseOver)
				IsPaused = !IsPaused;
			else
				_Refresh();

			KeepActive();
		}

		void image_MouseEnter(object sender, MouseEventArgs e)
		{
			_isMouseOver = true;
			_Refresh();
		}
		void image_MouseLeave(object sender, MouseEventArgs e)
		{
			_isMouseOver = false;
			_Refresh();
		}

		private bool _isMouseOver;
		private bool _isMouseDown;
		private void _Refresh()
		{
			var images = _pauseImages;

			if (_isPaused)
				images = _playImages;

			int imageIndex = 0;
			if (_isMouseOver)
				imageIndex = 1;

			if (_isMouseDown)
				imageIndex++;

			image.Source = images[imageIndex];
		}

		public void KeepActive()
		{
			if (_isMouseDown || _isMouseOver)
				_disappearAnimation.Dispose();
			else
				_CreateDisappearingAnimation();

			if (Opacity < 1)
			{
				var animation = AnimationBuilder.RangeBySpeed(Opacity, 1, 3, _setOpacityDelegate);
				AnimationManager.Add(animation);
			}
		}
	}
}
