using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToTest;
public class Program2
{
    static void Main(string[] args)
    {
        int ageOfViewer = 13;
        var band = AvailableClassifications(ageOfViewer);
        Console.WriteLine(band);
    }

    public static string AvailableClassifications(int ageOfViewer)
    {
        string result;
        if (ageOfViewer < 12)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer < 15)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else
        {
            result = "All films are available.";
        }
        return result;

    }
}