using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZEntity;

namespace DDZProj
{
    public partial class DDZPokerImage : PictureBox
    {
        public Poker Poker { get; set; }

        public DDZPokerImage()
        {
            InitializeComponent();            
        }

        public DDZPokerImage(Poker p)
        {
            Poker = p;

            this.BackgroundImage = Poker.BackImage;

            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;

            InitializeComponent();
        }

        public void ShowPoker()
        {
            this.BackgroundImage = Poker.ForeImage;

            this.Show();

        }

        public DDZPokerImage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ChangePoker(Poker p)
        {
            this.Poker = p;
            
            ShowPoker();        
        }
       
        
    }
}
