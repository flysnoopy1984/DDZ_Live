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

        public static Image ImageTransfer(Image sourceImg,int tagW,int tagH,int srcW,int srcH)
        {
           
            Rectangle destRect = new Rectangle(0, 0, tagW, tagH);
            Bitmap tagBitmap = new Bitmap(tagW, tagW);
            Graphics g = Graphics.FromImage(tagBitmap);
            g.DrawImage(sourceImg, destRect, new Rectangle(0, 0, srcW, srcH), GraphicsUnit.Pixel);
            return (Image)tagBitmap;
        }

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
                g.DrawImage(img, destRect, new Rectangle(0, 0, w, h), GraphicsUnit.Pixel);
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

        private static Dictionary<int, Image> _CallBossNumList;
        public static Image GetCallBossNum_OnPortrait(int num)
        {
            string resImageNum = "rc_num"+num;
            if (_CallBossNumList == null)
                _CallBossNumList = new Dictionary<int, Image>();
            try
            {
                return _CallBossNumList[num];
            }
            catch
            {
                _CallBossNumList.Add(num, DDZCommon.ResManager.GetImageRes(resImageNum));

                return _CallBossNumList[num];
            }
        }

        private static Image _RemainPokerBKImage;
        public static Image GetRemainPokerBKImage()
        {
            if (_RemainPokerBKImage == null)
            {
                int w, h;
                w = 80;
                h = 30;
                Image img = ResManager.GetImageRes("WB");
                Rectangle destRect = new Rectangle(0, 0, w, h);
                Bitmap rtnBmp = new Bitmap(w, h);
                Graphics g = Graphics.FromImage(rtnBmp);
                g.DrawImage(img, destRect, new Rectangle(0, 0, w, h), System.Drawing.GraphicsUnit.Pixel);
                _RemainPokerBKImage = (Image)rtnBmp;
            }
            return _RemainPokerBKImage;
        }

        private static Image _RemainPokerNumBK;
        public static Image GetRemainPokerNumBK()
        {
            if (_RemainPokerNumBK == null)
            {

                _RemainPokerNumBK = ResManager.GetImageRes("radio_select");
               
            }
            return _RemainPokerNumBK;
        }
        
    }
}
