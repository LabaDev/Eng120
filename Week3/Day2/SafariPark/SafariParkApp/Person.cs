﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMovable
    {
        private string _firstName;
        private string _lastName;
        //public int Age { get; set; }
        private readonly string _hairColour;
        public const int numberOfFingers = 10;
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value < 0 ? throw new ArgumentException() : value; }
        }

        public Person(string firstName, string lastName, int age, string hairCol= "Yellow")
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
            _hairColour =hairCol;
        }
        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }
        public Person(string firstName)
        {
            _firstName = firstName;
        }

        public string Move()
        {
            return "Walking along";
        }

        public string FullName => $"{_firstName} {_lastName}";

        public void SetNames(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public override string ToString()
        {
            return $"{base.ToString()} Name {FullName} Age {Age}";
        }
    }
}
