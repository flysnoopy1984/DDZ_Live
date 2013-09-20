using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDZProj.Core
{
    public class Player
    {
        private User _User;
        public Player(User user)
        {
            _User = user;                 
        }

        public int Position { get; set; }

        public bool IsBoss { get; set; }


    }
}
