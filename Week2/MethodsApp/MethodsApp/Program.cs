namespace MethodsApp;

public class Program
{
    static void Main(string[] args)
    {
        //var result = DoThis(x:10, y:"Decent");
        //var spartaPizza = OrderPizza(pepperoni: true, kiwi:true, jalepenos:true, chicken:true);
        //Console.WriteLine(spartaPizza);
        //var add1 = Add(1,2,3);
        //var add2 = Add(1,2);
        //var myTuple = ("Kai", "Chan", 60);
        //Console.WriteLine(myTuple);
        //Console.WriteLine(myTuple.Item1);
        //Console.WriteLine(myTuple.Item2);
        //Console.WriteLine(myTuple.Item3);

        //(string fName, string lName, int age) myTuple2 = ("Kai", "Chan", 60);
        //var myTuple3 = (title: "Lord of the Rings", copies:3);
        //var result = ConvertPoundsToStones(78);
        //var stones = result.stones;
        //var result2 = DoThat(11, "Hello", out bool z);
        int number = 10;
        Subtract(number);
        Console.WriteLine(number);
        Subtract(ref number);
        Console.WriteLine(number);



    }

    public static void Subtract(int num)
    {
        num--;
    }
    public static void Subtract(ref int num)
    {
        num--;
    }

    public static int DoThat(int x, string y, out bool z)
    {
        Console.WriteLine(y);
        z = (x > 10);
        return x * x;
    }

    public static (int stones ,int pounds) ConvertPoundsToStones(int pound)
    {
        var stones = pound / 14;
        var lbs = pound % 14;
        return (stones, lbs);
    }

    public static int DoThis(int x= 10 , string y = "Sad")
    {
        Console.WriteLine($"I'm feeling {y}");
        return x * x;
    }

    public static int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    public static int Add(int num1, int num2, int num3)
    {
        return num1 + num2 + num3;
    }

    public static string OrderPizza(bool pepperoni, bool chicken, bool jalepenos, bool kiwi = true)
    {
        var pizza = "Pizza with tomato sauce, cheese ";
        if (pepperoni) pizza += " pepperoni, ";
        if (chicken) pizza += " chicken, ";
        if (jalepenos) pizza += " jalepenos, ";
        if (kiwi) pizza += " kiwi, ";
        
        return pizza.Remove(pizza.Length - 2, 2);
    }
}

