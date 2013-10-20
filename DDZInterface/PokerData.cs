using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDZEntity;
using DDZEntity.IM;

namespace DDZInterface
{
    public class PokerData: BaseInterface
    {
        private Dictionary<AreaPos, List<DPoker>> _PokerInfo;
        public Dictionary<AreaPos, List<DPoker>> GetPokerInfo()
        {
            try
            {
                _PokerInfo = new Dictionary<AreaPos, List<DPoker>>();

            }
            catch
            {
            }

            return _PokerInfo;
        }
    }
}
