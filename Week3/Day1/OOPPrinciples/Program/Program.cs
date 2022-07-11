using System;

 class Program
{
    public static void Main(string[] args)
    {
        Customer cust = new Customer("Jyoti", "Suresh", "Mumbai");
        cust.LirstName = "Ghupta";
        cust.Print();

        Employee emp = new Employee("Minato", "Fujiwara", "IT");
        emp.Print();
    }
}