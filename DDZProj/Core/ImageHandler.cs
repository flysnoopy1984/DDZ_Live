using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using DDZCommon;

namespace DDZProj.Core
{
    public class ImageHandler
    {
        private static Image _FormerPortrait;
        public static Image GetFarmerPortrait()
        {
            if (_FormerPortrait == null)
            {
                int w, h;
                w = 32;
                h = 40;
                Image img = ResManager.GetImageRes("portrait");
                Rectangle destRect = new Rectangle(0, 0, w, h);
                Bitmap rtnBmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(rtnBmp);
                g.DrawImage(img, destRect, new Rectangle(0, 0, w, h), System.Drawing.GraphicsUnit.Pixel);
                _FormerPortrait = (Image)rtnBmp;
            }
            return _FormerPortrait;
        }

        private static Image _BossPortrait;
        public static Image GetBossPortrait()
        {
            if (_BossPortrait == null)
            {
                int w, h;
                w = 31;
                h = 32;
                Image img = ResManager.GetImageRes("portrait");
                Rectangle destRect = new Rectangle(0, 0, w, h);
                Bitmap rtnBmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(rtnBmp);
                g.DrawImage(img, destRect, new Rectangle(64, 0, w, h), System.Drawing.GraphicsUnit.Pixel);
                _BossPortrait = (Image)rtnBmp;
            }
            return _BossPortrait;
        }

    }
}
