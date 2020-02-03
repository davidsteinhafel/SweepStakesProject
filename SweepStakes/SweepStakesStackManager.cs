using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class SweepStakesStackManager : ISweepstakesManager
    {
        Stack<SweepStakes> stack = new Stack<SweepStakes>();
       public void InsertSweepStakes(SweepStakes sweepStakes)
        {
            stack.Push(sweepStakes);
        }
        public SweepStakes GetSweepstakes()
        {
            return stack.Pop();
        }
    }
}
