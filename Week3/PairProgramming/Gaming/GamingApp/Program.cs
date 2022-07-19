namespace GamingApp;

internal class Program
{
    static void Main(string[] args)
    {
        LaserGun gun = new LaserGun("Photon Canon");
        var hydroGun = new WaterGun("Hydrobeam");
        var sony = new Camera("Sony");
        var nikon = new Camera("Nikon");
        var waterGun = new WaterGun("WaterGun");
        var polaroid = new Camera("Polaroid");

        var hunter = new Hunter("Flying", "Monkey", gun);
        var hunter2 = new Hunter("Running", "Donkey", gun);


        var weapons = new List<IShootable>()
        {
            gun,
            waterGun,
            sony,
            hydroGun,
            nikon,
            polaroid
        };

        Random rand = new Random();

        Console.WriteLine("Press Enter to roll the dice!");
        while (hunter.Health > 0 && hunter2.Health > 0)
        {
            Console.ReadLine();
            var weapon1 = weapons[rand.Next(0, 6)];
            hunter.Shooter = weapon1;
            Console.WriteLine($"{hunter.FullName} picked up {weapon1.Shoot()}");

            Console.ReadLine();
            var weapon2 = weapons[rand.Next(0, 6)];
            hunter2.Shooter = weapon2;
            Console.WriteLine($"{hunter2.FullName} picked up {weapon2.Shoot()}");



            hunter.Health -= weapon2.Damage();
            hunter2.Health -= weapon1.Damage();

            Console.WriteLine();

            Console.WriteLine(hunter2.Shoot());
            Console.WriteLine(hunter.Shoot());
            Console.WriteLine("------------------------------------------------------------------------------");

        }






    }
}