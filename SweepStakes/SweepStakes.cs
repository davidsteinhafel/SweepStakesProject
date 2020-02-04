
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private Dictionary<int, ISubscriber> contestants;
        private string name;
        public string Name;
        


        public Sweepstakes(string name)
        {
            this.name = name;
            contestants = new Dictionary<int, ISubscriber>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public ISubscriber PickWinner()
        {

            Random rand = new Random();
            int random = rand.Next(contestants.Count);
            ISubscriber winner = contestants[random];
            Winner victor = new Winner(winner.firstName, winner.lastName, winner.email, winner.registrationNumber);
            contestants[random] = victor;
            return winner;


        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1} {2} {3}", contestant.firstName, contestant.lastName, contestant.registrationNumber, contestant.email);
        }
        public void Notify(ISubscriber sub)
        {
            foreach (ISubscriber subscriber in contestants.Values)
            {
                subscriber.Notify(sub);
            }
        }
    }

}
