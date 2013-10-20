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

namespace DDZProj
{
    public partial class AreaCtrl : UserControl
    {
        /// <summary>
        /// 表示区域位置
        /// </summary>
        private AreaPos _AreaPos;
        private Form _MainForm;
        
        private int _PokerBeginX;
        private int _PokerBeginY;
        private int _AreaWidth, _AreaHeight;

        public List<DDZPokerImage> RemainPokerList { get; set; }
      //  public Player Player { get; set; }
        

        public AreaCtrl(AreaPos areaPos,Form f)
        {
            _AreaPos = areaPos;
            _MainForm = f;
            InitializeComponent();

            this.Init();

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

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
            
            this.SetBounds(x, y, w, h);
            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);        
           
        }   

        /// <summary>
        /// 获取发牌
        /// </summary>
        public void ObtainPoker(List<Poker> pokerList)
        {
            RemainPokerList.Clear();
            foreach (Poker p in pokerList)
            {
                DDZPokerImage pi = new DDZPokerImage(p);
                RemainPokerList.Add(pi);                
            }          
        }

        public void ShowOne(int i)
        {
            DDZPokerImage pi  = RemainPokerList[i];
            _MainForm.Controls.Remove(pi);
         //   p_PokerInfo.Controls.Remove(pi);
          //  p_PokerInfo.Controls.Add(pi);

            pi.Show();
            pi.BackgroundImage = pi.Poker.ForeImage;
            pi.SetBounds(i * SysConfiguration.PokerXSep, 100, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
            pi.BringToFront();

        }


        
    }
}
