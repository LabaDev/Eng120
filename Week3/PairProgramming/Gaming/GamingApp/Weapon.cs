using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp
{
    public abstract class Weapon : IShootable
    {
        private string _brand;

        public virtual int DamageDealt { get; set; }
        public Weapon(string brand)
        {
            _brand = brand;
        }

        public virtual string Shoot()
        {
            return $"{_brand}";
        }
        public override string ToString()
        {
            return base.ToString() + $"{_brand}";  
        }

        public int Damage()
        {
            return 0;
        }
    }
}
