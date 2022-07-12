namespace HomeworkApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Vehicle();
            Vehicle car2 = new Vehicle (5, 40);
            car.Move(2);
            car2.Move();
            Console.WriteLine(car.Position);
            Console.WriteLine(car2.Position);
            Console.WriteLine(car.Move(2));
            Console.WriteLine(car2.Move());
            
        }
    }
}