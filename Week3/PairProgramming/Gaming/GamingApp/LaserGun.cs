using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingApp
{
    public class LaserGun : Weapon ,IShootable
    {
        

        public override int DamageDealt { get; set; } = 20;

        public LaserGun(string brand) : base(brand)
        {

        }

        public override string Shoot()
        {

            return $"{base.Shoot()}";
        }
        public int Damage()
        {
            return DamageDealt;
        }
    }
}
