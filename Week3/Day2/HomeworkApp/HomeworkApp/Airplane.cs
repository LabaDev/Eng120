using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkApp
{
    public class Airplane : Vehicle 
    {
        private string _airline;

        public int Altitude { get; set; } = 0;

        public Airplane(int capacity) : base(capacity)
        {
            _capacity = capacity;
        }

        public Airplane(int capacity, int speed, string airline) : base(capacity, speed)
        {
            _capacity = capacity;
            Speed = speed;
            _airline = airline;
        }

        public void Ascend(int distance)
        {
            Altitude += distance;
        }

        public void Descend(int distance)
        {
            Altitude -= distance;
        }

        public string Move()
        {
            Position += Speed;
            return $"Moving along at an altitude of {Altitude} meters.";
        }
        public string Move(int times) 
        {
            if (times < 0)
                throw new ArgumentException("Cannot move backwards!");
            Position += Speed * times;
            return $"Moving along {times} times at an altitude of {Altitude} meters.";
        }


        public override string ToString()
        {
            return $"Thank you for flying JetsRUs: {base.ToString()} " +
                $"\ncapacity: {_capacity} " +
                $"\npassengers: {NumOfPassengers} " +
                $"\nspeed: {Speed}" +
                $"\nposition: {Position}" +
                $"\naltitude: {Altitude}";
        }
    }
}
