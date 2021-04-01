using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProjectPartA
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public Trainer(string aFirstName, string aLastName, string aSubject)
        {
            FirstName = aFirstName;
            LastName = aLastName;
            Subject = aSubject;
        }
    }
}
