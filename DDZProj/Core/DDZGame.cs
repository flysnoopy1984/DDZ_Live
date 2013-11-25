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
using AnimatorNS;

namespace DDZProj.Core
{
    public class DDZGame
    {
        private Thread th_Dealt, th_CallBoss,th_PostPokerListen,th_Game;  //发牌线程     
        private Dictionary<int,DDZPokerImage> _PiList;
        private SoundPlayer _SoundGive;//出牌声音
        private Main _MainForm;
        private AreaCtrl _AreaT, _AreaL, _AreaR,_CurrentArea,_BossArea;
        private AreaPoker _AreaPoker;
        private AreaBossPoker _AreaBossPoker;
        private AreaScore _AreaScore;
        private Stack<AreaCtrl> _CallStock;
        private int _MaxCallBossScore;

        private Queue<AreaCtrl> _PostQueue;
        private Stack<List<Poker>> _PostPokerStack;
        private GameState _GameState = GameState.End;
        
        private AutoResetEvent _mResetEventCallBoss;
        private AutoResetEvent _mResetEventPoking;
        
    

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
            return _CurrentArea;
        }

        public AreaCtrl GetBossArea()
        {
            return _BossArea;
        }

        public GameState GetGameState()
        {
            return _GameState;
        }

        public AreaBossPoker GetAreaBossPoker()
        {
            return _AreaBossPoker;
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
             
                pi.SetBounds(SysConfiguration.ScreenWidth / 2, SysConfiguration.ScreenHeight *3 / 2, SysConfiguration.PokerWidth, SysConfiguration.PokerHeight);
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
            _AreaBossPoker = new AreaBossPoker(_MainForm);
            _AreaScore = new AreaScore(_MainForm);
        }
        #endregion

        #region 重置游戏
        public void ResetGame()
        {
            _AreaT.ResetArea();
            _AreaL.ResetArea();
            _AreaR.ResetArea();
            _AreaBossPoker.ResetArea();
            _AreaPoker.ResetArea();

            foreach (Control ctrl in _MainForm.Controls)
            {
                DDZPokerImage pi = ctrl as DDZPokerImage;
                if (pi != null)
                {
                    _MainForm.Controls.Remove(ctrl);
                }
            }

            _PokerData.ResetData();

            _GameState = GameState.End;
        }
        #endregion 

        #region 开始发牌
        public void StartDealt()
        {
            _GameState = GameState.Dealting;

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
            _AreaBossPoker.SetBossPoker(_PokerData.Get3DiZhuPoker());

            _GameState = GameState.DealtComplete;
        }

      
        #endregion

        #region 叫地主
        public void StartCallBoss()
        {            
            //设置型号量
            _mResetEventCallBoss = new AutoResetEvent(false);
         
            //设置当前最大叫分
            _MaxCallBossScore = 0;

            _GameState = GameState.CallBossing;

            _AreaR.ResetCallBoss();
            _AreaT.ResetCallBoss();
            _AreaL.ResetCallBoss();

            _CallStock = new Stack<AreaCtrl>();
            _CallStock.Push(_AreaR);
            _CallStock.Push(_AreaT);
            _CallStock.Push(_AreaL);
            _BossArea = null;

            th_CallBoss = new Thread(new ThreadStart(DoCallBoss));         
            th_CallBoss.Start();

         
        }

        void DoCallBoss()
        {
            while (this._GameState == GameState.CallBossing)
            {             
                if (_CallStock.Count == 0) 
                    break;        

                _CurrentArea = _CallStock.Pop();
               
                _CurrentArea.Counting();

                _mResetEventCallBoss.WaitOne();                

                _CurrentArea.StopCounting();

                if (_CurrentArea.CallScore == 3)
                {
                    _BossArea = _CurrentArea;
                 
                    _CallStock.Clear();
                    break;
                }      
                             
            }
            //没有人叫分           
            if (_MaxCallBossScore == 0)
            {
                //End Game
            }
            //没有人叫3分,但有人叫分
            if (_BossArea == null)
            {
                CaculateWhoIsBoss();
            }

            //设置并显示Boss头像和叫分
            if (_BossArea != null)
            {
                //Boss 头像
                _BossArea.SetBossAndChangePortrait(_MaxCallBossScore);
                //BOss 3张排
                _BossArea.SetBossPoker(_AreaBossPoker.GetBossPokerImageList());

                _AreaBossPoker.ResetArea();

                _BossArea.AddPokerToRemain(_PokerData.Get3DiZhuPoker());

            }

            //设置游戏状态
            _GameState = GameState.CallBossComplete;
        }

        public void PassCallBoss()
        {
            if (_CurrentArea!=null)
            {
               // _CurrentArea.StopCounting();
                this._AreaPoker.PostInfo(_CurrentArea.GetAreaPos(), "Pass");
                if (!_mResetEventCallBoss.Set())
                {
                    MessageBox.Show("Error");
                }
            }

        }

