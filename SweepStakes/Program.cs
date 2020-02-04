using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        string name = "powerball";
        static void Main(string[] args)
        {
            Sweepstakes sweepstakes = new Sweepstakes("powerball");



            

            sweepstakes.RegisterContestant(new Contestant("david", "steinhafel", "jj@gmail.com", 445));
            sweepstakes.RegisterContestant(new Contestant("charlie", "sather", "dingus@gmail.com", 446));

            
            
            sweepstakes.Notify(sweepstakes.PickWinner());
            Console.ReadLine();
        }
    }
}
