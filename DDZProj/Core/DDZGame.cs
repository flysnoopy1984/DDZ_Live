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
        private Thread th_Dealt, th_CallBoss,th_Listen;  //发牌线程     
        private Dictionary<int,DDZPokerImage> _PiList;
        private SoundPlayer _SoundGive;//出牌声音
        private Form _MainForm;
        private AreaCtrl _AreaT, _AreaL, _AreaR,_CurrentArea;
        private AreaPoker _AreaPoker;
        private Stack<AreaCtrl> _CallStock;

        /*接口数据*/
        private PokerData _PokerData;
        


        public Dictionary<int,DDZPokerImage> PokerImageList
        {
            get { return _PiList; }
        }

   

        public DDZGame(Form f)
        {
            _SoundGive = new SoundPlayer(global::DDZProj.Properties.Resources.give);
            _PiList = new Dictionary<int, DDZPokerImage>();
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
                _PiList.Add(i,pi);
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
            _AreaT.ObtainPoker(this,piInfo[AreaPos.top]);
            _AreaL.ObtainPoker(this,piInfo[AreaPos.left]);
            _AreaR.ObtainPoker(this,piInfo[AreaPos.right]);
            
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
                Poker p =list[i];
                DDZPokerImage pi = PokerImageList[p.No];
                pi.Show();
                pi.BackgroundImage = pi.Poker.ForeImage;
                pi.SetBounds(i * SysConfiguration.PokerXSep, 100, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pi.BringToFront();
            }
          
        }
        #endregion

        #region 等待叫地主
        public void CallingBoss()
        {
            _CallStock = new Stack<AreaCtrl>();
            _CallStock.Push(_AreaR);
            _CallStock.Push(_AreaT);
            _CallStock.Push(_AreaL);
         
                
           th_CallBoss = new Thread(new ThreadStart(CallScore));         
           th_CallBoss.Start();

           th_Listen = new Thread(new ThreadStart(ListenCallBoss));
           th_Listen.Start();
        }

        void CallScore()
        {        
            while (true)
            {
              
                if (_CallStock.Count == 0) 
                    break;
                _CurrentArea = _CallStock.Pop();
               
                _CurrentArea.CallingBoss();
                while (_CurrentArea.IsCurrent)
                {
                    Thread.Sleep(100);
                    if (_CurrentArea.CallScore == 3)
                    {
                        _CallStock.Clear();
                        return;
                    }
                }
                
            }         
        }

        void ListenCallBoss()
        {
           
        }

        public void TestSetScore(int s)
        {
            if (_CurrentArea != null)
                _CurrentArea.CallScore = s;
        }
        #endregion

    }
}
