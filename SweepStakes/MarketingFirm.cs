using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class MarketingFirm 
    {
        ISweepstakesManager _manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            _manager = manager;
        }
        public void CreateSweepstake()
        {
            SweepStakes sweepStakes1 = new SweepStakes(UserInterface.GetUserInput());
        }
    }
}
