using System.Collections;

namespace SafariParkApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Person jon = new Person("Jon", "Crofts", 22);
            //jon.Age = 23;
            //Console.WriteLine(jon.Age);
            //Console.WriteLine(jon.FullName());
            Person charlie = new Person("Charlie");
            Person perter = new Person();
            Person dan = new Person("Dan", "Summerside") { Age = 100 };
            //Person laba = new Person { FirstName = "Laba", LastName = "Limbu", Age = 33};

            //var shop1 = new Shopping { Ties =3, Shirts =3 , Trousers = 1};
            //var shop2 = new Shopping { Socks = 10 };


            //var spartan1 = new Spartan { FullName = "Kai", Course = "C# SDET", Personalid = 999 };
            //Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            //Console.WriteLine(maks.Age);
            //Console.WriteLine(maks.Shoot());
            //Hunter nish = new Hunter();
            //Console.WriteLine(nish.Shoot());

            //var Bob = new Person("Bob");
            //var Marley = new Person("Marley");
            //var Jammy = new Person("Jammy");

            //List<object> listMovable = new List<object>()
            //{
            //    Bob, Marley, Jammy
            //};

            //List<Person> peopleList = new List<Person>() 
            //{
            //    new Person("Nish", "Mandel") { Age = 32} 
            //};

            //var kai = new Person("Kai", "Chan") { Age = 23 };
            //var tom = new Person("Tom", "W");

            //peopleList.Add(tom);

            //var newerList = new List<Person>();
            //newerList.AddRange(peopleList);
            //newerList.Add(kai);

            //peopleList.ForEach(x => Console.WriteLine(x.FullName));
            //newerList.ForEach(x => Console.WriteLine(x.FullName));

            //var numList = new List<int>() { 5,4,3,9,0 };
            //numList.Add(8);
            //numList.Sort();
            //numList.RemoveRange(1,2);
            //numList[2] = 1;
            //numList.Reverse();
            //numList.Remove(9);            
            //numList.ForEach(x => Console.WriteLine(x ));

            //var linkedList = new LinkedList<Person>();
            //linkedList.AddFirst(charlie);
            //linkedList.AddLast(perter);
            //var charl = linkedList.Find(charlie).Value;
            //Console.WriteLine(charl);
            //foreach (var item in linkedList)
            //{
            //    Console.WriteLine(item);
            //}

        }
        
        public void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}