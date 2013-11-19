using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZCommon;

namespace DDZProj.PainterControl
{
    public enum CountShowState
    {
        Show = 1,
        Hide =0,
        Flash = 2,
    }

    public partial class DDZ_TimeCount : UserControl
    {
        private int _Count = 0;
        /// <summary>
        /// 当一位小数，A个位数
        /// 当两位小数时，A个位数，B十位数，
        /// </summary>
        private int _A, _B;
        private CountShowState _ShowState = CountShowState.Hide;

        public DDZ_TimeCount()
        {
            InitializeComponent();
        }

        public void Reset()
        {
            _Count = 0;
            _A = 0;
            _B = 0;
            _ShowState = CountShowState.Hide;
            this.Refresh();
        }

        public void SetCount(int count, CountShowState showState)
        {          
            _ShowState = showState;
            SetCount(count);
        }

        public void SetCount(int count)
        {
            _Count = count;
            if (_Count >=10)
            {
                _A = _Count / 10;
                _B = _Count % 10;
            }
            this.Refresh();
        }        

        private void DDZ_TimeCount_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                if (_ShowState == CountShowState.Show)
                {
                    string resNameFormat = "ddz_count_{0}";
                    string resName = "";
                    if (_Count >= 10)
                    {
                        resName = string.Format(resNameFormat, _A);
                        Image imgA = ResManager.GetImageRes(resName);
                        e.Graphics.DrawImage(imgA, 0, 0);

                        resName = string.Format(resNameFormat, _B);
                        Image imgB = ResManager.GetImageRes(resName);
                        e.Graphics.DrawImage(imgB, imgA.Width, 0);

                    }
                    else
                    {
                        resName = string.Format(resNameFormat, _Count);
                        Image img = ResManager.GetImageRes(resName);
                        e.Graphics.DrawImage(img, 0, 0);
                    }
                }
            }
            catch
            {
            }
        }
    }
}
