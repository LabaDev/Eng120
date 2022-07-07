using System.Text;
namespace MoreDataTypesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string message = "I like trying different foods.";

            //message = "Actually I like to be lazy";
            //message = message.Insert(0, "Actually I like pie \n");

            //message = message.Insert(message.Length, " Actually I like pie\n");
            //Console.WriteLine(message);

            //string reminder = "Dont forget to wake up";

            //string completeMessage = String.Concat(message, reminder);
            //Console.WriteLine(completeMessage); 

            //Console.WriteLine(StringExercise("  C# list fundamentals "));

            //StringBuilder sb = new StringBuilder("Hello World");
            //Console.WriteLine(StringBuilderExercise("  C# list fundamentals "));

            #region String interpolation

            //string a = "A";
            //string b = "B";
            //string aAndB = a + b;
            //Console.WriteLine(aAndB);
            //aAndB = String.Concat(a, b);
            //Console.WriteLine(aAndB);

            //string[] arrayOfStrings = { "hello", "world" };
            //char[] arrayOfChars = { 'a', 'b', 'c', 'c' };
            //Console.WriteLine(String.Concat(arrayOfStrings));
            //Console.WriteLine(String.Concat(arrayOfChars));

            //string interpolatedString = $"Your blood type is {a} {b.ToLower()}.";
            //Console.WriteLine(interpolatedString);

            //int num1 = 2;
            //int num2 = 7;

            //string logOfNum1Num2 = $"The log to base {num1} of {num2} is {Math.Log(num2, num1):0.#####}";
            //Console.WriteLine(logOfNum1Num2);
            //string money = $"The change is {(num2 - num1):C}";
            //Console.WriteLine(money);

            #endregion

            #region String parsing

            ParsingString();

            #endregion

        }

        public static string StringExercise(string myString)
        {
            myString = myString.Trim();
            myString = myString.ToUpper();
            myString = myString.Replace('L', '*');
            myString = myString.Replace('T', '*');
            myString = myString.Remove(myString.IndexOf('N')+1);
            
            return myString;
        }

        public static string StringBuilderExercise(string myString)
        {
            string ucTrimmedString = myString.Trim().ToUpper();
            int nPos = ucTrimmedString.IndexOf('N');

            StringBuilder sb = new StringBuilder(ucTrimmedString);
            sb.Replace('L', '*').Replace('T', '*');
            sb.Remove(nPos + 1, sb.Length - nPos - 1);

            return sb.ToString();
        }

        public static void ParsingString()
        {
            Console.WriteLine("How many cars do you own?");
            string input = Console.ReadLine();

            //int numOfCars = Int32.Parse(input);
            
            var success = Int32.TryParse(input, out int numOfCars);

            Console.WriteLine(numOfCars);
        }
    }
}