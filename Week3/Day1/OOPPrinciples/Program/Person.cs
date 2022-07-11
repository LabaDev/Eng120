using System;
using System.Collections.Generic;
using System.Text;


public class Person 
{
    private string _firstName;
    private string _lastName;

    
    public Person(string FName, string LName)
    {   
        _firstName = FName;
        _lastName = LName;
    }

    public string FirstName { get => _firstName; set => _firstName = value; }
    public string LirstName { get => _lastName; set => _lastName = value; }

    public void Print()
    {
        Console.WriteLine("Full Name: " + _firstName + " " + _lastName);
    }
}