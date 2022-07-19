namespace GamingTests
{
    public class Tests
    {

        [TestCase("Bob", "Marley", "Bob Marley")]
        public void GivenNameIsBobMarley_PersonFullName_ReturnsBobMarley(string FName, string LName, string expectedName)
        {
            Person bob = new Person(FName, LName) ;
            Assert.That(bob.FullName, Is.EqualTo(expectedName));
        }

        [TestCase("", "", " ")]
        public void GivenNameIsEmpty_PersonFullName_ReturnsSpace(string FName, string LName, string expectedName)
        {
            Person bob = new Person(FName, LName);
            Assert.That(bob.FullName, Is.EqualTo(expectedName));
        }
    }
}