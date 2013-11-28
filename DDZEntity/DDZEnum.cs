using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DDZEntity
{
    class DDZEnum
    {
    }

    public enum AreaPortrait
    {
        Boss,
        Farmer,
    }

    public enum GameState
    {
        New,
        Dealting,
        DealtComplete,
        CallBossing,
        CallBossComplete,
        Poking,
        End
    }

    public enum AreaPos
    {
        left = 1,
        top =2,       
        right =3,
    }
    public enum PokerColor
    {        
        spade =1,
        heart = 2,
        club = 3,      
        diamond = 4,
        Da = 5,
        Xiao = 6,
    }
}
