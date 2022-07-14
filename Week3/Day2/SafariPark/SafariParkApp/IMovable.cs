using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    interface IMovable
    {
        public string Move()
        {
            return  "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }
    }
}
