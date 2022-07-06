using System;

namespace AgeClassifier;

public class Program
{

    static void Main(string[] args)
    {
        int ageOfViewer = 13;
        var band = AvailableClassifications(ageOfViewer);
        Console.WriteLine(band);
    }

    public static string AvailableClassifications(int ageOfViewer)
    {

        if (ageOfViewer < 0 || ageOfViewer > 150)
            throw new ArgumentOutOfRangeException("Age of viewer is out of range.");

        string result;
        if (ageOfViewer >1&& ageOfViewer <= 11)
        {
            result = "U, PG & 12 films are available.";
        }
        else if (ageOfViewer >= 12 && ageOfViewer < 15)
        {
            result = "U, PG, 12 & 15 films are available.";
        }
        else if (ageOfViewer >=15 && ageOfViewer <= 150)
        {
            result = "All films are available.";
        }
        else
        {
            result = "Invalid age";
        }
        return result;

    }
}

