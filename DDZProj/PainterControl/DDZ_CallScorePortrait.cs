using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZProj.Core;
using DDZCommon;
using DDZEntity;

namespace DDZProj.PainterControl
{
    public partial class DDZ_CallScorePortrait : UserControl
    {
        public int BossCall { get; set; }

        public Image _CurrentPortaitImage;

        public DDZ_CallScorePortrait()
        {
            InitializeComponent();

            this.Init();

        }

        public Image GetCurrentPortaitImage()
        {
            return _CurrentPortaitImage;
        }
    
    

        private void Init()
        {
            _CurrentPortaitImage = ImageHandler.GetFarmerPortrait();

            this.pb_Portrait.Image = _CurrentPortaitImage;
            this.pb_CallBossNum.Image = ImageHandler.GetCallBossNum_OnPortrait(0);
        }

        public void SetPortrait(AreaPortrait portrait)
        {
            if (portrait == AreaPortrait.Boss)
            {
                _CurrentPortaitImage = ImageHandler.GetBossPortrait();              
            }
            else
            {
                _CurrentPortaitImage = ImageHandler.GetFarmerPortrait();
            }

            this.pb_Portrait.Image = _CurrentPortaitImage;
        }

        public void SetScore(int socre)
        {
            this.pb_CallBossNum.Image = ImageHandler.GetCallBossNum_OnPortrait(socre);
        }



        private void DDZ_CallScorePortrait_Paint(object sender, PaintEventArgs e)
        {
           

            Color c = Color.White;
            int w = 1;


            ControlPaint.DrawBorder(e.Graphics,
                                this.ClientRectangle,
                                c,
                                w,
                                ButtonBorderStyle.Solid,
                                c,
                                w,
                                ButtonBorderStyle.Solid,
                                c,
                                w,
                                ButtonBorderStyle.Solid,
                                c,
                                w,
                                ButtonBorderStyle.Solid);
            Util.PaintCallScorePortrait(e.Graphics, "档", _CurrentPortaitImage.Width+35, 6);
        }

        public void SetBossCall(int bossCall)
        {
            BossCall = bossCall;          

            this.Refresh();

        
        }
    }
}
