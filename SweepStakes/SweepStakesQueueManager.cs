using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesQueueManager : ISweepstakesManager
    {
        Queue<SweepStakes> queue = new Queue<SweepStakes>();
        public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            queue.Enqueue(sweepStakes);
        }
        public SweepStakes GetSweepStakes()
        {
            return new SweepStakes(UserInterface.GetUserInput())
        }
    }
}
