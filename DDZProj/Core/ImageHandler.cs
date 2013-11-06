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
        
        public static Image GetFarmerPortrait()
        {
            int w, h;
            w = 32;
            h = 32;
            Image img = ResManager.GetImageRes("portrait");
            Rectangle destRect = new Rectangle(0,0,w,h);
            Bitmap rtnBmp = new Bitmap(w,h);
            Graphics g = Graphics.FromImage(rtnBmp);
            g.DrawImage(img, destRect,new Rectangle(0, 0, w, h), System.Drawing.GraphicsUnit.Pixel);
            return (Image)rtnBmp;
        }
    }
}
