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
        private ConsoleMain _ConsoleMain;
        private ScreenControl _ScreenControl;
      
        
        private Thread th_PostCard;   //出牌线程
        private DDZGame _DDZGame;

        int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 11, 21, 23, 12, 32, 45, 27, 52, 32 };
       
        public Main()
        {
            InitializeComponent();

            _ScreenControl = new ScreenControl(this);
            _ConsoleMain = new ConsoleMain(this);  
          
            SysConfiguration.Init();

            _DDZGame = new DDZGame(this);
            _DDZGame.InitGame();

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        /// <summary>
        /// 初始化桌面布局
        /// </summary>
        private void InitLayOut()
        {
            //int x = SysConfiguration.ScreenWidth/2 
        }

       

        #region 出牌
        /*
        void PostCard()
        {
            Random r = new Random();
            int i =r.Next(0, pokerImages.Length-1);

            PictureBox pi = pokerImages[i];
            
            pi.SetBounds(500, 500, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight); 

        }
        */

        void PostCardAction()
        {
            /*
            th_PostCard = new Thread(new ThreadStart(PostCard));
            th_PostCard.Start();
            th_PostCard.Join();
             * */
        }

        #endregion      
     

        private void bn_Post_Click(object sender, EventArgs e)
        {
            
            PostCardAction();
        }

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
            if (msg.Msg == 256 && keyData == (System.Windows.Forms.Keys.Enter))
            {
                _DDZGame.StartDealt();
                return true;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }      

     
    }
}
