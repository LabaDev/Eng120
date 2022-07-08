using System;
using System.Collections.Generic;

namespace MoreTypes_Lib
{
    public class ArraysExercises
    {

        
        // returns a 1D array containing the contents of a given List
        public static string[] Make1DArray(List<string> contents)
        {
            string[] array = new string[contents.Count];   
            for (int i =0; i<contents.Count; i++)
                array[i] = contents[i];
            return array;
        }

        // returns a 3D array containing the contents of a given List
        public static string[,,] Make3DArray(int length1, int length2, int length3, List<string> contents)
        {
            int dims = length1 * length2 * length3;
            if (dims > contents.Count)
                throw new ArgumentException("Number of elements in list must match array size");

            string[,,] array = new string[length1, length2, length3];
            int counter = 0;

            for (int i = 0; i < length1; i++)
            {
                for (int k = 0; k < length3; k++)
                {
                    array[i, 0, k] = contents[counter];
                    counter++;
                }
                
            }

            return array;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            int numOfArrays = countRow1 * countRow2;
            if (numOfArrays > contents.Count)
                throw new ArgumentException("Number of elements in list must match array size");


            string[][] jaggedStringArray = new string[2][];
            int index = 0;
            jaggedStringArray[0] = new string[countRow1];
            jaggedStringArray[1] = new string[countRow2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < jaggedStringArray.Length; j++)
                {
                    jaggedStringArray[i][j] = contents[index];
                    index++;
                }
            }   
            
            return jaggedStringArray;
        }   
    }
}
