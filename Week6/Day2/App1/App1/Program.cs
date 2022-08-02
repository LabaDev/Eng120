namespace SerialisationApp
{
    public class Program
    {
        private static readonly string _path  = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        private static readonly string _path2 = Path.Combine(Directory.GetCurrentDirectory(), @"../../../");
        private static ISerialise? _serialiser;
        static void Main(string[] args)
        {
            Trainee trainee = new Trainee
            {
                FirstName = "Bob",
                LastName = "Marley",
                SpartaNo = 100
            };

            var _serialiser = new SerialiserBinary();
            _serialiser.SerialisToFile($"{_path2}/BinaryTrainee.bin", trainee);
            //serialiser.SerialisToFile<Trainee>($"{_path}/BinaryTrainee.bin", trainee);

            Trainee deserialisedBob = _serialiser.DeserialiserFromFile<Trainee>($"{_path2}/BinaryTrainee.bin");

            if (trainee == deserialisedBob)
                Console.WriteLine("Welcome back");
            else
                Console.WriteLine("Imposter!!");
        }

    }
}