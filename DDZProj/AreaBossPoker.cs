using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZProj.Core;
using DDZEntity;

namespace DDZProj
{
    public partial class AreaBossPoker : UserControl
    {
        Main _MainForm;
        AreaCtrl _TopArea;
        public AreaBossPoker(Main f,AreaCtrl TopArea)
        {
            _MainForm = f;
            _TopArea = TopArea;

            InitializeComponent();

            Init();
        }

        #region 初始化
        void Init()
        {
            int w = _TopArea.Width / 2;
            int h = _TopArea.Height / 2;

            int x = _TopArea.Left - w - SysConfiguration.LeftSpec;
            int y = SysConfiguration.TopSpec;

            this.SetBounds(x, y, w, h);

          
            _MainForm.Controls.Add(this);

        }
        #endregion

        #region 设置Boss扑克

        public void SetBossPoker(List<Poker> bossList)
        {
            for (int i = 0; i < bossList.Count; i++)
            {
                Poker p = bossList[i];
                DDZPokerImage pi = _MainForm.CurrentGame.PokerImageList[p.No];
                pi.ShowPoker();
                pi.SetBounds(i * SysConfiguration.PokerWidth, 0, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pi.BringToFront();

                this.Controls.Add(pi);
            }
        }

        #endregion

        #region 重置游戏--BossPoker
        public void ResetArea()
        {
            this.Controls.Clear();

        }
        #endregion
    }
}
