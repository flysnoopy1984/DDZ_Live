using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDZProj.Core
{
    public class SysConfiguration
    {
        private static int _ScreenWidth;
        private static int _ScreenHeight;
        private static int _PokerWidth;
        private static int _PokerHeight;
        private static int _PokerXSep;
        private static int _PokerCount;
        


        public static int PokerCount
        {
            get { return _PokerCount; }
        }

        public static int PokerWidth
        {
            get { return _PokerWidth; }
        }

        public static int PokerHeight
        {
            get { return _PokerHeight; }
        }

        public static int PokerXSep
        {
            get { return _PokerXSep; }
        }
    

        public static int ScreenWidth
        {
            get { return _ScreenWidth; }           
        }

        public static int ScreenHeight
        {
            get { return _ScreenHeight; }
        }

        public static int TopSpec { get; set; }
        public static int LeftSpec { get; set; }

        public static int InnerTopSpec { get; set; }
        public static int InnerLeftSpec { get; set; }    

        public static int CallScoreTime { get; set; }

        public static int AreaBossPokerWidth { get; set; }
        public static int AreaBossPokerHeight { get; set; }

       
        public static void Init_1024()
        {
            //屏幕长宽
            _ScreenWidth = 1024;
            _ScreenHeight = 768;


            //牌的数量
            _PokerCount = 54;

            //牌的长宽
            _PokerWidth = 40;
            _PokerHeight = 71;

            //牌与牌的间隔距离
            _PokerXSep = 25;

            //边缘距离
            //TopSpec = Convert.ToInt32(_ScreenHeight/18*0.5);
            TopSpec = 5;
            LeftSpec = TopSpec;

            //内边距
            InnerTopSpec = Convert.ToInt32(_ScreenWidth / 18 * 0.2);
            InnerLeftSpec = Convert.ToInt32(_ScreenHeight / 32 * 0.2);

            //叫地主倒计时时间
            CallScoreTime = 99;

            //玩家区域的boss牌
            AreaBossPokerWidth = 106;
            AreaBossPokerHeight = 50;

        }

        public static void Init_1440()
        {
            //屏幕长宽
            _ScreenWidth = 1440;
            _ScreenHeight = 768;


            //牌的数量
            _PokerCount = 54;

            //牌的长宽
            _PokerWidth = 55;
            _PokerHeight = 83;

            //牌与牌的间隔距离
            _PokerXSep = 32;

            //边缘距离
            //TopSpec = Convert.ToInt32(_ScreenHeight/18*0.5);
            TopSpec = 7;
            LeftSpec = TopSpec;

            //内边距
            InnerTopSpec = Convert.ToInt32(_ScreenWidth / 18 * 0.2);
            InnerLeftSpec = Convert.ToInt32(_ScreenHeight / 32 * 0.2);


            //叫地主倒计时时间
            CallScoreTime = 99;

            //玩家区域的boss牌
            AreaBossPokerWidth = 150;
            AreaBossPokerHeight = 70;
        }

        public static void Init_1920()
        {
            //屏幕长宽
            _ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            _ScreenHeight = Screen.PrimaryScreen.Bounds.Height;


            //牌的数量
            _PokerCount = 54;

            //牌的长宽
            _PokerWidth = 74;
            _PokerHeight = 100;

            //牌与牌的间隔距离
            _PokerXSep = _PokerWidth / 2 + 6;

            //边缘距离
            //TopSpec = Convert.ToInt32(_ScreenHeight/18*0.5);
            TopSpec = 10;
            LeftSpec = TopSpec;

            //内边距
            InnerTopSpec = Convert.ToInt32(_ScreenWidth / 18 * 0.2);
            InnerLeftSpec = Convert.ToInt32(_ScreenHeight / 32 * 0.2);


            //叫地主倒计时时间
            CallScoreTime = 99;

            //玩家区域的boss牌
            AreaBossPokerWidth = 200;
            AreaBossPokerHeight = 93;
        }

        public static void Init()
        {
            _ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            if (_ScreenWidth == 1920)
            {
                Init_1920();
            }
            else if (_ScreenWidth == 1440)
            {
                Init_1440();
            }
            else if (_ScreenWidth == 1024)
            {
                Init_1024();
            }
            ////屏幕长宽
            //_ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            //_ScreenHeight = Screen.PrimaryScreen.Bounds.Height;
           

            ////牌的数量
            //_PokerCount = 54;

            ////牌的长宽
            //_PokerWidth = (int)((double)74 / (double)1920 * (double)_ScreenWidth);
            //_PokerHeight = (int)((double)100 / (double)1080 * (double)_ScreenHeight);

            ////牌与牌的间隔距离
            //_PokerXSep = (int)(((double)(_PokerWidth / 2) / (double)1920 * (double)_ScreenWidth) +
            //                   (int)((double)6 / (double)1920 * (double)_ScreenWidth));

            ////边缘距离
            ////TopSpec = Convert.ToInt32(_ScreenHeight/18*0.5);
            //TopSpec = (int)((double)10 / (double)1920 * (double)_ScreenWidth);
            //LeftSpec = TopSpec;

            ////内边距
            //InnerTopSpec = Convert.ToInt32(_ScreenWidth / 18 * 0.2);
            //InnerLeftSpec = Convert.ToInt32(_ScreenHeight / 32 * 0.2);


            ////叫地主倒计时时间
            //CallScoreTime = 99;

        }
              
    }
}
