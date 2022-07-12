using System;

 class Program
{
    static void Main(string[] args)
    {
        Person person;
        Random rand = new Random();
        int myRandomInt = rand.Next(0, 2);
        if (myRandomInt == 0)
            person = new Customer("Jyoti", "Suresh", "Mumbai");
        else
            person = new Employee("Minato", "Fujiwara", "IT");

        person.Print();

    }
}