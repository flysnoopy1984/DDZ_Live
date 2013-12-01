using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Cyberminds57
{
    public sealed class SpriteSheetCharacter:
        ContentControl,
        ICharacterImage
    {
        private readonly Canvas _canvas = new Canvas();
        private readonly Image _image = new Image();
        public SpriteSheetCharacter(BitmapImage source)
        {
            if (source == null)
                throw new ArgumentNullException("source");

            if (source.PixelWidth <= 0)
                throw new ArgumentException("source should be already loaded to create a SpriteSheetCharacter.", "source");

            FrameWidth = source.PixelWidth / 4;
            FrameHeight = source.PixelHeight / 4;

            Width = FrameWidth;
            Height = FrameHeight;

            _image.Source = source;

            _canvas.Clip = new RectangleGeometry { Rect = new Rect(0, 0, FrameWidth, FrameHeight) };
            _canvas.Children.Add(_image);
            Content = _canvas;
        }

        public int FrameWidth { get; private set; }
        public int FrameHeight { get; private set; }

        private LookDirection _lookDirection;
        public LookDirection LookDirection
        {
            get
            {
                return _lookDirection;
            }
            set
            {
                if (value == _lookDirection)
                    return;

                _lookDirection = value;
                Canvas.SetTop(_image, FrameHeight * -(int)value);
            }
        }

        public int FrameCount
        {
            get
            {
                return 4;
            }
        }

        private int _frameIndex;
        public int FrameIndex
        {
            get
            {
                return _frameIndex;
            }
            set
            {
                if (value == _frameIndex)
                    return;

                _frameIndex = value;
                Canvas.SetLeft(_image, FrameWidth * -value);
            }
        }

        public double Left
        {
            get
            {
                return Canvas.GetLeft(this);
            }
            set
            {
                Canvas.SetLeft(this, value);
            }
        }

        public double Top
        {
            get
            {
                return Canvas.GetTop(this);
            }
            set
            {
                Canvas.SetTop(this, value);
            }
        }
    }
}
