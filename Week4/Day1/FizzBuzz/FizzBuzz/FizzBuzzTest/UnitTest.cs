using FizzBuzzApp;
namespace FizzBuzzTest
{
    public class Tests
    {
        [Test]
        public void GivenOne_Return_OneString()
        {
            Assert.That(Program.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void GivenTwo_Return_OneTwoString()
        {
            Assert.That(Program.FizzBuzz(2), Is.EqualTo("1 2"));
        }
        [Test]
        public void GivenThree_Return_OneTwoFizzString()
        {
            Assert.That(Program.FizzBuzz(3), Is.EqualTo("1 2 Fizz"));
        }

        [Test]
        public void GivenFive_Return_OneTwoFizzFourBuzzString()
        {
            Assert.That(Program.FizzBuzz(5), Is.EqualTo("1 2 Fizz 4 Buzz"));
        }

        [Test]
        public void Given15_Return_FizzBuzzAtEnd()
        {
            Assert.That(Program.FizzBuzz(15), Is.EqualTo("1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz"));
        }


    }
}