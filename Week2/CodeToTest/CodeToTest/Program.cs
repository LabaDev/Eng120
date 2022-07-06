using System;

namespace CodeToTest;

public class Program
{
    //static void Main(string[] args)
    //{
    //    //int timeOfDay = 21;
    //    //var greet = Greeting(timeOfDay);
    //    ////Console.WriteLine(greet);
    //    //return;
    //}

    public static string Greeting(int timeOfDay)
    {
        if (timeOfDay < 0 || timeOfDay > 24)
            throw new ArgumentOutOfRangeException("Given time out of range");

        string greeting;
        if (timeOfDay >= 5 && timeOfDay < 12)
        {
           greeting = "Good morning!";
        }
        else if (timeOfDay >= 12 && timeOfDay <= 18)
        {
            greeting = "Good afternoon!";
        }
        else
        {
            greeting = "Good evening!";
        }
        return greeting;    
    }
}



