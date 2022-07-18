namespace StringCalculatorApp;

public class Program
{
    static void Main(string[] args)
    {

    }

    //public static int Calculator(string entry)
    //{
    //    if (entry.Length == 0)
    //        return 0;
    //}

    //public static int Calculator(string entry)
    //{
    //    if (entry.Length == 0)
    //        return 0;
    //    var number = Int32.TryParse(entry, out var value);
    //    return value;
    //}

    //public static int Calculator(string entry)
    //{
    //    int number = 0;
    //    if (entry.Length == 0 || entry == "1,\n")
    //        return number;
    //    for (int i = 0; i < entry.Length; i++)
    //    {
    //        Int32.TryParse(entry[i].ToString(), out var value);
    //        number += value;
    //    }


    //    return number;
    //}


    //public static int Calculator(string entry)
    //{
    //    int number = 0;
    //    if (entry.Length == 0 || entry == "1,\n")
    //        return number;
    //    for (int i = 0; i < entry.Length; i++)
    //    {
    //        if (entry[i] == '-')
    //            throw new ArgumentException("Negative Numbers not Allowed!");
    //        Int32.TryParse(entry[i].ToString(), out var value);
    //        number += value;
    //    }


    //    return number;
    //}


    //public static int Calculator(string entry)
    //{
    //    int number = 0;
    //    if (entry.Length == 0 || entry == "1,\n")
    //        return number;

    //    entry += ' ';
    //    bool containsNegative = false;
    //    string intMoreThanOneChar = "";
    //    for (int i = 0; i < entry.Length; i++)
    //    {
    //        //detecting negative numbers
    //        if (entry[i] == '-')
    //            containsNegative = true;

    //        if (Int32.TryParse(entry[i].ToString(), out var value))
    //            intMoreThanOneChar += value;
    //        else
    //        {
    //            Int32.TryParse(intMoreThanOneChar, out var value2);
    //            number += value2;
    //            intMoreThanOneChar = "";
    //        }
    //    }

    //    if (containsNegative)
    //        throw new ArgumentException("Negative Numbers not Allowed!");

    //    return number;
    //}

    public static int Calculator(string entry)
    {
        //Initializing the answer
        int number = 0;

        //Checking is entry is empty or is "1,\n"
        if (entry.Length == 0 || entry == "1,\n")
            return number;

        //Adding space to the entry to check more values more than 9
        entry += ' ';

        //initailizing to find negative numbers.
        bool containsNegative = false;

        //initialing if entry contains number more than 9
        string intMoreThanOneChar = "";

        for (int i = 0; i < entry.Length; i++)
        {
            
            if (entry[i] == '-')
                containsNegative = true;


            if (Int32.TryParse(entry[i].ToString(), out var value))
                intMoreThanOneChar += value;
            else
            {
                Int32.TryParse(intMoreThanOneChar, out var value2);
                if (value2 > 1000)
                    value2 = 0;
                number += value2;
                intMoreThanOneChar = "";
            }
        }

        if (containsNegative)
            throw new ArgumentException("Negative Numbers not Allowed!");

        return number;
    }
}