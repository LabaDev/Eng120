namespace ComparingObjectApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var nish = new Person("Nish", "Mandel") { Age = 22 };
            var tom = nish;
            var david = new Person("David", "Joyce") { Age = 26 };
            
            Console.WriteLine(nish.GetHashCode());
            Console.WriteLine(tom.GetHashCode());
            Console.WriteLine(david.GetHashCode());
        }
    }

    public class Person

    {
        private string _firstName;
        private string _lastName;
        private int _age;
        public Person() { }
        public Person(string fName, string lName)
        {
            _firstName = fName;
            _lastName = lName;
        }

        public int Age
        {
            get { return _age; }
            set { if (value >= 0) _age = value; }
        }

        public string GetFullName()
        {
            return $"{_firstName} {_lastName}";
        }

    }
}