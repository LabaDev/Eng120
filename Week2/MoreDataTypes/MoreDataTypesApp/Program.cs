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

            Console.WriteLine(StringExercise("  C# list fundamentals "));

            StringBuilder sb = new StringBuilder("Hello World");
            Console.WriteLine(StringBuilderExercise("  C# list fundamentals "));
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
    }
}