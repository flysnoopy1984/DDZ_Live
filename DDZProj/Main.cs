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

namespace DDZProj
{
    public partial class Main : Form
    {
        private bn_3n _ConsoleMain;
        private ScreenControl _ScreenControl;        
        
        private Thread th_PostCard;   //出牌线程
        private DDZGame _DDZGame;

        public DDZGame CurrentGame
        {
            get { return _DDZGame; }
        }

        public Main()
        {
            InitializeComponent();

            _ScreenControl = new ScreenControl(this);
            _ConsoleMain = new bn_3n(this);  
            
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
                    _ConsoleMain = new bn_3n();
                _ConsoleMain.Show();
                
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

    }
}
