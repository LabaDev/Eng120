namespace FizzBuzzApp
{
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    Console.WriteLine(FizzBuzz(1));
        //    return;
        //}

        public static string FizzBuzz(int n)
        {
            string answer = "";
            for (int i = 1; i <= n; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    answer += "FizzBuzz ";
                else if (i % 3 == 0)
                    answer += "Fizz ";
                else if (i % 5 == 0)
                    answer += "Buzz ";
                else
                    answer += i + " ";
            }
               

            return answer.Trim();
        }
    }
}