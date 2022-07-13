using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp
{
    public  class Vehicle
    {
        protected int _capacity;
        protected int _numPassengers;
        
        
        
        //private readonly string _speed;
        public int NumOfPassengers { get; set; }
        public int Position { get; protected set; }

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
