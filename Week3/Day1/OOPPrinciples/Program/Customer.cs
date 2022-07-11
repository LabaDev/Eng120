using System;
using System.Collections.Generic;
using System.Text;


public class Customer
{
    public string FirstName;
    public string LastName;

    
    public Customer(string FName, string LName)
    {   
        FirstName = FName;
        LastName = LName;
    }

    public void Print()
    {
        Console.WriteLine("Full Name: " + FirstName + " " + LastName);
    }
}