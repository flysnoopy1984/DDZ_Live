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

        private int _index;//做为牌的随机属性

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public int No { get; set; } //牌号

        public int Color { get; set; } //花色

        public Poker()
        {
        }

        public Poker(int no)
        {
            this.No = no;
            InitPoker();
        }     

       

        #region function
        private void InitPoker()
        {         

            if (this.No>0)
            {
                _ForeImage = (Image)Properties.Resources.ResourceManager.GetObject("_" + No);
            }
        }
        #endregion
    }
}
