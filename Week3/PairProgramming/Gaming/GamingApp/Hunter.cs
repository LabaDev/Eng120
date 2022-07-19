using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp
{
    public class Hunter : Person, IShootable
    {
        public int Health { get; set; } = 100;
        public IShootable Shooter { get; set; }
        public Hunter(string firstName, string lastName, IShootable shooter) : base(firstName, lastName)
        {
            Shooter = shooter;
        }

        public string Shoot()
        {
            return $"{FullName} has {Health} health and used {Shooter.Shoot()}";
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public int Damage()
        {
            return 0;
        }


    }
}
