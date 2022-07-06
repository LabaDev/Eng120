using System;

namespace DataTypes_Lib
{
    public static class Methods
    {
        // write a method to return the product of all numbers from 1 to n inclusive
        public static int Factorial(int n)
        {
            int answer = 1;
            for (int i = 1; i <=n; i++)
            {
                answer *= i;
            }
            return answer;
        }

        public static float Mult(float num1, float num2)
        {
            float number = num1* num2;
            return (float)Math.Round(number, 3);
            
        }
    }
}
