using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace DDZEntity
{
    public class Player
    {
        public string Name { get; set; }
        public AreaPos Location { get; set; }
        public string CurrentScore { get; set; }
        public string TotalScore { get; set; }
        public Image CurrentPortrait { get; set; }
        
    }
}
