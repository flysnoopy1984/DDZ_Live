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
    public partial class AreaPoker : UserControl
    {
        Form _MainForm;
        private int _PokerBeginX;
        private int _PokerBeginY;

        public AreaPoker(Form f)
        {
            InitializeComponent();

            _MainForm = f;

            this.Init();

            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        void Init()
        {
           
            int w = SysConfiguration.ScreenWidth / 32*14;
            int h = SysConfiguration.ScreenHeight /2;

            int x = SysConfiguration.ScreenWidth / 32*9;
            int y = Convert.ToInt32(SysConfiguration.ScreenHeight / 18* 8.5);

            this.SetBounds(x, y, w, h);
            _MainForm.Controls.Remove(this);
            _MainForm.Controls.Add(this);     
        }
    }
}
