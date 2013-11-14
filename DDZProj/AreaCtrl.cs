﻿using System;
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
        private Main _MainForm;        
        
        private int _PCurX;
        private int _PCurY;        
        private int _AreaWidth, _AreaHeight;
        private int _maxWidthNum;//一行最大排数量(第一次计算得出)
    
        //倒计时线程    
        private System.Threading.Timer _TimerCountDown;  
        private int _CountDownNum = -1;

       
        public bool IsBoss { get; set; }
        public bool IsCurrent { get; set; }
        public int CallScore { get; set; }
        public List<DDZPokerImage> RemainPokerList { get; set; }
        public List<DDZPokerImage> PostPokerList { get; set; }
        public int Score { get; set; }
        public Image _ImgPortrait;

        public AreaPos GetAreaPos()
        {
            return _AreaPos;
        }

        public AreaCtrl(AreaPos areaPos, Main f)
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

            }
            _AreaWidth = w;
            _AreaHeight = h;
            this.SetBounds(x, y, w, h);
            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);
            _maxWidthNum = (_AreaWidth - 5 * 2) / SysConfiguration.PokerXSep -1;

            ////头像
            //_ImgPortrait = ImageHandler.GetFarmerPortrait();
            //this.pb_Portrait.Image = _ImgPortrait;
          
        }

        public void Reset()
        {
            IsCurrent = false;
            _CountDownNum = -1;
            IsBoss = false;
        }

        #endregion

        #region 接口--获取牌信息
        /// <summary>
        /// 获取牌信息
        /// </summary>
        public void ObtainPoker(List<Poker> pokerList)
        {
            RemainPokerList.Clear();
            int i=1;
            foreach (Poker p in pokerList)
            {
                p.Index = i;
                i++;
                RemainPokerList.Add(_MainForm.CurrentGame.PokerImageList[p.No]);
            }
            AreaCtrl.OrderPoker(RemainPokerList);
        }

        public void ShowRemainPoker()
        {
            for (int i = 0; i < RemainPokerList.Count; i++)
            {
                ShowOne(i);

            }

        }

        public void ShowOne(int i)
        {
            DDZPokerImage pi  = RemainPokerList[i];
            _PCurX = 0;
            _PCurY = 0;

            p_PokerInfo.Controls.Add(pi);
            pi.ShowPoker();

            if (i+1 > _maxWidthNum)
            {
                i -= _maxWidthNum;
                _PCurY += SysConfiguration.PokerHeight / 2;
                 
            }

            _PCurX = i * SysConfiguration.PokerXSep + SysConfiguration.LeftSpec;            

            pi.SetBounds(_PCurX , _PCurY, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
            
            pi.BringToFront();
        }

        #endregion

        #region 倒计时
        public void Counting()
        {
            IsCurrent = true;
            _CountDownNum = SysConfiguration.CallScoreTime;
            PostPokerList = null;
            Refresh();

            _TimerCountDown.Change(0, 1000);      
        }     

        void CountDown_CallBack(object state)
        {
            Refresh();
            _CountDownNum--;
            if (_CountDownNum < -1 || IsCurrent == false)
            {
                _TimerCountDown.Change(-1, 0);
                _CountDownNum = -1;
                IsCurrent = false;
                Refresh();
            }           
        }

     
        #endregion    

        #region 设置地主图标
        public void SetBoss()
        {
            IsBoss = true;

        }
        #endregion

        #region 出牌
        public void PostPoker(List<Poker> postPoker)
        {
            PostPokerList = new List<DDZPokerImage>();
            foreach (Poker p in postPoker)
            {
                foreach (DDZPokerImage pi in RemainPokerList)
                {
                    if (pi.Poker.No == p.No)
                    {
                        PostPokerList.Add(pi);
                        RemainPokerList.Remove(pi);
                        break;
                    }
                }
            }
            this.p_PokerInfo.Controls.Clear();
            ShowRemainPoker();
            this.IsCurrent = false;
        }

        public void Pass()
        {
            this.IsCurrent = false;
            Refresh();
        }
        #endregion

        #region 排序
        /// <summary>
        /// 大小排序，没有花色之分
        /// </summary>
        /// <param name="list"></param>
        public static void OrderPoker(List<DDZPokerImage> list)
        {
            DDZPokerImage mpi = list[0];
            int ms = mpi.Poker.Size;
            Poker temp;
            int j = 0;

            for (int i = 1; i < list.Count; i++)
            {
                j = 0;

                while (j < i)
                {
                    if (list[i].Poker.Size < list[j].Poker.Size)
                    {
                        temp = list[j].Poker;
                        list[j].ChangePoker(list[i].Poker);
                        list[i].ChangePoker(temp);
                    }
                    j++;
                }

            }
        }
        #endregion

        #region 呈现Paint

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

            if (_CountDownNum == -1)
            {
                Util.PaintNewFont(e.Graphics, "");
            }
            else
            {
                Util.PaintNewFont(e.Graphics, _CountDownNum.ToString());
            }

        }
        #endregion

   
    }
}
