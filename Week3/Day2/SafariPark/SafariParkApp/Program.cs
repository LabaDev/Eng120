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
            Person perter = new Person("Peter");
            Person dan = new Person("Dan", "Summerside") { Age = 100 };
            Person Helen = new Person("Helen", "Troy") { Age = 22 };
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


            //Queues
            //FIFO = First in First out
            //var myQueue = new Queue<Person>();
            //myQueue.Enqueue(charlie);
            //myQueue.Enqueue(dan);
            //myQueue.Enqueue(new Person("David"));

            //Console.WriteLine("Queue\n");
            //foreach (var person in myQueue)
            //    Console.WriteLine(person);

            //Console.WriteLine("\n");
            //var first = myQueue.Peek();
            //Console.WriteLine(first);

            //Console.WriteLine("\n");
            //var serve = myQueue.Peek();
            //Console.WriteLine(serve);

            //Stack
            //LIFO = Last in First out
            //var stack = new Stack<int>();
            //int[] nums = new[] { 1, 2, 3, 4, 5, 6 };
            //int[] numsReversed = new int[nums.Length];

            //foreach(var num in nums)
            //    stack.Push(num);
            //for (int i = 0; i < numsReversed.Length; i++)
            //    numsReversed[i] = stack.Pop();

            //HashSet
            //var peopleSet = new HashSet<Person>()
            //{
            //    charlie, new Person("Dylan"), new Person("Thomas"), new Person("Akon"), Helen
            //};
            //Console.WriteLine("Hash set");
            //foreach (var entry in peopleSet)
            //    Console.WriteLine(entry);

            //var successMartin = peopleSet.Add(new Person("Martin", "Beard") { Age = 21}); 
            //var successHelen = peopleSet.Add(new Person("Helen", "Troy") { Age = 22});
            //Console.WriteLine(successHelen);
            //Console.WriteLine(successMartin);

            //var morePeople = new HashSet<Person> { new Person("Cathy"), new Person("Jasmine"), new Person("Thomas") };
            //peopleSet.IntersectWith(morePeople);
            //Console.WriteLine(peopleSet);

            //Dictionary
            //var personDictionary = new Dictionary<string, Person>()
            //{
            //    {"Helen", Helen },
            //    {"Tom", new Person("Thomas") }
            //};

            //var p = personDictionary["Tom"];
            //personDictionary.Add("Char", charlie);

            //string input = "The cat in the hat comes back";
            //input = input.Trim().ToLower();
            //var countDict = new Dictionary<char, int>();
            //foreach (char c in input)
            //    if (countDict.ContainsKey(c))
            //            countDict[c]++;
            //    else
            //        countDict.Add(c, 1);
            //Console.WriteLine("\n Dictionary Problem");
            //foreach (var entry in countDict)
            //    Console.WriteLine(entry);
            //foreach (var keys in countDict.Keys)

            //    Console.WriteLine($"Key {keys}");
            //Console.WriteLine();
            //foreach (var value in countDict.Values)
            //    Console.WriteLine($"Value {value}");



        }
        
        public void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}