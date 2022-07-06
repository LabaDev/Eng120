using AgeClassifier;
namespace Classification_Tests
{
    public class Tests
    {
        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(200)]
        [TestCase(151)]
        public void GivenOutOfBoundValuesTo_AvaailableClassifications_ThrowsArgumentOutOfRangeException(int age)
        {
            Assert.That(() => Program.AvailableClassifications(age), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Age of viewer is out of range."));
        }

        [TestCase(2)]
        [TestCase(5)]
        [TestCase(11)]
        public void GivenAgeUnder12_Gives_Under12Films(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG & 12 films are available."));
        }
        [TestCase(12)]
        [TestCase(13)]
        [TestCase(14)]

        public void GivenAgeBetween12And15_Gives_TeenFilms(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("U, PG, 12 & 15 films are available."));
        }
        [TestCase(15)]
        [TestCase(18)]
        [TestCase(40)]
        public void GivenAgeOver15_Gives_AllFilms(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("All films are available."));
        }

        [TestCase(1)]
        [TestCase(0)]
        [TestCase(160)]
        public void GivenNonsenseAge_Gives_Invalid(int age)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo("Invalid age"));
        }

        [TestCase(1,2)]
        [TestCase(11,12)]
        [TestCase(14,15)]
        [TestCase(150,151)]
        public void GivenBoundaryCondition_Gives_BooleanBoundary(int age1, int age2)
        {
            string resultOne = Program.AvailableClassifications(age1);
            string resultTwo = Program.AvailableClassifications(age2);
            bool isBoundary = false;
            if (resultOne != resultTwo && Math.Abs(age1 - age2) == 1)
            {
                isBoundary = true;
            }
            Assert.That(isBoundary, Is.True);
        }
        [TestCase(1, "Invalid age")]
        [TestCase(151, "Invalid age")]
        [TestCase(11, "U, PG & 12 films are available.")]
        [TestCase(12, "U, PG, 12 & 15 films are available.")]
        [TestCase(15, "All films are available.")]
        [TestCase(150, "All films are available.")]
        public void GivenTestnumbers_Gives_BoundaryCondition(int age, string band)
        {
            Assert.That(Program.AvailableClassifications(age), Is.EqualTo(band));   
        }
    }
}

