namespace PalindromeApp
{
    public class Program

    {
        public static void Main(string[] args)
        {
            return;
        }

        public static bool Palindrome(string args)
        {
            bool answer = false;
            args = args.ToLower().Trim();
            string newargs = "";

            foreach(char ch in args)
            {
                if (ch > 'a' || ch > 'A')
                    newargs += ch; 
            }

            var myStack = new Stack<char>();
            for (int i = 0; i < newargs.Length; i++)
                myStack.Push(newargs[i]);

            var completedPalindrome = "";
            foreach (char ch in myStack)
                completedPalindrome += ch;

            if (completedPalindrome == newargs)
                answer = true;

            return answer;
        }
    }
}