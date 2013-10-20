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


        public static void Init()
        {
            //屏幕长宽
            _ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            _ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            //牌的数量
            _PokerCount = 54;

            //牌的长宽
            _PokerWidth = 60;
            _PokerHeight = 100;

            //牌与牌的间隔距离
            _PokerXSep = _PokerWidth / 2;

            //边缘距离
            TopSpec = Convert.ToInt32(_ScreenHeight/18*0.5);
            LeftSpec = TopSpec;

            //内边距
            InnerTopSpec = Convert.ToInt32(_ScreenWidth / 18 * 0.2);
            InnerLeftSpec = Convert.ToInt32(_ScreenHeight / 32 * 0.2);

        }
              
    }
}
