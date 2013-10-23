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
       

        public static void OrderPoker(List<DDZPokerImage> list)
        {
            DDZPokerImage mpi = list[0];
            int ms = mpi.Poker.Size;
            Poker temp;
            int j = 0;

            for (int i = 1; i < list.Count; i++)
            {
                j = i-1;
                while (j >= 0)
                {
                    if (list[i].Poker.Size < list[j].Poker.Size)
                    {                        
                        temp = list[j].Poker;
                        list[j].ChangePoker(list[i].Poker);
                        list[i].ChangePoker(temp);                  
                    }
                    j--;
                }                
                
            }
         
           
        }
    }
}
