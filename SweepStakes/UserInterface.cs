using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public static class UserInterface
    {
        public static string GetUserInput(string prompt)
        {
            prompt = Console.ReadLine();
            return prompt;
        }
        public static string GetUserName()
        {
            Console.WriteLine("Please Enter Your First Name");
            return GetUserInput("");
        }
        public static string GetUserLastName()
        {
            Console.WriteLine("Please Enter Your Last Name");
            return GetUserInput("");
        }
        public static string GetUserEmail()
        {
            Console.WriteLine("Please Enter Your Email Address");
            while (!GetUserInput("").Contains("@"))
            {
                return Console.WriteLine("Invalid Email! Please Try Again!");
            }
        }
    }
