using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using DDZEntity;
using DDZInterface;

namespace DDZProj.Core
{
    public class DDZGame
    {
        private Thread th_Dealt;  //发牌线程     
        private List<DDZPokerImage> _PiList;
        private SoundPlayer _SoundGive;//出牌声音
        private Form _MainForm;
        private AreaCtrl _AreaT, _AreaL, _AreaR;
        private AreaPoker _AreaPoker;

        /*接口数据*/
        private PokerData _PokerData;


        public List<DDZPokerImage> PokerImageList
        {
            get { return _PiList; }
        }

   

        public DDZGame(Form f)
        {
            _SoundGive = new SoundPlayer(global::DDZProj.Properties.Resources.give);          
            _PiList = new List<DDZPokerImage>();
            _PokerData = new PokerData();
            _MainForm = f;
        }

        public void InitGame()
        {
            _PiList.Clear();
         

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

                DDZPokerImage pi = new DDZPokerImage();
                pi.Poker = p;
                pi.BackgroundImage = Poker.BackImage;
                pi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                pi.SetBounds(SysConfiguration.ScreenWidth / 2, SysConfiguration.ScreenHeight / 2, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pi.BringToFront();
                _MainForm.Controls.Add(pi);
                _PiList.Add(pi);
                j++;
            }
          
            //UI区域初始化
            this.InitArea();
        }

        /// <summary>
        /// 初始化桌面布局
        /// </summary>
        private void InitArea()
        {
            _AreaT = new AreaCtrl(AreaPos.top, _MainForm);
            _AreaL = new AreaCtrl(AreaPos.left, _MainForm);
            _AreaR = new AreaCtrl(AreaPos.right, _MainForm);
            _AreaPoker = new AreaPoker(_MainForm);
            


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
            int i = 1;
            Dictionary<AreaPos, List<Poker>> piInfo =  _PokerData.GetPokerInfo();
            _AreaT.ObtainPoker(piInfo[AreaPos.top]);
            _AreaL.ObtainPoker(piInfo[AreaPos.left]);
            _AreaR.ObtainPoker(piInfo[AreaPos.right]);

            
            for (i=0;i<17;i++)
            {
                _AreaL.ShowOne(i);
                _AreaT.ShowOne(i);
                _AreaR.ShowOne(i);
                
                Thread.Sleep(100);
            }
            ShowBossPoker();
        }

        private void ShowBossPoker()
        {
            List<Poker> list = _PokerData.Get3DiZhuPoker();
            for (int i = 0; i < list.Count; i++)
            {
                DDZPokerImage pi = new DDZPokerImage(list[i]);
                pi.Show();
                pi.BackgroundImage = pi.Poker.ForeImage;
                pi.SetBounds(i * SysConfiguration.PokerXSep, 100, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pi.BringToFront();
            }
          
        }
        #endregion
    }
}
