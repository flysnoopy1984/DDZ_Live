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
using System.Runtime.InteropServices;

namespace DDZProj
{
    public partial class AreaScore : UserControl
    {

      

        Main _MainForm;
        AreaCtrl _TopArea;
        AreaCtrl _RightArea;
        public AreaScore(Main f)
        {         

            _MainForm = f;
            _TopArea = f.CurrentGame.GetAreaCtrl(AreaPos.top);
            _RightArea = f.CurrentGame.GetAreaCtrl(AreaPos.right);
            InitializeComponent();

            this.Init();         

        }

        #region 初始化
        void Init()
        {
            int w = this.Width;
            int h = this.Height;

            int x = _RightArea.Left+SysConfiguration.LeftSpec*2;
            int y = SysConfiguration.TopSpec;

            this.SetBounds(x, y, w, h);


            _MainForm.Controls.Add(this);

            pb1.Image = ImageHandler.GetFarmerPortrait();
            pb2.Image = ImageHandler.GetFarmerPortrait();
            pb3.Image = ImageHandler.GetFarmerPortrait();



        }
        #endregion
    }
}
