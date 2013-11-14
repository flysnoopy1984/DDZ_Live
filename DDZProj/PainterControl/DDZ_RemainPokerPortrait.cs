using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZProj.Core;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using DDZUnsafeCode;

namespace DDZProj.PainterControl
{
    public partial class DDZ_RemainPokerPortrait : UserControl
    {
        private int _RemainPokerNum=17;
        public DDZ_RemainPokerPortrait()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.pl_RemainPokerBK.BackgroundImage = ImageHandler.GetRemainPokerBKImage();
            this.pl_RemainPokerNumBK.BackgroundImage = ImageHandler.GetRemainPokerNumBK();


            UnSafeImage.ControlTrans(pl_RemainPokerNumBK, ImageHandler.GetRemainPokerNumBK());
        }

        private void DDZ_RemainPokerPortrait_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pl_RemainPokerBK_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush bh = new SolidBrush(Color.FromArgb(208,79,15));

            e.Graphics.DrawString("剩余",new Font("微软雅黑",10,FontStyle.Bold),bh,14,4);

          
        }

        private void pl_RemainPokerNumBK_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush bh = new SolidBrush(Color.White);
            string num = _RemainPokerNum == 0 ? "" : Convert.ToString(_RemainPokerNum);
            e.Graphics.DrawString(num, new Font("隶书", 14, FontStyle.Bold), bh, 7, 10);
        }

      
    }
}
