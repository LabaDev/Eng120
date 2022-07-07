using System;

namespace MoreTypes_Lib
{
    public class StringExercises
    {
        // manipulates and returns a string - see the unit test for requirements
        public static string ManipulateString(string input, int num)
        {
            input = input.Trim(); 
            input = input.ToUpper();
            string numbers = "";
            for( int i =0; i<num; i++)
            {
                numbers += i.ToString();
            }
            input = input + numbers;
            return input;
        }

        // returns a formatted address string given its components
        public static string Address(int number, string street, string city, string postcode)
        {
            string address = $"{number} {street}, {city} {postcode}.";
            return address;
        }
        // returns a string representing a test score, written as percentage to 1 decimal place
        public static string Scorer(double score, double outOf)
        {
            string message = $"You got {score} out of {outOf}: {Math.Round((score / outOf)*100, 1)}%";
            return message;
        }

        // returns the double represented by the string, or -999 if conversion is not possible
        public static double ParseNum(string numString)
        {

            var success = Double.TryParse(numString, out double numOfDigits);

            return success ? numOfDigits : -999;
        }

        // Returns the a string containing the count of As, Bs, Cs and Ds in the parameter string
        // all other letters are ignored
        public static string CountLetters(string input)
        {
            int a = 0, b= 0, c = 0, d = 0;
            foreach(char i in input)
            {
                if (i == 'A')
                    a++;
                else if (i == 'B')
                    b++;
                else if (i == 'C')
                    c++;
                else if (i == 'D')
                    d++;

            }
            string answer = $"A:{a} B:{b} C:{c} D:{d}";
            return answer;
        }
    }
}
