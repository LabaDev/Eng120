using System;
using System.Collections.Generic;
using System.Text;

public class Employee : Person
{
    private string _department;

    public Employee(string FName, string LName, string Dept) : base (FName, LName) 
    {
        _department = Dept;
    }

    public string Department { get => _department; set => _department = value; }

    public override void Print()
    {
        Console.WriteLine("Working in: " +  _department + " ");
        base.Print();
    }

}