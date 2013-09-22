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

        public static void Init()
        {
            //屏幕长宽
            _ScreenWidth = Screen.PrimaryScreen.Bounds.Width;
            _ScreenHeight = Screen.PrimaryScreen.Bounds.Height;

            //牌的长宽
            _PokerWidth = 65;
            _PokerHeight = 100;

            //牌与牌的间隔距离
            _PokerXSep = _PokerWidth / 2;

        }
              
    }
}
