﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    class Contestant
    {
        string firstName;
        string lastName;
        string email;
        int registrationNumber;

        public Contestant(string firstName, string lastName, string email, int registrationNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.registrationNumber = registrationNumber;
        }
    }
}