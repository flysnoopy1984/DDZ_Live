using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZEntity;

namespace DDZProj
{
    public partial class ConsoleMain : Form
    {
        private Main _mainForm;
        public ConsoleMain()
        {
            InitializeComponent();
        }

        public ConsoleMain(Main mainForm)
        {
            _mainForm = mainForm;

            InitializeComponent();
        }

        private void Bn_Begin_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.StartDealt();
        }

        private void bn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void bn_CallBoss_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.CallBoss();
        }

        private void bn_One_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(1);
        }

        private void bn_Two_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(2);
        }

        private void bn_Three_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.TestSetScore(3);
        }

        private void bn_APost_Click(object sender, EventArgs e)
        {
            FillPokerInfo(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.left));
        }

        private void bn_PostB_Click(object sender, EventArgs e)
        {
            FillPokerInfo(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.top));
        }

        private void bn_PostC_Click(object sender, EventArgs e)
        {
            FillPokerInfo(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.right));
        }

        private void FillPokerInfo(AreaCtrl area)
        {
            this.tb_pokerInfo.Text = "";
            int bx=0, by=0;
            this.p_pokerbutton.Controls.Clear();

            if (area.RemainPokerList != null)
            {
                foreach (DDZPokerImage pi in area.RemainPokerList)
                {
                    string name="";
                    switch (pi.Poker.Color)
                    {
                        case PokerColor.club:
                            name = "梅花";
                            break;
                        case PokerColor.diamond:
                            name = "方块";
                            break;
                        case PokerColor.heart:
                            name = "红心";
                            break;
                        case PokerColor.spade:
                            name = "黑桃";
                            break;
                        case PokerColor.Da:
                            name = "大怪";
                            break;
                        case PokerColor.Xiao:
                            name = "小怪";
                            break;
                    }
                    if (pi.Poker.Color != PokerColor.Xiao && pi.Poker.Color != PokerColor.Da)
                        name += "-" + Convert.ToString(pi.Poker.Size) + "  ";
                    else
                        name += "  ";
                 
                   

                    Button b = new Button();
                    b.Text = name;
                    b.Size = new Size(name.Length * 8, 20);

                    if (bx+b.Width > p_pokerbutton.Width)
                    {
                        bx = 0;
                        by += b.Height+5;
                    }
                  
                    b.Location = new Point(bx,by);
                    bx += b.Width;
                    b.Click += delegate
                    {
                        this.tb_pokerInfo.Text += b.Text + "   ";
                    };
                  
                    
                    this.p_pokerbutton.Controls.Add(b);
                }
            }
            
        }

        private void bn_ChangePoker_Click(object sender, EventArgs e)
        {
            AreaCtrl ac =  _mainForm.CurrentGame.GetAreaCtrl(AreaPos.top);
            DDZPokerImage.OrderPoker(ac.RemainPokerList);
            ac.Refresh();
        }

        private void bn_Start_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.StartGame();

        }

        private void bn_PostPoker_Click(object sender, EventArgs e)
        {
           // AreaCtrl ac = _mainForm.CurrentGame.GetAreaCtrl(AreaPos.top);

        }

        private void bn_CurrentArea_Click(object sender, EventArgs e)
        {
            AreaCtrl ac = _mainForm.CurrentGame.GetCurrentArea();
            if(ac!=null)
                FillPokerInfo(ac);
        }

        private void bn_End_Click(object sender, EventArgs e)
        {

        }

     

      


    }
}
