namespace SafariParkTest
{
    public class Tests
    {
        [Test]
        public void Point3dTest()
        {
            //Arrange
            var subject = new Point3d(1, 1, 1);

            //Act
            var result = subject.SumOfPoints();
            //Arrange
            Assert.That(subject.x, Is.EqualTo(1));
            Assert.That(subject.y, Is.EqualTo(1));
            Assert.That(subject.y, Is.EqualTo(1));
            Assert.That(result, Is.EqualTo(3));

        }
        

        [TestCase("Cathy", "French", "Cathy French")]
        [TestCase("", "", " ")]
        public void GetFullNameTest(string firstName, string lastName, string expectedResult)
        {
            Person cathy = new Person();
            var result = cathy.GetFullName();
            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B") { Age = 33 };
            Assert.That(subject.Age, Is.EqualTo(33));
        }
    }
}