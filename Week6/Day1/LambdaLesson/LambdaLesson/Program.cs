namespace LambdaLesson
{
    /*
     Lambdas:
        - Hvae no name
        - Is declared at the place it is used
        - Cannot be reused anywhere else
        - The types of parameter/s are inferred from context
     
    .Sum(method that returns a number)
    .Where(method that returns a number)
    .OrderBy(method which returns a key)
    .
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int> { 3, 7, 1, 2, 8, 3, 8, 4, 5 };
            //int allCount = ints.Count();
            //int allCountAlt = 0;
            //foreach ( int i in ints)
            //    allCountAlt++;

            //int countEven = 0;
            //foreach( int i in ints)
            //{
            //    if (IsEven(i))
            //        countEven++;
            //}

            int countMEvent = ints.Count(IsEven);
            // Dont use anonymous methods!!
            int countDEven = ints.Count(delegate (int n) { return n % 2 == 0; });
            int countLEven = ints.Count(x => x % 2 == 0);

            var people = new List<Person>
            {
                new Person { Name = "Nish", Age = 40, City = "Birmingham" },
                new Person { Name = "Cathy", Age = 50, City = "Ottawa" },
                new Person { Name = "Peter", Age = 30, City = "London" },
            };

            int youngPeople = people.Count(IsYoung);
            int youngPeople2 = people.Count(x => x.Age < 30);
            int oldPeople = people.Count(y => y.Age >= 30);
            
            Console.WriteLine(youngPeople2);
            Console.WriteLine(oldPeople);


            var ldnPeopleQuery = people.Where(p => p.City == "London");
            foreach (var person in ldnPeopleQuery)
                Console.WriteLine(person.Name);

            var peopleOrderByAge = people.OrderBy(x => x.Age).OrderByDescending(x => x.Name);
            foreach (var person in peopleOrderByAge)
                Console.WriteLine(person);

            var peopleOdnQueryAges = people.Where(p => p.City == "London").Select(x => x.Age);
            foreach(var person in peopleOdnQueryAges)
                Console.WriteLine(person);

            var employee = new { Age = 30, Name = 12 };

            var anon = people.Select(x => new { FullName = x.Name, x.City});
        }
        public static bool IsYoung(Person p)
        {
            return p.Age < 35;
        }

        public static bool IsEven(int n)
        {
            return n % 2 == 0; 
        }
    }
}