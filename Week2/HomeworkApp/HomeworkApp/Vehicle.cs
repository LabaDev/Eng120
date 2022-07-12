using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp
{
    public  class Vehicle
    {
        private int _capacity;
        private int _numPassengers;
        
        
        
        //private readonly string _speed;
        public int NumOfPassengers
        {
            get { return _numPassengers; }
            set { _numPassengers = ((_numPassengers < 0) || (value > _capacity)) ? throw new ArgumentException() : _numPassengers; }
        }
        public int Position { get; private set; }

        public int Speed { get; init; }


        public string Move()
        {
            Position += Speed;
            return "Moving along";
        }

        public string Move(int times)
        {
            Position +=  Speed * times;
            return $"Moving along {times} times";
        }

        public Vehicle()
        {
            Speed = 10;
            
            
        }

        public Vehicle(int capacity, int speed = 10)
        {
            _capacity = capacity;
            Speed = speed;
            //Position = speed;
            

            
        }
    }

}
