using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDZEntity
{
    public class Player
    {
        public User User{get;set;}
        public Player(User user,int no)
        {
            User = user;

            PlayerNo = no;
        }

        public int PlayerNo{get;set;}

        public int Position { get; set; }

        public bool IsBoss { get; set; }

        
        private List<Poker> _RemainPoker;
        /// <summary>
        /// 剩余牌数
        /// </summary>
        public List<Poker> RemainPoker
        {
            get
            {
                if (_RemainPoker == null)              
                    _RemainPoker = new List<Poker>();               
                return _RemainPoker;
            }
            set { _RemainPoker = value; }
        }

        private List<Poker> _PostedPoker;
        /// <summary>
        /// 已出牌数
        /// </summary>
        public List<Poker> PostedPoker
        {
            get
            {
                if (_PostedPoker == null)
                    _PostedPoker = new List<Poker>();
                return _PostedPoker;
            }
            set { _PostedPoker = value; }
        }
        
    }
}
