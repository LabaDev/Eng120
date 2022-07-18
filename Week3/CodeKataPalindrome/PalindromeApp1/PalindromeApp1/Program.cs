namespace PalindromeApp
{
    public class Program

    {
        

        public static bool Palindrome(string args)
        {
            bool answer = false;
            var myStack = new Stack<char>();
            for (int i = 0; i < args.Length; i++)
                myStack.Push(args[i]);

            var completedPalindrome = "";
            foreach (char ch in myStack)
                completedPalindrome += ch;

            if (completedPalindrome == args)
                answer = true;

            return answer;
        }
    }
}