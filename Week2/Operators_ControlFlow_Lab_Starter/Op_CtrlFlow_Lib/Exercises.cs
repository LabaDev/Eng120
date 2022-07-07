using System.Collections.Generic;
using System;
namespace Op_CtrlFlow
{
    public class Exercises
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 2};
            Console.WriteLine(Average(list));
            return;
        }
        public static bool MyMethod(int num1, int num2)
        {
            return num1 == num2 ? false : (num1 % num2) == 0;
        }

        // returns the average of the array nums
        public static double Average(List<int> nums)
        {


            double total = 0;
            foreach (int num in nums)
                total += num;
            int a = nums.Count;

            if (a == 0)
            {
                throw new DivideByZeroException("List is empty!");
                
            }
            return total / a;

            

        }

        // returns the type of ticket a customer is eligible for based on their age
        // "Standard" if they are between 18 and 59 inclusive
        // "OAP" if they are 60 or over
        // "Student" if they are 13-17 inclusive
        // "Child" if they are 5-12
        // "Free" if they are under 5
        public static string TicketType(int age)
        {
            if (age < 0 || age > 140)
            {
                throw new ArgumentOutOfRangeException("Age is out of range.");
            }
            string ticketType = string.Empty;
            if (age >= 18 && age <= 59)
                ticketType = "Standard";
            else if (age >= 60 && age <= 140)
                ticketType = "OAP";
            else if (age >= 13 && age <= 17)
                ticketType = "Student";
            else if (age >= 5 && age <= 12)
                ticketType = "Child";
            else if (age >= 0 && age <= 4)
                ticketType = "Free";
            else
                ticketType = "Invalid";

            return ticketType;
        }

        public static string Grade(int mark)
        {
            if (mark < 0 || mark > 100)
                throw new ArgumentOutOfRangeException("Mark is out of range.");
            
            var grade = "";

            grade = mark >= 65 ? (mark >= 85 ? "Distinction" : "Pass") : (mark >= 25 ? "Resit" : "Fail");
            return grade;
        }

        public static int GetScottishMaxWeddingNumbers(int covidLevel)
        {
            if (covidLevel < 0 || covidLevel >= 5)
            {
                throw new ArgumentOutOfRangeException("Covid level is out of range");
            }
            switch (covidLevel)
            {
                case 4:
                    return 20;
                case 3:
                case 2:
                    return 50;
                case 1:
                    return 100;
                case 0:
                    return 200;

            }
            return 0;
        }
    }
}
