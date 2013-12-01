using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DDZProj.Effect
{
    public partial class Begin_DXJ : UserControl
    {
      
     
        public Begin_DXJ()
        {
            InitializeComponent();

            LayoutForSingle();
        }

        private void LayoutForTen()
        {

            this.pb_NumSingle.SetBounds(163, 0, pb_NumSingle.Width, this.Height);
            pb_NumTen.Visible = true;
            this.pb_NumTen.SetBounds(265, 0, pb_NumTen.Width, this.Height);           
        }

        private void LayoutForSingle()
        {
            this.pb_NumSingle.SetBounds(221, 0, pb_NumSingle.Width, this.Height);
            pb_NumTen.Visible = false;
            this.pb_NumTen.SetBounds(221, 0, pb_NumTen.Width, this.Height);  
        }

        public void SetTurnNum(int num)
        {
            int A,B;
            string resA, resB,resFormat;
            resFormat = "char_{0}";
            if (num >= 10)
            {
                A = num / 10;
                B = num % 10;
                LayoutForTen();
                resA = string.Format(resFormat, A);
                resB = string.Format(resFormat, B);
                pb_NumSingle.BackgroundImage = DDZCommon.ResManager.GetImageRes(resA);
                pb_NumTen.BackgroundImage = DDZCommon.ResManager.GetImageRes(resB);


            }
            else
            {
                LayoutForSingle();
                resA = string.Format(resFormat, num);
              
                pb_NumSingle.BackgroundImage = DDZCommon.ResManager.GetImageRes(resA);
            }
        }
    }
}
