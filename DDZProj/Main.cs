using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DDZProj.Core;
using System.Threading;
using System.Media;

namespace DDZProj
{
    public partial class Main : Form
    {
        private PictureBox[] pokerImages;//一副牌的图形
        private Poker[] Pokers;   //一副牌的对象
        private Thread th_Dealt;  //发牌线程
        private Thread th_PostCard;   //出牌线程
        private SoundPlayer SoundGive;//出牌声音

        int[] datas = { 1, 2, 3, 4, 5, 6, 7, 8, 11, 21, 23, 12, 32, 45, 27, 52, 32 };
       
        public Main()
        {
            InitializeComponent();
            SysConfiguration.Init();
            CheckForIllegalCrossThreadCalls = false;//为false可以跨线程调用windows控件
        }

        private void Test()
        {
            NewLoad();
           
            
            for (int i = 0; i < 17; i++)
            {
                Poker p = new Poker(datas[i]);
                p.Index = i;
                Pokers[i] = p;
            }
            newPaiImage();
        }

        private void NewLoad()
        {
            SoundGive = new SoundPlayer(global::DDZProj.Properties.Resources.give);

            Pokers = new Poker[17];
            pokerImages = new PictureBox[17];

        }

        #region NEW出54张牌
        private void newPokers()
        {
         
        }
        #endregion

        #region NEW出牌的图形
        private void newPaiImage()
        {
            for (int i = 0; i < Pokers.Length; i++)
            {
                pokerImages[Pokers[i].Index] = new PictureBox();
                pokerImages[Pokers[i].Index].BackgroundImage = Pokers[Pokers[i].Index].ForeImage;
                pokerImages[Pokers[i].Index].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
              // pokerImages[Pokers[i].Index].Hide();
                this.Controls.Add(pokerImages[Pokers[i].Index]);           
                
            }
        }
        #endregion

        #region 开始发牌
        void Dealt()
        {
            for (int i = 0; i < pokerImages.Length; i++)
            {
                pokerImages[i].Show();
                pokerImages[i].SetBounds(i * SysConfiguration.PokerXSep, 100, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);               
                pokerImages[i].BringToFront();
                SoundGive.Play();
                Thread.Sleep(100);
            }  
        }
        #endregion

        #region 出牌
        void PostCard()
        {
            Random r = new Random();
            int i =r.Next(0, pokerImages.Length-1);

            PictureBox pi = pokerImages[i];
            
            pi.SetBounds(500, 500, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight); 

        }

        void PostCardAction()
        {
            th_PostCard = new Thread(new ThreadStart(PostCard));
            th_PostCard.Start();
            th_PostCard.Join();
        }

        #endregion

        #region 排序排
        /// <summary>
        /// 
        /// </summary>
        /// <param name="bpos">从第几张开始排序</param>
        void OrderCard(int bpos)
        {
            for (int i = 0; i < pokerImages.Length; i++)
            {
                
            }
        }
        #endregion

        private void bn_Begin_Click(object sender, EventArgs e)
        {
            Test();
            th_Dealt = new Thread(new ThreadStart(Dealt));
            th_Dealt.Start();
            th_Dealt.Join();
        }

        private void bn_Post_Click(object sender, EventArgs e)
        {
            PostCardAction();
        }
    }
}
