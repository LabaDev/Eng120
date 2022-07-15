using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class CollectionsExercises
    {

        /* removes and returns the next num entries in the queue, as a comma separated string */
        public static string NextInQueue(int num, Queue<string> queue)
        {
            var list = new List<string>();
            string output = "";
            if (num == 1)
                return queue.Dequeue();

            

            for (int i = 0; i < num-1; i++)
                output += queue.Dequeue() + ", ";
            output += queue.Dequeue();

            if (queue.Count == 0)
                return "";

            return output;
        }

        /* uses a Stack to create and return array of ints in reverse order to the one supplied */
        public static int[] Reverse(int[] original)
        {
            return new int[] { };
        }
        // using a Dictionary, counts and returns (as a string) the occurence of the digits 0-9 in the given string
        public static string CountDigits(string input)
        {
            if (input == "")
                return "";
            var countDict = new Dictionary<char, int>();
            foreach (char c in input)
            {
                if (Int32.TryParse(c.ToString(), out int result))
                {
                    if (countDict.ContainsKey(c))
                        countDict[c]++;
                    else
                        countDict.Add(c, 1);
                }
            }
            string output = "";
            foreach (var entry in countDict)
            {
                output += entry;
            }
                
                
            return output;    
        }
    }
}
