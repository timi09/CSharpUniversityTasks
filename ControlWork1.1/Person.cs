using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork1._1
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateofBirth { get; set; }

        public Person(string firstName, string lastName, DateTime dateofBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateofBirth = dateofBirth;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {DateofBirth.ToString("dd.MM.yyyy")}";
        }
    }
}
