using Sweepstakes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Winner : Contestant
    {

        public Winner(string firstName, string lastName, string email, int registrationNumber) : base(firstName, lastName, email, registrationNumber)
        {
        }
        
        public override void Notify(ISubscriber subscriber)
        {
            Console.WriteLine("Congrats {0} {1} for winning our Sweepstakes!!!", firstName, lastName);
        }
    }
}
