using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZProj.Core;
using System.Threading;
using System.Media;
using AnimatorNS;
using System.Configuration;
using DDZProj.Effect;

namespace DDZProj
{
    public partial class Main : Form
    {
        private ConsoleMain _ConsoleMain;    
        
        private ScreenControl _ScreenControl;

        private AnimationType _AnimationType;
        
        private Thread th_ImgLR;   //出牌线程
        private Graphics _AnimatorDC;
        private DDZGame _DDZGame;
        private EndCtrl _EndArea;
        private Begin_YXKS _Begin_YXKS;

        public DDZGame CurrentGame
        {
            get { return _DDZGame; }
        }

        public Animator GetAnimator()
        {
            return this.animator1;
        }

        public void ShowBegin()
        {

           // beginImg = ImageHandler.ImageTransfer(beginImg, 660, 200, beginImg.Width, beginImg.Height);
           // ImageFromLeftToRight(srcImg, 20, (SysConfiguration.ScreenWidth + srcImg.Width) / 2, 400);
            ImageFromLeftToRight();
        }

        public void ShowEndForm()
        {
         

            _EndArea.BringToFront();
            _EndArea.SetBounds(SysConfiguration.ScreenWidth / 2 - _EndArea.Width / 2,
                               SysConfiguration.ScreenHeight / 2 - _EndArea.Height / 2,
                               _EndArea.Width,
                               _EndArea.Height);
            _EndArea.Hide();

            animator1.AnimationType = _AnimationType;
            animator1.Show(_EndArea);
        }

        public void HideEndForm()
        {
            if (_EndArea != null)
            {

                animator1.AnimationType = _AnimationType;
                animator1.Hide(_EndArea);
            }
        }

        public Main()
        {
            InitializeComponent();

            _ScreenControl = new ScreenControl(this);
            _ConsoleMain = new ConsoleMain(this);
             

            //系统参数设置
            SysConfiguration.Init();      
         


            /* 各种特效 Begin*/
           
            _AnimationType = AnimationType.Scale;
            //结局特效
            _EndArea = new EndCtrl();
            _EndArea.Hide();
            this.Controls.Add(_EndArea);

            _Begin_YXKS = new Begin_YXKS();
            _Begin_YXKS.Hide();
            this.Controls.Add(_Begin_YXKS);

            //开始特效


            /* 各种特效 End*/

            //一局游戏初始化
            _DDZGame = new DDZGame(this);
            _DDZGame.InitGame();          

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }


        #region 特效
        public void ImageFromLeftToRight()
        {
            int bx = 0;
            int ex = 2000;
            int y = 400;

            Bitmap srcImg = new Bitmap(_Begin_YXKS.Width, _Begin_YXKS.Height);
            _Begin_YXKS.DrawToBitmap(srcImg, new Rectangle(0, 0, srcImg.Width, srcImg.Height));


            _AnimatorDC = _Begin_YXKS.CreateGraphics();

            Color bgColor = Color.FromKnownColor(KnownColor.White);
            int stepX = 30;
            int delay = 10;

            th_ImgLR = new Thread(delegate()
            {
                int cx = bx;
                while (cx + srcImg.Width < ex)
                {
                    _AnimatorDC.Clear(bgColor);
                    _AnimatorDC.DrawImage(srcImg, cx, y);
                    cx += stepX;
                    Thread.Sleep(delay);

                    _Begin_YXKS.Invalidate();
                }
            });

            th_ImgLR.Start();
        }
      
        #endregion


        #region Form 重载函数
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            /*全屏*/

            if (msg.Msg == 256 && keyData == (System.Windows.Forms.Keys.Control | Keys.Enter))
            {               
                this.SetVisibleCore(false);
                _ScreenControl.Full();
                this.SetVisibleCore(true);
                return true;
            }
            if (msg.Msg == 256 && keyData == (System.Windows.Forms.Keys.Escape))
            {              
                _ScreenControl.Esc();
                return true;
            }
            /* 开始发牌 */
            if (msg.Msg == 256 && keyData == (System.Windows.Forms.Keys.Enter))
            {
                if (_ConsoleMain == null)
                    _ConsoleMain = new ConsoleMain();
                _ConsoleMain.Show();            
                
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

    }
}
