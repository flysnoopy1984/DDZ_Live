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
        public string TopScore = "";
        public string LeftScore = "";
        public string RightScore = "";
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

        public void PostScore(AreaPos fromPos, int s)
        {
            if (s > 0 && s <= 3)
            {
                switch (fromPos)
                {
                    case AreaPos.top:
                        TopScore = s.ToString();
                        p_Top.Refresh();
                        break;
                    case AreaPos.left:
                        LeftScore = s.ToString();
                        p_left.Refresh();
                        break;
                    case AreaPos.right:
                        RightScore = s.ToString();
                        p_right.Refresh();
                        break;
                }

            }
           

        }

        public void PostPoker(AreaPos fromPos, List<DDZPokerImage> postList)
        {
            switch (fromPos)
            {
                case AreaPos.top:
                    p_Top.Controls.Clear();
                    p_Top.Controls.AddRange(postList.ToArray());
                    break;
                case AreaPos.left:
                    p_Top.Controls.Clear();
                    p_left.Controls.AddRange(postList.ToArray());                  
                    break;
                case AreaPos.right:
                    p_Top.Controls.Clear();
                    p_right.Controls.AddRange(postList.ToArray());
                    break;
            }
        }

        public void ClearScore()
        {
            TopScore = "";
            RightScore = "";
            LeftScore = "";
            Refresh();
        }

      

        private void p_Top_Paint(object sender, PaintEventArgs e)
        {
            if(_MainForm.CurrentGame.GetGameState() == -1)
                Util.PaintNewFont(e.Graphics, TopScore, Color.Gray,SysConfiguration.LeftSpec,0);
        }

        private void p_right_Paint(object sender, PaintEventArgs e)
        {
            if (_MainForm.CurrentGame.GetGameState() == -1)
                Util.PaintNewFont(e.Graphics, RightScore, Color.Gray, this.p_right.Width - 30, 0);
        }

        private void p_left_Paint(object sender, PaintEventArgs e)
        {
            if (_MainForm.CurrentGame.GetGameState() == -1)
                Util.PaintNewFont(e.Graphics, LeftScore, Color.Gray, SysConfiguration.LeftSpec, 0);
        }
    }
}
    