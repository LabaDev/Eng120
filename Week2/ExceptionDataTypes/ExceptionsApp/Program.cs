namespace ExceptionsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var theBeatles = new string[] { "John", "Paul", "Ringo", "George" };
            //theBeatles[4] = "Yoko";
            //string text;
            //string fileName = "Wonderwall.txt";
            //try
            //{
            //    text = File.ReadAllText(fileName);
            //    Console.Write(text);
            //}
            //catch (FileNotFoundException except)
            //{
            //    Console.WriteLine("Sorry can't find " + fileName);
            //    Console.WriteLine("Error: " + except);


            //}

            

            try
            {
                Console.WriteLine("Charlie received 88: " + Grade(88));
                Console.WriteLine("Thomasreceived -100: " + Grade(-100));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());

            }
            finally
            {
                Console.WriteLine("I will always execute");
            }
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
            {
                throw new ArgumentOutOfRangeException("\nMark: " + mark + "\nAllowed Range: 0 - 100");
            }
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}