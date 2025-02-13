﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeração_e_Composição
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateOnly BirthDate { get; set; }

        public Client(string name, string email, DateOnly birthDate)
        {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public override string ToString()
        {
            return Name + " " + BirthDate.ToString("(dd/MM/yyyy)") + " - " + Email;
        }
    }
}
