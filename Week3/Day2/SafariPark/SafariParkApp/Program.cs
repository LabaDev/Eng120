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
            //Person charlie = new Person("Charlie");
            //Person perter = new Person();
            //Person dan = new Person("Dan", "Summerside") { Age = 100 };
            //Person laba = new Person { FirstName = "Laba", LastName = "Limbu", Age = 33};

            //var shop1 = new Shopping { Ties =3, Shirts =3 , Trousers = 1};
            //var shop2 = new Shopping { Socks = 10 };


            //var spartan1 = new Spartan { FullName = "Kai", Course = "C# SDET", Personalid = 999 };
            //Hunter maks = new Hunter("Maks", "Hadys", "Sony") { Age = 10 };
            //Console.WriteLine(maks.Age);
            //Console.WriteLine(maks.Shoot());
            //Hunter nish = new Hunter();
            //Console.WriteLine(nish.Shoot());

            var Bob = new Person("Bob");
            var Marley = new Person("Marley");
            var Jammy = new Person("Jammy");

            List<object> listMovable = new List<object>()
            {
                Bob, Marley, Jammy
            };
            foreach (var obj in listMovable)
                Console.WriteLine(obj.Move());

        }
        
        public void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}