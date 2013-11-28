using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DDZProj.Core
{
    public class PlayerSection : ConfigurationSection
    {
        [ConfigurationProperty("PlayerList")]
        public PlayerElementCollection PlayerList
        {

            get
            {

                return this["PlayerList"] as PlayerElementCollection;

            }

            set
            {

                this["PlayerList"] = value;

            }

        }

    }
}
