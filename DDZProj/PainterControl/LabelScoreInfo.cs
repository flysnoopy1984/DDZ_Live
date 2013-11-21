using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace DDZProj.PainterControl
{
    public partial class LabelScoreInfo : Label
    {
        public LabelScoreInfo()
        {
            InitializeComponent();
            InitConfig();
        }

        public LabelScoreInfo(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            InitConfig();
        }

        private void InitConfig()
        {
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10,FontStyle.Bold);
            this.ForeColor = Color.White;
           
        }
    }
}
