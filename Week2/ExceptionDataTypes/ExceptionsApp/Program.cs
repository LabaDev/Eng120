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



            //try
            //{
            //    Console.WriteLine("Charlie received 88: " + Grade(88));
            //    Console.WriteLine("Thomasreceived -100: " + Grade(-100));
            //}
            //catch (ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.ToString());

            //}
            //finally
            //{
            //    Console.WriteLine("I will always execute");
            //}

            //int anInt = 3; // Explicitly typed
            //var vInt = 3; // Implicitly typed

            //var name = "Peter";
            //var isClean = true;
            //var letter = 'p';
            //var uLongNUm = 52ul;

            //var list = new List<string>();
            //List<string> list2 = new List<string>();

            //int x = 1;
            //long y = 2;

            //float sun = 0;
            //for (int i=0; i < 100_000; i++)
            //{
            //    sun += 2 / 5.0f;
            //}
            //Console.WriteLine("2/5 added 100,000 times: " + sun);
            //Console.WriteLine("2/5 multiplied by 100,000: " + 2 / 5.0f * 100000);

            //var p = 5.0 / 5;


            //int a = 3;
            //double b = a;

            //double c = 4.5;
            //int d = (int)c;

            //int max = int.MaxValue;
            //max++;

            //checked
            //{
            //    sbyte sNum = SByte.MaxValue;
            //    Console.Write("SByte max: " + sNum);
            //    sNum++;
            //    Console.WriteLine(sNum);
            //}

            //char n = 'N';
            //int i = 0;
            //Console.WriteLine((int)n);
            //Console.WriteLine(i);

            //var theInt = 5;
            //var anotherInt = Convert.ToChar(theInt);
            //var doubleEx = Convert.ToDouble(theInt);
            //Console.WriteLine(anotherInt);


            //double myDouble = 3.4;
            //int myInt32 = Convert.ToInt32(myDouble);

            //var date = Convert.ToDateTime(3);

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