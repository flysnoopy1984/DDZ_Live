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
using Pfz.AnimationManagement.WinForms;
using Pfz.AnimationManagement;
using System.Diagnostics;

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

        #region 特效移动位置
        private int yxks_x, yxks_y, dxj_x, dxj_y;
        private bool _IsFirst = true;
        #endregion
        //private Begin_YXKS _Begin_YXKS;
        //private Begin_DXJ _Begin_DXJ;

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
            GameBeginEffect();
            
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
            //pfz 特效初始化
            Initializer.Initialize();

            _AnimationType = AnimationType.Scale;

            //结局特效
            _EndArea = new EndCtrl();
            _EndArea.Hide();
            this.Controls.Add(_EndArea);
            

           
            //开始特效


            /* 各种特效 End*/

            //一局游戏初始化
            _DDZGame = new DDZGame(this);
            _DDZGame.InitGame();          

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }


        #region 特效
        public void GameBeginEffect()
        {
            _Begin_YXKS.Show();
            _Begin_DXJ.Show();

            _Begin_YXKS.SetBounds(-_Begin_YXKS.Width, yxks_y, _Begin_YXKS.Width, _Begin_YXKS.Height);
            _Begin_DXJ.SetBounds(SysConfiguration.ScreenWidth + _Begin_DXJ.Width, dxj_y, _Begin_DXJ.Width, _Begin_DXJ.Height);

           
          
            yxks_x = SysConfiguration.ScreenWidth / 2 - _Begin_YXKS.Width * 3 / 4;
            yxks_y = SysConfiguration.ScreenHeight / 2 - _Begin_YXKS.Height;

            dxj_x = SysConfiguration.ScreenWidth / 2 - _Begin_DXJ.Width / 4;
            dxj_y = SysConfiguration.ScreenHeight / 2;

           
            _Begin_DXJ.SetTurnNum(12);

            int x1 = -_Begin_YXKS.Width;
            int x2 = SysConfiguration.ScreenWidth + _Begin_DXJ.Width;
            Dictionary<int,bool> aniState = new Dictionary<int,bool>();
            aniState.Add(1, false);
            aniState.Add(2, false);
            Thread t = new Thread(delegate() {

                while (aniState[1] == false || aniState[2] == false)
                {
                    if(x1 <= yxks_x)
                    {
                        x1 += 100;
                        _Begin_YXKS.SetBounds(x1, yxks_y, _Begin_YXKS.Width, _Begin_YXKS.Height);
                        if (x1!=yxks_x && x1 + 100 > yxks_x )
                        {
                            x1 = yxks_x;
                            aniState[1] = true;
                        }                
                      
                    }
                    if (x2 >= dxj_x)
                    {
                         x2 -= 100;
                         _Begin_DXJ.SetBounds(x2, dxj_y, _Begin_DXJ.Width, _Begin_DXJ.Height);
                         if (x2 != dxj_x && x2 - 100 < dxj_x)
                         {
                             x2 = dxj_x;
                             aniState[2] = true;
                         }
                       
                    }
                  
                    Thread.Sleep(30);
                }

                Thread.Sleep(1000);
                _Begin_YXKS.Hide();
                _Begin_DXJ.Hide();

                this.CurrentGame.StartDealt();
              
            });
            t.Start();
        
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

        private void _Begin_YXKS_Move(object sender, EventArgs e)
        {
            //if (_Begin_YXKS.Left == yxks_x)
            //{
               
            //    _Begin_YXKS.Hide();
            //    _Begin_DXJ.Hide();

            //    _Begin_YXKS.SetBounds(0, yxks_y, _Begin_YXKS.Width, _Begin_YXKS.Height);
            //    _Begin_DXJ.SetBounds(0, dxj_y, _Begin_DXJ.Width, _Begin_DXJ.Height);

            //    Thread.Sleep(1000);
            //    if (_IsFirst)
            //    {
            //        this.CurrentGame.StartDealt();
            //        _IsFirst = false;
            //    }
               
            //}



        }

      
        private void animator1_AnimationCompleted(object sender, AnimationCompletedEventArg e)
        {
            if (e.Mode == AnimateMode.Hide)
            {
                ShowBegin();
            }
        }

    }
}
