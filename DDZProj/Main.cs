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

namespace DDZProj
{
    public partial class Main : Form
    {
        private ConsoleMain _ConsoleMain;
        private EndForm _EndForm;
        
        private ScreenControl _ScreenControl;        
        
        private Thread th_PostCard;   //出牌线程
        private DDZGame _DDZGame;

        public DDZGame CurrentGame
        {
            get { return _DDZGame; }
        }

        public Animator GetAnimator()
        {
            return this.animator1;
        }

        //public void ShowEndForm()
        //{
        //    if (_EndForm == null)
        //        _EndForm = new EndForm();

        //    _EndForm.SetBounds(SysConfiguration.ScreenWidth / 2 - _EndForm.Width / 2,
        //                       SysConfiguration.ScreenHeight / 2 - _EndForm.Height/2,
        //                       _EndForm.Width, 
        //                       _EndForm.Height);
        //    _EndForm.Hide();
        
          
 
        //}

        public void ShowEndForm()
        {
            EndCtrl area = new EndCtrl();
            this.Controls.Add(area);
            area.BringToFront();
            area.SetBounds(SysConfiguration.ScreenWidth / 2 - area.Width / 2,
                               SysConfiguration.ScreenHeight / 2 - area.Height / 2,
                               area.Width,
                               area.Height);
            area.Hide();

           animator1.DefaultAnimation = Animation.Particles;
           animator1.Show(area);


        }

        public Main()
        {
            InitializeComponent();

            _ScreenControl = new ScreenControl(this);
            _ConsoleMain = new ConsoleMain(this);
            _EndForm = new EndForm();         

            //系统参数设置
            SysConfiguration.Init();

            //一局游戏初始化
            _DDZGame = new DDZGame(this);
            _DDZGame.InitGame();          

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }  
     
        

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
