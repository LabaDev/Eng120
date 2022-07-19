using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        public int Age { get; set; }
        public string FullName => $"{_firstName} {_lastName}";

        public Person(string firstName, string lastName) 
         {
            _firstName = firstName;
            _lastName = lastName;
           
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
