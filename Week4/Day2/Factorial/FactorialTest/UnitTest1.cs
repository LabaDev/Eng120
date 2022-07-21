
namespace FactorialTest
{
    public class Tests
    {
        

        [Test]
        public void GivenZero_Factorial_ReturnsOne()
        {
            Assert.That(Program.Factorial(0), Is.EqualTo(1));
        }
    }
}