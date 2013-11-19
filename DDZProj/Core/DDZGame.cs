using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using DDZEntity;
using DDZInterface;
using System.Collections;

namespace DDZProj.Core
{
    public class DDZGame
    {
        private Thread th_Dealt, th_CallBoss,th_Listen,th_Game;  //发牌线程     
        private Dictionary<int,DDZPokerImage> _PiList;
        private SoundPlayer _SoundGive;//出牌声音
        private Main _MainForm;
        private AreaCtrl _AreaT, _AreaL, _AreaR,_CurrentArea,_BossArea;
        private AreaPoker _AreaPoker;
        private Stack<AreaCtrl> _CallStock;
        private Queue<AreaCtrl> _PostQueue;
        private int _GameState = -1;
        private ManualResetEvent _mResetEventCallBoss;
    

        /*接口数据*/
        private PokerData _PokerData;


        #region 属性
        public Dictionary<int,DDZPokerImage> PokerImageList
        {
            get { return _PiList; }
        }

        public AreaPoker GetAreaPoker()
        {
            return _AreaPoker;
        }

        public AreaCtrl GetAreaCtrl(AreaPos pos)
        {
          
            switch (pos)
            {
                case AreaPos.top:
                    return _AreaT;
                case AreaPos.left:
                    return _AreaL;
                case AreaPos.right:
                    return _AreaR;
            }
            return null;
        }

        public AreaCtrl GetCurrentArea()
        {
            /*
            if (_AreaT.IsCurrent)
                return _AreaT;
            if (_AreaR.IsCurrent)
                return _AreaR;
            if (_AreaL.IsCurrent)
                return _AreaL;
            return null;
             */
            return _CurrentArea;
        }

        public AreaCtrl GetBossArea()
        {
            return _BossArea;
        }

        public int GetGameState()
        {
            return _GameState;
        }
        #endregion

        public DDZGame(Main f)
        {
            _SoundGive = new SoundPlayer(global::DDZProj.Properties.Resources.give);
            _PiList = new Dictionary<int, DDZPokerImage>();
            _PokerData = new PokerData();
            _MainForm = f;
        }

        #region 初始化
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

                DDZPokerImage pi = new DDZPokerImage(p);               
             
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
        #endregion

        #region 开始发牌
        public void StartDealt()
        {
            th_Dealt = new Thread(new ThreadStart(Dealt));
            th_Dealt.Start();
          //  th_Dealt.Join();
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
                Poker p =list[i];
                DDZPokerImage pi = PokerImageList[p.No];
                pi.ShowPoker();
                pi.SetBounds((i + 1) *pi.Width, SysConfiguration.TopSpec, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
                pi.BringToFront();
            }
          
        }
        #endregion

        #region 等待叫地主
        public void CallBoss()
        {
            //设置型号量
            _mResetEventCallBoss = new ManualResetEvent(false);

            _AreaR.Reset();
            _AreaT.Reset();
            _AreaL.Reset();

            _CallStock = new Stack<AreaCtrl>();
            _CallStock.Push(_AreaR);
            _CallStock.Push(_AreaT);
            _CallStock.Push(_AreaL);
            _BossArea = null;

           th_CallBoss = new Thread(new ThreadStart(DoCallBoss));         
           th_CallBoss.Start();

           th_Listen = new Thread(new ThreadStart(ListenCallBoss));
           th_Listen.Start();
        }

        void DoCallBoss()
        {        
            while (true)
            {             
                if (_CallStock.Count == 0) 
                    break;

                //if (_CurrentArea != null)
                //    _CurrentArea.IsCurrent = false;

                _CurrentArea = _CallStock.Pop();
               
                _CurrentArea.Counting();

                _mResetEventCallBoss.WaitOne();
             
                if (_CurrentArea.CallScore == 3)
                {
                    _BossArea = _CurrentArea;
                    _CurrentArea.IsCurrent = false;
                    _CallStock.Clear();
                    return;
                }
                else if (_CurrentArea.CallScore > 0)
                {
                    _CurrentArea.IsCurrent = false;
                    break;
                }
                             
            } 
            /* 非 3 分的计算 */
        }    
      
       
        #endregion

        #region 打牌
        public void StartGame()
        {
            if (_BossArea == null)
            {
                /*没有地主产生*/
                return;
            }

            _AreaPoker.ClearScore(); // 清除叫地主的分数;

            _GameState = 1; // 游戏状态置为开始;

            /* 初始化玩家队列 */
            _PostQueue = new Queue<AreaCtrl>();
            _PostQueue.Enqueue(_BossArea);
            switch (_BossArea.GetAreaPos())
            {
                case AreaPos.top:
                    _PostQueue.Enqueue(_AreaR);
                    _PostQueue.Enqueue(_AreaL);
                    break;
                case AreaPos.left:
                    _PostQueue.Enqueue(_AreaT);
                    _PostQueue.Enqueue(_AreaR);
                    break;
                case AreaPos.right:
                    _PostQueue.Enqueue(_AreaL);
                    _PostQueue.Enqueue(_AreaT);
                    break;
            }
            th_Game = new Thread(new ThreadStart(Gaming));
            th_Game.Start();
        }

        void Gaming()
        {
            while (_GameState>0)
            {                
                _CurrentArea = _PostQueue.Dequeue();
                _PostQueue.Enqueue(_CurrentArea);
                 _CurrentArea.Counting();

                 while (_CurrentArea.IsCurrent)
                 {
                     if (_GameState < 0)
                     {
                         _CurrentArea.IsCurrent = false;
                         break;
                     }
                     Thread.Sleep(20);
                 }  
                
            }
        }

        public void EndGame()
        {
            _GameState = -1;
        }
        #endregion

        #region 测试

        public AreaCtrl TestCurrentArea()
        {
            _CurrentArea = _AreaT;
            return _AreaT;
        }

        public void TestSetScore(int s)
        {
            if (_CurrentArea != null)
            {
                _CurrentArea.CallScore = s;
                
                _AreaPoker.PostScore(_CurrentArea.GetAreaPos(), s);
                _mResetEventCallBoss.Set();
            }
        }

        public void TestPostPoker(List<Poker> pList)
        {
            _CurrentArea.PostPoker(pList);

            AreaCtrl.OrderPoker(_CurrentArea.RemainPokerList);
            _AreaPoker.PostPoker(_CurrentArea.GetAreaPos(), _CurrentArea.PostPokerList);
        }

        public void TestShowImageEffert()
        {

        }
        #endregion

        #region 接口数据监听
        void ListenCallBoss()
        {

        }

        void ListenPostPoker()
        {
            
        }
        #endregion

      


    }
}
