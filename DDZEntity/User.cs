using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDZEntity
{
    public class User
    {
        private string _NickName;

        public string NickName
        {
            get { return _NickName; }
            set { _NickName = value; }
        }

        public User(string NickName)
        {
            _NickName = NickName;
        }
    }
}
