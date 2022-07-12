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

            var shop1 = new Shopping { Ties =3, Shirts =3 , Trousers = 1};
            var shop2 = new Shopping { Socks = 10 };


            var spartan1 = new Spartan { FullName = "Kai", Course = "C# SDET", Personalid = 999 };


        }
        
        public void DemoMethod(Point3d pt, Person p)
        {
            pt.x = 100;
            p.Age = 100;
        }
    }
}