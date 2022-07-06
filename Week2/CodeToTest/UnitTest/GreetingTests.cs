using CodeToTest;

namespace UnitTest
{
    public class Tests
    {

        [TestCase(-1)]
        [TestCase(-100)]
        [TestCase(100)]
        [TestCase(25)]

        public void GivenOutOfBoundValesTo_Greeting_ThrowsOutOfBoundException(int time)
        {
            Assert.That(() => Program.Greeting(time), Throws.TypeOf<ArgumentOutOfRangeException>().With.Message.Contain("Given time out of range"));
        }

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
        [Test]
        public void GivenATimeOf15_Greeting_ReturnsGoodEvening()
        {
            
            Assert.That(Program.Greeting(15), Is.EqualTo("Good afternoon!"));
        }
        [Test]
        public void GivenATimeOf2_Greeting_ReturnsGoodEvening()
        {

            Assert.That(Program.Greeting(2), Is.EqualTo("Good evening!"));
        }
        [Test]
        public void GivenATimeOf8_Greeting_ReturnsGoodEvening()
        {

            Assert.That(Program.Greeting(8), Is.EqualTo("Good morning!"));
        }


        [TestCase(5)]
        [TestCase(8)]
        [TestCase(11)]
        public void GivenATimeOf5and12Inclusive_Greeting_ReturnsGoodEvening(int time)
        {

            Assert.That(Program.Greeting(time), Is.EqualTo("Good morning!"));
        }


        
        [TestCase(12)]
        [TestCase(15)]
        [TestCase(18)]
        public void GivenATimeOf12and18Inclusive_Greeting_ReturnsGoodEvening(int arg)
        {
            Assert.That(Program.Greeting(arg), Is.EqualTo("Good afternoon!"));
        }

        [TestCase(19)]
        [TestCase(20)]
        [TestCase(2)]
        public void GivenATimeOf19and4Inclusive_Greeting_ReturnsGoodEvening(int time)
        {
            Assert.That(Program.Greeting(time), Is.EqualTo("Good evening!"));
        }

        //[TestCase(18, 19)]
        //[TestCase(11, 12)]
        //[TestCase(4, 5)]

        //public void GivenTheTimes_Greeting_ChecksBoundaryConditions(int arg1, int arg2)
        //{
        //    string resultOne = Program.Greeting(arg1);
        //    string resultTwo = Program.Greeting(arg2);
        //    bool isBoundary = false;
        //    if (resultOne != resultTwo && Math.Abs(arg1-arg2) == 1)
        //    {
        //        isBoundary = true;
        //    }
        //    Assert.That(isBoundary, Is.True);
        //}
    }
}