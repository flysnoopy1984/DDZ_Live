using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DDZProj.Core
{
    public class Poker
    {
        private static Image backImage;//背面图，静态

        public static Image BackImage
        {
            get { return Poker.backImage; }
            set { Poker.backImage = value; }
        }

        private Image _ForeImage = null;//牌的正面图

        public Image ForeImage
        {
            get { return _ForeImage; }
        }

     
        public int Index { get; set; } //做为牌的随机属性        

        public int No { get; set; } //牌号

        public int Size { get; set; } //牌大小

        public PokerColor Color { get; set; } //花色

        public Poker()
        {
        }

        public Poker(int no,int size, PokerColor c)
        {
            this.No = no;
            this.Size = size;
            this.Color = c;

            InitPoker();
        }       

        #region function
        private void InitPoker()
        {
            int imgNo =0;
            int i=0;
            if (this.No>0)
            {
                switch (Color)
                {
                    case PokerColor.spade:
                        i=0;
                        break;
                    case PokerColor.heart:
                        i = 1;
                        break;
                    case PokerColor.club:
                        i = 2;
                        break;
                    case PokerColor.diamond:
                        i = 3;
                        break;
                }

                if (No == 1 || No == 2)
                {
                    _ForeImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + No);
                }
                else
                {
                    imgNo = i * 13 + No;                
                   
                    _ForeImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + imgNo);                    
                }
               
            }
        }
        #endregion
    }
}
