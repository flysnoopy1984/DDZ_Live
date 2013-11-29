using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfSample
{
    public sealed class ImageWithShadow:
        Canvas
    {
        private readonly Image _image = new Image();
        private readonly Rectangle _shadow = new Rectangle();
        private readonly ImageBrush _shadowMask = new ImageBrush();
        private readonly ScaleTransform _shadowScaleTransform = new ScaleTransform();
        private readonly SkewTransform _skewTransform = new SkewTransform();
        private readonly ScaleTransform _scaleTransform = new ScaleTransform();

        public ImageWithShadow()
        {
            _shadow.Fill = Brushes.Black;
            _shadow.Opacity = 0.57;
            _image.RenderTransform = _scaleTransform;

            _skewTransform.AngleX = -50;
            _shadowScaleTransform.ScaleY = 0.5;

            var transformGroup = new TransformGroup();
            var transformChildren = transformGroup.Children;
            transformChildren.Add(_scaleTransform);
            transformChildren.Add(_skewTransform);
            transformChildren.Add(_shadowScaleTransform);
            _shadow.RenderTransform = transformGroup;
            _shadow.OpacityMask = _shadowMask;

            var children = Children;
            children.Add(_shadow);
            children.Add(_image);
        }

        public ImageSource Source
        {
            get
            {
                return _image.Source;
            }
            set
            {
                _image.Source = value;
                _shadowMask.ImageSource = value;

                if (value != null)
                {
                    _shadowScaleTransform.CenterY = value.Height;
                    _skewTransform.CenterY = value.Height;

                    _shadow.Width = value.Width;
                    _shadow.Height = value.Height;

                    _scaleTransform.CenterX = value.Width / 2;
                }
            }
        }

        private double _left;
        public double Left
        {
            get
            {
                return _left;
            }
            set
            {
                _left = value;
                _CalculatePositions();
            }
        }

        private double _top;
        public double Top
        {
            get
            {
                return _top;
            }
            set
            {
                _top = value;
                _CalculatePositions();
            }
        }

        private double _jumpingHeight;
        public double JumpingHeight
        {
            get
            {
                return _jumpingHeight;
            }
            set
            {
                _jumpingHeight = value;
                _CalculatePositions();
            }
        }

        public double ScaleX
        {
            get
            {
                return _scaleTransform.ScaleX;
            }
            set
            {
                _scaleTransform.ScaleX = value;
            }
        }

        private void _CalculatePositions()
        {
            Canvas.SetLeft(this, _left);
            Canvas.SetTop(this, _top-_jumpingHeight);
            Canvas.SetLeft(_shadow, _jumpingHeight);
            Canvas.SetTop(_shadow, _jumpingHeight/2);
        }
    }
}
