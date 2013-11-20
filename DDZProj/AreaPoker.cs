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

namespace DDZProj
{
    public partial class AreaPoker : UserControl
    {
        Main _MainForm;
        public string TopInfo = "";
        public string LeftInfo = "";
        public string RightInfo = "";
        public Dictionary<AreaPos, List<Poker>> _PostedPokerList; // 牌局中所有已出的拍

        public AreaPoker(Main f)
        {
            InitializeComponent();

            _MainForm = f;

            this.Init();

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        void Init()
        {
            int w = SysConfiguration.ScreenWidth / 32 * 14;
            int h = SysConfiguration.ScreenHeight / 2;

            int x = SysConfiguration.ScreenWidth / 32 * 9;
            int y = Convert.ToInt32(SysConfiguration.ScreenHeight / 18 * 8.5);

            this.SetBounds(x, y, w, h);

            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);

            int ph = h / 3;
            this.p_left.Height = ph;
            this.p_right.Height = ph;
            this.p_Top.Height = ph;

        }
        public void PostInfo(AreaPos fromPos, string info)
        {
            switch (fromPos)
            {
                case AreaPos.top:
                    TopInfo = info;
                    p_Top.Refresh();
                    break;
                case AreaPos.left:
                    LeftInfo = info;
                    p_left.Refresh();
                    break;
                case AreaPos.right:
                    RightInfo = info;
                    p_right.Refresh();
                    break;
            }
        }

        public void PostScore(AreaPos fromPos, int s)
        {
            if (s > 0 && s <= 3)
            {
                string info = s.ToString();
                PostInfo(fromPos, info);               
            }
        }       

        public void PostPoker(AreaPos fromPos, List<DDZPokerImage> postList)
        {
            AreaCtrl.OrderPoker(postList);
            int direction = 1;
            switch (fromPos)
            {
                case AreaPos.top:
                    p_Top.Controls.Clear();
                    p_Top.Controls.AddRange(postList.ToArray());
                    break;
                case AreaPos.left:
                    p_left.Controls.Clear();
                    p_left.Controls.AddRange(postList.ToArray());                  
                    break;
                case AreaPos.right:
                    p_right.Controls.Clear();
                    p_right.Controls.AddRange(postList.ToArray());
                    direction = -1;
                    break;
            }
            SetPostPoker(postList, direction);
        }

        private void SetPostPoker(List<DDZPokerImage> postList,int direction = 1)
        {        
            for (int i = 0; i < postList.Count; i++)
            {
                postList[i].ShowPoker();
                postList[i].SetBounds(SysConfiguration.LeftSpec+i * SysConfiguration.PokerXSep, 0, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
            }
        }

        public void ClearInfo()
        {
            TopInfo = "";
            RightInfo = "";
            LeftInfo = "";
            Refresh();
        }

        #region 重置游戏--Poker
        public void ResetArea()
        {
            p_left.Controls.Clear();
            p_Top.Controls.Clear();
            p_right.Controls.Clear();
            ClearInfo();
        }
        #endregion

        private void p_Top_Paint(object sender, PaintEventArgs e)
        {
            if (_MainForm.CurrentGame.GetGameState() == GameState.CallingBoss)
                Util.PaintNewFont(e.Graphics, TopInfo, Color.Gray,SysConfiguration.LeftSpec,0);
        }

        private void p_right_Paint(object sender, PaintEventArgs e)
        {
            int len = RightInfo.Length * Util.PaintNewFont_Size;
            if (_MainForm.CurrentGame.GetGameState() == GameState.CallingBoss)
                Util.PaintNewFont(e.Graphics, RightInfo, Color.Gray, this.p_right.Width - len, 0);
        }

        private void p_left_Paint(object sender, PaintEventArgs e)
        {
            if (_MainForm.CurrentGame.GetGameState() == GameState.CallingBoss)
                Util.PaintNewFont(e.Graphics, LeftInfo, Color.Gray, SysConfiguration.LeftSpec, 0);
        }
    }
}
    