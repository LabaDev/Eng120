using System;

namespace DataTypes_Lib
{
    public class TypeConversion
    {
        public static short UIntToShort(uint num)
        {
            if (num > short.MaxValue)
                throw new OverflowException();
            return (short)num;
        }

        public static long FloatToLong(float num)
        {
            if ((num - Math.Floor(num)) > 0)
                num--;
            else if ((num - Math.Floor(num)) > 0)
                num++;
            return (long)num;
        }
    }
}
