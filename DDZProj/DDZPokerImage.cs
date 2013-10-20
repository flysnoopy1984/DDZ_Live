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


        public DDZPokerImage(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
