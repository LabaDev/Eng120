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

            //ParsingString();

            #endregion

            #region Arrays

            int[] arraysOfInts = new int[10];

            arraysOfInts[6] = 7;
            foreach (int n in arraysOfInts)
                Console.WriteLine(n);

            //1D arrays
            int[] Ints = { 1, 2, 3, 4, 5 };
            string sparta = "SpartaGlobal";
            var SpartaArray = sparta.ToCharArray();

            var greeting = "Hello, Hi, Hola, Hallo, Hej";
            var greetingArray = greeting.Split(',');



            //2D arrays
            int[,] grid = new int[2, 4];
            grid[0, 1] = 6;
            grid[1, 3] = 8;
            foreach (int n in grid)
                Console.WriteLine(n);

            string[,] chessBoard = {    { "pawn", "king"},
                                        {"blank", "blank" },
                                        {"enemy king", "enemy pawn" } };
            int lower1D = chessBoard.GetLowerBound(0);
            int lower2D = chessBoard.GetLowerBound(1);
            int upper1D = chessBoard.GetUpperBound(0);
            int upper2D = chessBoard.GetUpperBound(1);

            string theBoard = "";
            for (int i = lower1D; i <= upper1D; i++)
            {
                for (int j = lower2D; j <= upper2D; j++)
                    theBoard += $"{chessBoard[i, j]} is at {i} amd {j}\n";
            
            }
            Console.WriteLine(theBoard);

            //Jagged Arrays
            int[][] jaggedIntArray = new int[2][];
            jaggedIntArray[0] = new int[4];
            jaggedIntArray[1] = new int[2];

            jaggedIntArray[0][3] = 666;
            jaggedIntArray[0] = new int[] {1, 2, 3, 4};
            jaggedIntArray[1] = new int[] {5, 6};

            int jaggedupper1D = jaggedIntArray.GetUpperBound(0);

            foreach (int[] innerArray in jaggedIntArray)
            {
                foreach (int value in innerArray)
                    Console.WriteLine(value);
            }
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