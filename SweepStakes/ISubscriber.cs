using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public interface ISubscriber
    {
        string firstName { get; }
        string lastName { get; }
        string email { get; }
        int registrationNumber { get; }
        void Notify(ISubscriber subscriber);
    }
}
