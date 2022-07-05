
namespace ControlFlowApp
{
    public class ControlMethods
    {
        static void Main(string[] args)
        {
            //string grade = mark >= 65 ? "Pass" : "Fail";
            //Console.WriteLine(grade);
            //string garde2 = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") :  (mark < 20 ? "Failed no retake" : "Fail with retake");

            int mark = 15;
            
            Console.WriteLine(Grade(mark));
        }

        public static string Grade(int mark)
        {
            return mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : "Fail";
        }
    }
}