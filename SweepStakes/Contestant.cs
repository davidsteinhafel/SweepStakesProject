
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Contestant : ISubscriber
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public int registrationNumber { get; set; }

        public Contestant(string firstName, string lastName, string email, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationNumber = registrationNumber;
        }

        public string Name;

        public virtual void Notify(ISubscriber subscriber)
        {
            Console.WriteLine("You didnt win!");
        }

        public void SetRegistrationNumber(int registration)
        {
            registrationNumber = registration;
        }
    }
}
