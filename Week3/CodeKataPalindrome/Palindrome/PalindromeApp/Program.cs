using NUnit.Framework;

namespace PalindromeApp
{
    public class Program

    {
        static void Main(string[] args)
        {
            Console.Write(Palindrome("Hello"));  //returns False
            Console.Write(Palindrome("ollo"));   //returns True
            Console.Write(Palindrome("tim"));    //returns False
            Console.Write(Palindrome("dod"));    //returns True
            Console.Write(Palindrome("willow")); //returns False
            
            
            return;
        }

        public static bool Palindrome(string args)
        {
            bool answer = false;
            var myStack = new Stack<char>();
            for (int i = 0; i < args.Length; i++)
                myStack.Push(args[i]);
            
            var completedPalindrome = "";
            foreach(char ch in myStack)
                completedPalindrome += ch;

            if (completedPalindrome == args)
                answer = true;
           
            return answer;
        }
    }
}