        public void EndCallBoss()
        {
            //_mResetEventCallBoss.Set();
        }

        private void CaculateWhoIsBoss()
        {
            if (_MaxCallBossScore == _AreaL.CallScore)
            {
                this._BossArea = _AreaL;
            }
            if (_MaxCallBossScore == _AreaL.CallScore)
            {
                this._BossArea = _AreaL;
            }
            if (_MaxCallBossScore == _AreaL.CallScore)
            {
                this._BossArea = _AreaL;
            }            
        }

        public void ShowCallBoss()
        {

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

            _AreaPoker.ClearInfo(); // 清除叫地主的分数;

            _GameState = GameState.Poking; // 游戏状态置为开始;

            _mResetEventPoking = new AutoResetEvent(false); //初始化信号量
            /* 初始化玩家队列 */
            _PostQueue = new Queue<AreaCtrl>();
            //地主先出牌，先进入队列
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

            th_PostPokerListen = new Thread(new ThreadStart(ListenPostPoker));
            th_PostPokerListen.Start();
        }

        void Gaming()
        {
            while (_GameState == GameState.Poking)
            {
                _CurrentArea = _PostQueue.Dequeue();

                _PostQueue.Enqueue(_CurrentArea);

                _CurrentArea.Counting();

                _mResetEventPoking.WaitOne();

                _CurrentArea.StopCounting();
            }
        }

        public void PassPoking()
        {
            if (_CurrentArea != null)
            {
              //  _CurrentArea.StopCounting();
                this._AreaPoker.PostInfo(_CurrentArea.GetAreaPos(), "Pass");
                if (!_mResetEventPoking.Set())
                {
                    MessageBox.Show("Error");
                } 
            }

        }

     
        #endregion

        #region 游戏结束
        public void EndGame()
        {
            _GameState = GameState.End;

            this.ResetGame();


            //_MainForm.ShowEndForm(this._AreaScore);
            _MainForm.ShowEndForm();
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
                if (s > _MaxCallBossScore)
                    _MaxCallBossScore = s;
                else
                    //叫分小于等于上个玩家，非法！
                    return;

                _CurrentArea.CallScore = s;
                
                _AreaPoker.PostScore(_CurrentArea.GetAreaPos(), s);
                _mResetEventCallBoss.Set();
            }
        }

        public void TestPostPoker(List<Poker> pList)
        {
            if (_PostPokerStack == null) return;
            if (pList.Count == 0) return;

            _PostPokerStack.Push(pList);          
        }

        public void TestShowImageEffert()
        {
            
        }
        #endregion

        #region 接口数据监听

        void ListenPostPoker()
        {
            _PostPokerStack = new Stack<List<Poker>>();
            List<Poker> pList = null;
            while (_GameState == GameState.Poking)
            {
                if (_PostPokerStack.Count > 0)
                {
                    pList = _PostPokerStack.Pop();
                    if (pList != null)
                    {                      
                        _CurrentArea.PostPoker(pList);

                        AreaCtrl.OrderPoker(_CurrentArea.RemainPokerList);

                        _AreaPoker.PostPoker(_CurrentArea.GetAreaPos(), _CurrentArea.PostPokerList);                       

                        if (!_mResetEventPoking.Set())
                        {
                            MessageBox.Show("Error");
                        } 
                    }
                }
            }
        }
        #endregion

        #region 接口按钮
        public void Button_Begin_Action()
        {
            if (_GameState == GameState.End)
            {
                StartDealt();
            }
            else if (_GameState == GameState.DealtComplete)
            {
                StartCallBoss();
            }
            else if (_GameState == GameState.CallBossComplete)
            {
                if (this._BossArea != null)
                {
                    StartGame();
                }
            }            
        }

        public void Button_Pass_Action()
        {
            if (_GameState == GameState.CallBossing)
            {
                PassCallBoss();
            }
            else if (_GameState == GameState.Poking)
            {
                PassPoking();
            }
        }

        public void Button_NumberAction()
        {

        }

        public void Button_NumberOne()
        {

        }

        public void Button_NumberTwo()
        {
            
        }

        public void Button_NumberThree()
        {

        }

        public void Button_ScoreAction(int s)
        {
            if (_GameState == GameState.CallBossing)
            {
                if (_CurrentArea != null)
                {
                    if (s > _MaxCallBossScore)
                        _MaxCallBossScore = s;
                    else
                        //叫分小于等于上个玩家，非法！
                        return;

                    _CurrentArea.CallScore = s;

                    _AreaPoker.PostScore(_CurrentArea.GetAreaPos(), s);
                    _mResetEventCallBoss.Set();
                }
            }
        }
        public void Button_ScoreOne()
        {
            Button_ScoreAction(1);
        }

        public void Button_ScoreTwo()
        {
            Button_ScoreAction(2);
        }

        public void Button_ScoreThree()
        {
            Button_ScoreAction(3);
        }


        #endregion
    }
}
