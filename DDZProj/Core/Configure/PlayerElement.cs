using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace DDZProj.Core
{
    public class PlayerElement : ConfigurationElement
    {
        // Create a "remoteOnly" attribute.
        [ConfigurationProperty("PlayerName", IsRequired = true)]
        public string PlayerName
        {
            get
            {
                return (string)this["PlayerName"];
            }
            set
            {
                this["PlayerName"] = value;
            }
        }

        // Create a "remoteOnly" attribute.
        [ConfigurationProperty("PlayerLocation", IsRequired = true)]
        public string PlayerLocation
        {
            get
            {
                return (string)this["PlayerLocation"];
            }
            set
            {
                this["PlayerLocation"] = value;
            }
        }
    }
}
