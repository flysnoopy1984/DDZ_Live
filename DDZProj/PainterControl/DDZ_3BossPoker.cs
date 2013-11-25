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

namespace DDZProj.PainterControl
{
    public partial class DDZ_3BossPoker : UserControl
    {
        Dictionary<int, PictureBox> _BossPBList;
        public DDZ_3BossPoker()
        {
            

            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.Width = SysConfiguration.AreaBossPokerWidth;
            this.Height = SysConfiguration.AreaBossPokerHeight;
           
            pb1.SetBounds(0, 0, this.Width / 3, this.Height);
            pb2.SetBounds(pb1.Right, 0, this.Width / 3, this.Height);
            pb3.SetBounds(pb2.Right, 0, this.Width / 3, this.Height);

            _BossPBList = new Dictionary<int, PictureBox>();
            _BossPBList.Add(0, pb1);
            _BossPBList.Add(1, pb2);
            _BossPBList.Add(2, pb3);
        }

        public void SetBossPoker(List<DDZPokerImage> bossImageList)
        {
            for(int i=0;i<3;i++)
            {
                DDZPokerImage pi =bossImageList[i];
                Image srcImg = pi.Poker.ForeImage;
               // Image tagImg = ImageHandler.ImageTransfer(srcImg, _BossPBList[i].Width, _BossPBList[i].Height, srcImg.Width / 2, srcImg.Height);
                _BossPBList[i].BackgroundImage = srcImg;
            }
            
        }

        public void ResetArea()
        {
            pb1.BackgroundImage = null;
            pb2.BackgroundImage = null;
            pb3.BackgroundImage = null;
        }
    }
}
