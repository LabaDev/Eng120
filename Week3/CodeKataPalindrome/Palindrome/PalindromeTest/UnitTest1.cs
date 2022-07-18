using PalindromeApp;
namespace PalindromeTest
{
    public class Tests
    {


        [Test]
        public void GivenabbaInPalindrome_ReturnsTrue()
        {
            var subject = new Program.Palindrome();

            var result = Program.Palindrome("abba");
            Assert.That(result, Is.True);
        }
    }
}