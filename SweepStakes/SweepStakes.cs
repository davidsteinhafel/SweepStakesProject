using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepStakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name;
        
        public SweepStakes(string name)
        {
            this.name = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            contestants.Add(contestants.Count, contestant);
        }
        public Contestant PickWinner()
        {
            Random rand = new Random();
            return contestants[rand.Next(contestants.Count)];
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("{0} {1} {2} {3}", contestant.firstName, contestant.lastName, contestant.registrationNumber, contestant.email);
        }
    }
    
}
