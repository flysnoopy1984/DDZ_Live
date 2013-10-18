using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
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
        private Player _Player;

        public AreaCtrl(AreaPos areaPos,Form f)
        {
            _AreaPos = areaPos;
            _MainForm = f;
            InitializeComponent();

            this.Init();
        }

        /// <summary>
        /// 初始化位置
        /// </summary>
        private void Init()
        {
            int x = SysConfiguration.ScreenWidth / 2;
            int y = SysConfiguration.ScreenHeight / 2;
            int w = 0;
            int h = 0;
            if (_AreaPos == AreaPos.top)
            {
                w = SysConfiguration.ScreenWidth / 3;
                h = SysConfiguration.ScreenHeight / 3;
                x = SysConfiguration.ScreenWidth / 3;
                y = SysConfiguration.TopSpec;
            }
            else
            {
                w = SysConfiguration.ScreenWidth / 4;
                h = SysConfiguration.ScreenHeight / 3 * 2 - SysConfiguration.TopSpec;
                if (_AreaPos == AreaPos.left)
                    x = SysConfiguration.LeftSpec;
                else if (_AreaPos == AreaPos.right)
                    x = SysConfiguration.ScreenWidth - w - SysConfiguration.LeftSpec;

                y = SysConfiguration.ScreenHeight / 3;

            }
            
            this.SetBounds(x, y, w, h);
            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);        
        }

        /// <summary>
        /// 设置玩家
        /// </summary>
        public void SetPlayer(Player pl)
        {
            _Player = pl;
        }

        /// <summary>
        /// 获取发牌
        /// </summary>
        public void ObtainPoker(List<Poker> pokerList)
        {
            _Player.RemainPoker = pokerList;
        }


        
    }
}
