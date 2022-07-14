using System;
using System.Collections.Generic;

namespace Collections_Lib
{
    public class ListExercises
    {
        // returns a list of all the integers between 1 to max inclusive
        // that are multiples of 5
        public static List<int> MakeFiveList(int max)
        {
            
            var list1 = new List<int>();
            
            int fiveDiv = max / 5;
            for(int i = 1; i <= fiveDiv; i++)  
                list1.Add(i*5);
            

            return list1;
        }

        // returns a list of all the strings in sourceList that start with the letter 'A' or 'a'
        public static List<string> MakeAList(List<string> sourceList)
        {
            var list1 = new List<string>();

            foreach (string el in sourceList)
                if (el[0] == 'a' || el[0] == 'A')
                    list1.Add(el);
            

            return list1;

        }
    }
}
