﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using DDZProj.Core;

namespace DDZProj.Effect
{
    public partial class EndCtrl : UserControl
    {
        public EndCtrl()
        {
            InitializeComponent();

          
        }

        private Color _panelColor;

        public Color PanelColor
        {
            get { return _panelColor; }
            set { _panelColor = value; }
        }

        private Color _borderColor;

        public Color BorderColor
        {
            get { return _borderColor; }
            set { _borderColor = value; }
        }

        private int shadowSize = 5;
        private int shadowMargin = 2;

        static Image shadowDownRight =DDZCommon.ResManager.GetImageRes("tshadowdownright");
        static Image shadowDownLeft = DDZCommon.ResManager.GetImageRes("tshadowdownleft");
        static Image shadowDown = DDZCommon.ResManager.GetImageRes("tshadowdown");
        static Image shadowRight = DDZCommon.ResManager.GetImageRes("tshadowright");
        static Image shadowTopRight = DDZCommon.ResManager.GetImageRes("tshadowtopright");

        private void PrintShadow(Graphics g)
        {
            /*
            // Create tiled brushes for the shadow on the right and at the bottom.
            TextureBrush shadowRightBrush = new TextureBrush(shadowRight, WrapMode.Tile);
            TextureBrush shadowDownBrush = new TextureBrush(shadowDown, WrapMode.Tile);

            // Translate (move) the brushes so the top or left of the image matches the top or left of the
            // area where it's drawed. If you don't understand why this is necessary, comment it out. 
            // Hint: The tiling would start at 0,0 of the control, so the shadows will be offset a little.
            shadowDownBrush.TranslateTransform(0, Height - shadowSize);
            shadowRightBrush.TranslateTransform(Width - shadowSize, 0);

            // Define the rectangles that will be filled with the brush.
            // (where the shadow is drawn)
            Rectangle shadowDownRectangle = new Rectangle(
                shadowSize + shadowMargin,                      // X
                Height - shadowSize,                            // Y
                Width - (shadowSize * 2 + shadowMargin),        // width (stretches)
                shadowSize                                      // height
                );

            Rectangle shadowRightRectangle = new Rectangle(
                Width - shadowSize,                             // X
                shadowSize + shadowMargin,                      // Y
                shadowSize,                                     // width
                Height - (shadowSize * 2 + shadowMargin)        // height (stretches)
                );

            // And draw the shadow on the right and at the bottom.
            g.FillRectangle(shadowDownBrush, shadowDownRectangle);
            g.FillRectangle(shadowRightBrush, shadowRightRectangle);

            // Now for the corners, draw the 3 5x5 pixel images.
            g.DrawImage(shadowTopRight, new Rectangle(Width - shadowSize, shadowMargin, shadowSize, shadowSize));
            g.DrawImage(shadowDownRight, new Rectangle(Width - shadowSize, Height - shadowSize, shadowSize, shadowSize));
            g.DrawImage(shadowDownLeft, new Rectangle(shadowMargin, Height - shadowSize, shadowSize, shadowSize));

            // Fill the area inside with the color in the PanelColor property.
            // 1 pixel is added to everything to make the rectangle smaller. 
            // This is because the 1 pixel border is actually drawn outside the rectangle.
            Rectangle fullRectangle = new Rectangle(
               1,                                              // X
               1,                                              // Y
               Width - (shadowSize + 2),                       // Width
               Height - (shadowSize + 2)                       // Height
               );

            if (PanelColor != null)
            {
                SolidBrush bgBrush = new SolidBrush(_panelColor);
                g.FillRectangle(bgBrush, fullRectangle);
            }

            // Draw a nice 1 pixel border it a BorderColor is specified
            if (_borderColor != null)
            {
                Pen borderPen = new Pen(BorderColor);
                g.DrawRectangle(borderPen, fullRectangle);
            }

            // Memory efficiency
            shadowDownBrush.Dispose();
            shadowRightBrush.Dispose();

            shadowDownBrush = null;
            shadowRightBrush = null;
             */
        }
   

      
    }
}