using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZEntity;
using DDZProj.Core;
using System.Threading;
using DDZCommon;

namespace DDZProj
{
    public partial class AreaCtrl : UserControl
    {
        /// <summary>
        /// 表示区域位置
        /// </summary>
        private AreaPos _AreaPos;
        private Form _MainForm;
        
        private int _PCurX;
        private int _PCurY;        
        private int _AreaWidth, _AreaHeight;
        private int _maxWidthNum;

        public List<DDZPokerImage> RemainPokerList { get; set; }
        public bool IsBoss { get; set; }
        public bool IsCurrent { get; set; }    
        public int CallScore { get; set; }

        //倒计时线程
        private Thread t_CountDown;
        private System.Threading.Timer _TimerCountDown;
      

       
        private int CountDownNum = -1;
        

        public AreaCtrl(AreaPos areaPos,Form f)
        {
            _AreaPos = areaPos;
            _MainForm = f;
            IsCurrent = false;
            InitializeComponent();

            this.Init();

            _TimerCountDown = new System.Threading.Timer(new TimerCallback(CountDown_CallBack), null, -1, 1000);

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        #region 初始化
        /// <summary>
        /// 初始化位置
        /// </summary>
        private void Init()
        {
            RemainPokerList = new List<DDZPokerImage>();

            int x = SysConfiguration.ScreenWidth / 2;
            int y = SysConfiguration.ScreenHeight / 2;
            int w = 0;
            int h = 0;
            if (_AreaPos == AreaPos.top)
            {
                w = SysConfiguration.ScreenWidth / 32*13;
                h = SysConfiguration.ScreenHeight / 9 * 4 - SysConfiguration.TopSpec;
                x = Convert.ToInt32(SysConfiguration.ScreenWidth / 32*9.5);
                y = SysConfiguration.TopSpec;
                //手牌区域
                p_PokerInfo.Height = Convert.ToInt32(SysConfiguration.ScreenHeight /9);
                //最大手牌数量
                _maxWidthNum = 20;
            }
            else
            {
                w = SysConfiguration.ScreenWidth / 4;
                h = Convert.ToInt32(SysConfiguration.ScreenHeight / 18*11.5);
                if (_AreaPos == AreaPos.left)
                    x = SysConfiguration.LeftSpec;
                else if (_AreaPos == AreaPos.right)
                    x = SysConfiguration.ScreenWidth - w - SysConfiguration.LeftSpec;

                y = SysConfiguration.ScreenHeight / 18*5;

                //手牌区域
                p_PokerInfo.Height = Convert.ToInt32(SysConfiguration.ScreenHeight / 18 * 3.5);
                //最大手牌数量
                _maxWidthNum = SysConfiguration.MaxPokerWidthNum;

            }
            _AreaWidth = w;
            _AreaHeight = h;
            this.SetBounds(x, y, w, h);
            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);
          
        }

        #endregion

        #region 接口--获取牌信息
        /// <summary>
        /// 获取牌信息
        /// </summary>
        public void ObtainPoker(DDZGame game,List<Poker> pokerList)
        {

            RemainPokerList.Clear();
            foreach (Poker p in pokerList)
            {
                RemainPokerList.Add(game.PokerImageList[p.No]);
            }          
        }

        public void ShowOne(int i)
        {
            DDZPokerImage pi  = RemainPokerList[i];
            _PCurX = 0;
            _PCurY = 0;

            p_PokerInfo.Controls.Add(pi);
            pi.Show();
            pi.BackgroundImage = pi.Poker.ForeImage;

            if (i > _maxWidthNum-1)
            {
                i -= _maxWidthNum ;
                i--;
                _PCurY += SysConfiguration.PokerHeight / 2;
            }

            _PCurX = i * SysConfiguration.PokerXSep;
            pi.SetBounds(_PCurX , _PCurY, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
            
            pi.BringToFront();
        }

        #endregion

        #region 倒计时
        public void CallingBoss()
        {
            IsCurrent = true;
            CountDownNum = SysConfiguration.CallScoreTime;
            Refresh();

            _TimerCountDown.Change(0, 1000);         
              
          
        }

        void CountDown_CallBack(object state)
        {
            Refresh();
            CountDownNum--;
            if (CountDownNum < -1 || IsCurrent == false)
            {
                _TimerCountDown.Change(-1, 0);
                CountDownNum = -1;
                IsCurrent = false;
                Refresh();
            }           
        }

     
        #endregion

        private void AreaCtrl_Paint(object sender, PaintEventArgs e)
        {
     
            Color c = Color.White;
            int w = 2;
            if (IsCurrent)
            {
                c = Color.Yellow;
                w = 4;
            }
            else
            {
                c = Color.White;
                w = 2;
            }
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

            if (CountDownNum == -1)
            {
                Util.PaintNewFont(e.Graphics, "");
            }
            else
            {
                Util.PaintNewFont(e.Graphics, CountDownNum.ToString());
            }    
          
        }

      


    }
}
