namespace FactorialApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }

        public static int Factorial(int x)
        {
            if (x > 12)
                throw new ArgumentException("Input of Factorial is too big");
            if (x > 12)
                throw new ArgumentException("Input cannot be negative numbers");
            if (x == 1)
                return 1;
            else
                return Factorial(x - 1) * x;
        }
    }
}