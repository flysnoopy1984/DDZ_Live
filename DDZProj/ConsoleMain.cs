using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZEntity;
using DDZProj.Core;
using AnimatorNS;

namespace DDZProj
{
    public partial class bn_3n : Form
    {
        private Main _mainForm;
        private List<Poker> postPokerList
        {
            get;
            set;
        }
        
        public bn_3n()
        {
            InitializeComponent();
        }

        public bn_3n(Main mainForm)
        {
            _mainForm = mainForm;

            postPokerList = new List<Poker>();

            InitializeComponent();
        }

        private void Bn_Begin_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.Button_Begin_Action();
        }

        private void bn_Reset_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.ResetGame();
        }

        private void bn_CallBoss_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.StartCallBoss();
        }

        private void bn_One_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.Button_ScoreAction(1);
        }

        private void bn_Two_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.Button_ScoreAction(2);
        }

        private void bn_Three_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.Button_ScoreAction(3);
        }

        private void bn_APost_Click(object sender, EventArgs e)
        {
            FillList(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.left),this.lb_A);
        }

        private void bn_PostB_Click(object sender, EventArgs e)
        {
            FillList(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.top),this.lb_B);
        }

        private void bn_PostC_Click(object sender, EventArgs e)
        {
            FillList(_mainForm.CurrentGame.GetAreaCtrl(DDZEntity.AreaPos.right),this.lb_C);
        }

        private void FillList(AreaCtrl area,ListBox lb)
        {           
            if (area.RemainPokerList != null)
            {
                lb.Items.Clear();
                foreach (DDZPokerImage pi in area.RemainPokerList)
                {
                    string name = "";
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
                        name += "-" + Convert.ToString(pi.Poker.Size) + "-"+pi.Poker.No;
                    else
                        name += "-"+pi.Poker.No;

                    lb.Items.Add(name);
                 
                }
            }
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
                        name += "-" + Convert.ToString(pi.Poker.Size) + "-" + pi.Poker.No;
                    else
                        name += "-" + pi.Poker.No;              
                   

                    Button b = new Button();
                    b.Text = name;
                    b.Size = new Size(name.Length * 8, 20);

                    if (bx+b.Width > p_pokerbutton.Width)
                    {
                        bx = 0;
                        by += b.Height+5;
                    }
                    b.Tag = pi.Poker;
                    b.Location = new Point(bx,by);
                    bx += b.Width;
                    b.Click += delegate
                    {
                        this.tb_pokerInfo.Text += b.Text + "   ";
                       
                        postPokerList.Add((Poker)b.Tag);
                    };
                  
                    
                    this.p_pokerbutton.Controls.Add(b);
                }
            }
            
        }

        private void bn_ChangePoker_Click(object sender, EventArgs e)
        {
            AreaCtrl ac =  _mainForm.CurrentGame.GetAreaCtrl(AreaPos.top);
            AreaCtrl.OrderPoker(ac.RemainPokerList);
            ac.Refresh();
        }

        private void bn_Start_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.StartGame();
        }

        private void bn_PostPoker_Click(object sender, EventArgs e)
        {
            List<Poker> newpost = new List<Poker>();
            newpost.AddRange(postPokerList);

            _mainForm.CurrentGame.TestPostPoker(newpost);
            postPokerList.Clear();
        }

        private void bn_CurrentArea_Click(object sender, EventArgs e)
        {
      
            AreaCtrl ac = _mainForm.CurrentGame.TestCurrentArea();
            FillPokerInfo(ac);
        }

        private void bn_End_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.EndGame();
        }

        private void bn_Pass_Click(object sender, EventArgs e)
        {
            _mainForm.CurrentGame.Button_Pass_Action();
        }

        private void bn_Boom_Click(object sender, EventArgs e)
        {
            Image img = DDZCommon.ResManager.GetImageRes("bomb");

            Rectangle r = new Rectangle(img.Width/4, 0, img.Width/4, img.Height);
            Graphics g = this.CreateGraphics();
            g.DrawImage(img,600,100,r,GraphicsUnit.Pixel);
            
        }

        private void bn_Test_Click(object sender, EventArgs e)
        {
            Image MyBitmap = ImageHandler.GetBossPortrait();
            pb_Image.Image = MyBitmap;
            pb_Image.Hide();
      
            animator1.DefaultAnimation = Animation.Mosaic;
            animator1.Show(pb_Image);

        }

        private void bn_1n_Click(object sender, EventArgs e)
        {

        }

        private void bn_2n_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

     

      


    }
}