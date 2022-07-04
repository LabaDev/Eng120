using CodeToTest;

namespace UnitTest
{
    public class Tests
    {
        [Test]
        public void GivenATimeOf21_Greeting_ReturnsGoodEvening()
        {
            //Arrange
            var time = 21;
            var expectedGreeting = "Good evening!";
            
            //Act 
            var result = Program.Greeting(time);
            //Assert
            Assert.That(result, Is.EqualTo(expectedGreeting));
        }
    }
}