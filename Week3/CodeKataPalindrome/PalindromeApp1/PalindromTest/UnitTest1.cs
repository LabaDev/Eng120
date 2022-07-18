
namespace PalindromeTest
{
    public class Tests
    {


        [TestCase("abba")]
        [TestCase("Don't nod")]
        [TestCase("Evil olive")]
        [TestCase("Amore, Roma")]
        [TestCase("Amore, Roma")]
        [TestCase("Yo, banana boy!")]
        [TestCase("Dammit, I'm mad!")]
        [TestCase("Borrow or rob?")]
        [TestCase("I did, did I?")]
        [TestCase("Draw, O coward!")]
        public void GivenabbaInPalindrome_ReturnsTrue(string palinDro)
        {
            

            var result = Program.Palindrome(palinDro);
            Assert.That(result, Is.True);
        }
    }
}