using System;
using System.Collections.Generic;
using System;
namespace OperatorsApp
{
    public class Methods
    {
        

        public static int GetStones(int totalPounds)
        {
            if (totalPounds < 0)
                throw new ArgumentOutOfRangeException("The value of totalPound is negative");
            return totalPounds / 14;
        }

        public static int GetPounds(int totalPounds)
        {
            if (totalPounds < 0)
                throw new ArgumentOutOfRangeException("The value of totalPound is negative");
            return totalPounds % 14;
            
        }
    }
}
