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
            string[,,] array = new string[length1, length2, length3];
            int j = 0;


            for (int i = 0; i <= length1; i++)
            {
                for (int k = 0; k <= length3; k++)
                {
                    array[i, 0, k] = contents[j];
                    j++;
                }
                
            }

            return array;
        }

        // returns a jagged array containing the contents of a given List
        public static string[][] MakeJagged2DArray(int countRow1, int countRow2, List<string> contents)
        {
            string[][] jaggedArray = new string[2][];

            int counter = 0;
            for (int i = 0; i<countRow1; i++)
                jaggedArray[0][i] = contents[counter++];
            jaggedArray[1] = new string[countRow2];
            for (int j = 0; j < countRow2; j++)
            
                jaggedArray[1][j] = contents[counter++];
            
            return jaggedArray;
        }   
    }
}
