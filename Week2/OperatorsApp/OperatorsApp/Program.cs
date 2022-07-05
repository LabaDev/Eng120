using ControlFlowApp;

namespace OperatorsApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //int y = 0;
            //int a = x++;
            //int b = ++y;

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //var c = 5 / 2;
            //var d = 5.0 / 2;
            //var e = 5 / 3;
            //var f = 9 / 10;

            //var g = 5 % 2;

            //// 15 days in week and days
            //var weeks = 15 / 7;
            //var days = 15 % 7;
            ////Console.WriteLine($"{weeks} weeks and {days} day/s"}

            //const int NUM_ROW = 2;
            //const int NUM_COL = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int sprintNo = -1;

            //while (running)
            //{
            //    sprintNo = ++sprintNo % (NUM_ROW * NUM_COL);
            //    row = sprintNo / NUM_COL;
            //    col = sprintNo % NUM_COL;


            //int j = 5;
            //int k = 3;
            //int m = 4;
            //m += +j++ + ++k;
            //Console.WriteLine(m);

            //public static int FindSumDiv5and7(int n)
            //{
            ////    int sum = 0;
            ////    for (int i = 1; i <= n; i++)
            ////{   
            ////    if (i%5 == 0 || i % 7 == 0)
            ////    {
            ////        sum += i;
            ////    }

            ////}
            ////    return sum;
            //
            //}

            #region Logical Operators
            //bool isWearingParachute = false;
            //if (isWearingParachite || JumpOutOfPlane()){

            //public static bool JumpOutOfPlane()
            //{
            //    Console.WriteLine("Jump");
            //    return true;
            //}
            #endregion

            //Console.WriteLine(Priority(5));
            //Console.WriteLine(DrivingLaws(20));

            List<int> nums = new List<int> { 10, 6, 22, -17, 3 };
            Console.WriteLine("Highest foreach loop: " + LoopTypes.HighestForEachLoop(nums));
            Console.WriteLine("Highest for- loop: " + LoopTypes.HighestForLoop(nums));
            Console.WriteLine("Highest while- loop: " + LoopTypes.HighestWhileLoop(nums));
            Console.WriteLine("Highest do-while loop: " + LoopTypes.HighestDoWhileLoop(nums));
        }
        #region Switch
        public static string Priority(int level)
            {
                string priority = "Code ";
                switch (level)
                {
                    case 3:
                        priority = priority + "Red";
                    break;
                    case 2:
                        priority = priority + "Amber";
                    break;
                    case 1:
                        priority = priority + "Green";
                        break;
                    default:
                        priority = "Error";
                        break;

                }
                return priority;
        #endregion

            }


        public static string DrivingLaws(int age)
        {
            string law = "";
            switch (age)
            {
                case  < 18:
                    law = "Cannot legally drive";
                    break;
                case  < 23:
                    law = "Can legally drive bit cannot hire a car";
                    break;
                default:
                    law = "Can legally drive and rent a car";
                    break;
            }
            return law;
        }
    }
}