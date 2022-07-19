using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp
{
    public class Camera : IShootable
    {
        private string _brand;

        public int DamageDealt { get; set; } = 0;

        public Camera(string brand)
        {
            _brand = brand;
        }

        public string Shoot()
        {
            return $"{_brand} camera to take picture";
        }
        public string ToString()
        {
            return $"Camera brand is {_brand}";
        }
        public int Damage()
        {
            return DamageDealt;
        }
    }
}
