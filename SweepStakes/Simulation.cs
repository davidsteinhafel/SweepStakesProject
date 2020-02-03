using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation 
    {
        public ISweepstakesManager CreateMarketingFirmWithManager(string input)
        {
            switch (input)
            {
                case ("Stack"):
                    return new SweepstakesStackManager();
                case ("Queue"):
                    return new SweepstakesQueueManager();
                default:
                    return null;
            }
        }
    }
}
