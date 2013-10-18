using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using DDZEntity;

namespace DDZProj.Core
{
    public class DDZGame
    {
        private Thread th_Dealt;  //发牌线程
        private List<PictureBox> _PBPokerList;//一副牌的图形
        private List<Poker> _PokerList;   //一副牌的对象
        private SoundPlayer _SoundGive;//出牌声音
        private Form _MainForm;
        private AreaCtrl _AreaA, _AreaB, _AreaC;


        public List<PictureBox> PictureBoxList
        {
            get { return _PBPokerList; }
        }

        public List<Poker> PokerList
        {
            get { return _PokerList; }
        }

        public DDZGame(Form f)
        {
            _SoundGive = new SoundPlayer(global::DDZProj.Properties.Resources.give);
            _PokerList = new List<Poker>();
            _PBPokerList = new List<PictureBox>();
            _MainForm = f;
        }

        public void InitGame()
        {            
            _PokerList.Clear();
            _PBPokerList.Clear();

            /*New牌信息初始化*/
            int j=3;
            PokerColor pc = PokerColor.club;
            for (int i = 1; i <= SysConfiguration.PokerCount; i++)
            {
                Poker p = null;
                if (j > 15)
                {
                    j = 3;
                    pc = pc + 1;
                }
                if (i == 1)
                    p = new Poker(i, 17, PokerColor.Da);
                else if (i == 2)
                    p = new Poker(i, 16, PokerColor.Xiao);               
                else 
                    p = new Poker(i,j,pc);

                _PokerList.Add(p);               
                j++;
            }
            /*New牌控件初始化*/
            for (int i = 0; i < SysConfiguration.PokerCount; i++)
            {
                PictureBox pb = new PictureBox();
                pb.Hide();
                pb.BackgroundImage = _PokerList[i].ForeImage;
             
                pb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               
                _PBPokerList.Add(pb);
                _MainForm.Controls.Add(pb);
            }

            //UI区域初始化
            this.InitArea();
        }

        /// <summary>
        /// 初始化桌面布局
        /// </summary>
        private void InitArea()
        {
            _AreaA = new AreaCtrl(AreaPos.top, _MainForm);
            _AreaB = new AreaCtrl(AreaPos.left, _MainForm);
            _AreaC = new AreaCtrl(AreaPos.right, _MainForm);

        }        

        #region 开始发牌
        public void StartDealt()
        {
            th_Dealt = new Thread(new ThreadStart(Dealt));
            th_Dealt.Start();
            th_Dealt.Join();
        }

        void Dealt()
        {
            List<PictureBox> list = this.PictureBoxList;
            int i = 1;
            foreach (PictureBox pb in list)
            {
                pb.Show();
                pb.SetBounds(i * SysConfiguration.PokerXSep, 100, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pb.BringToFront();
                i++;
                Thread.Sleep(100);
            }
        }
        #endregion
    }
}
