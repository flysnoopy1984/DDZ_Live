using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DDZEntity;
using DDZCommon;


namespace DDZInterface
{
    public class PokerData: BaseInterface
    {
        private List<Poker> _BossPoker;
        private Dictionary<AreaPos, List<Poker>> _PokerInfo;
        public Dictionary<AreaPos, List<Poker>> GetPokerInfo()
        {
            try
            {
                if (_PokerInfo!=null) return _PokerInfo;
                _PokerInfo = new Dictionary<AreaPos, List<Poker>>();
                _BossPoker = new List<Poker>();

                int[] datas = Util.GetRandomSequence2(1, 55);
                int i;
                Poker p;
                for (i = 0; i < 3; i++)
                {
                    p = new Poker(datas[i]);
                    _BossPoker.Add(p);
                }

                List<Poker> list = new List<Poker>();
                int j = 1;
                AreaPos ap = AreaPos.left;
                _PokerInfo.Add(ap, list);
                for(i=3;i<datas.Length;i++,j++)
                {
                    int no = datas[i];
                    if (j > 17)
                    {
                       
                        j = 1;
                        ap++;
                        list = new List<Poker>();
                        _PokerInfo.Add(ap, list);
                    }
                    p= new Poker(no);
                    list.Add(p);                    
                }

                
            }
            catch
            {
            }

            return _PokerInfo;
        }

        public List<Poker> Get3DiZhuPoker()
        {
            if (_BossPoker == null)
                this.GetPokerInfo();
            return _BossPoker;
        }

        public List<Poker> GetPostPoker()
        {
            return null;
        }


    }
}
