using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DDZEntity
{
    public class Poker
    {     
        
        private static Image _backImage=DDZCommon.ResManager.GetImageRes("PokerBack");//背面图，静态

        public static Image BackImage
        {
            get { return Poker._backImage; }
            
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

        public Poker(int no)
        {
            this.No = no; 

            InitPoker();
        }

        public Poker(int no,int size,PokerColor c)
        {
            this.No = no;
         
            this.Color = c;

            this.Size = size;           

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
                    _ForeImage =DDZCommon.ResManager.GetImageRes("_" + No);
                    if (No == 1)
                    {
                        Size = 17;
                        this.Color = PokerColor.Da;
                    }
                    else
                    {
                        Size = 16;
                        this.Color = PokerColor.Xiao;
                    }
                }
                else
                {
                    imgNo = i * 13 + No;
                    _ForeImage = DDZCommon.ResManager.GetImageRes("_" + No);

                    if (No >= 3 && No <= 15)
                    {
                        this.Color = PokerColor.spade;
                        this.Size = No;
                    }
                    if (No >= 16 && No <= 28)
                    {
                        this.Color = PokerColor.heart;
                        this.Size = No-13;
                    }
                    if (No >= 29 && No <= 41)
                    {
                        this.Color = PokerColor.club;
                        this.Size = No-26;
                    }
                    if (No >= 42 && No <= 54)
                    {
                        this.Color = PokerColor.diamond;
                        this.Size = No-39;
                    }

                }
               
            }
        }
        #endregion
    }
}
