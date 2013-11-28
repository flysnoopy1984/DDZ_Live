using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DDZProj.Core
{
    public class PlayerElementCollection : ConfigurationElementCollection
    {
        protected override ConfigurationElement CreateNewElement()
        {
            return new PlayerElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((PlayerElement)element).PlayerName;
        }

        public PlayerElement this[int i]
        {

            get
            {

                return BaseGet(i) as PlayerElement;

            }

        }





    }
}
