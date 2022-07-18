
namespace PalindromeApp;

public  class Program

{

    public bool Palindrome(string entry)
    {
<<<<<<< HEAD
        bool answer = false;
        var myStack = new Stack<char>();
        for (int i = 0; i < entry.Length; i++)
            myStack.Push(entry[i]);
        
        var stackPalindrome = "";
        foreach(char ch in myStack)
            stackPalindrome += ch;
=======
        static void Main(string[] args)
        {
            Console.Write(Palindrome("Hello"));  //returns False
            Console.Write(Palindrome("ollo"));   //returns True
            Console.Write(Palindrome("tim"));    //returns False
            Console.Write(Palindrome("dod"));    //returns True
            Console.Write(Palindrome("willow")); //returns False
            
            
            return;
        }
>>>>>>> e78f5317d77401ea5ea7527f3d18fe5f7602740f

        if (stackPalindrome == entry)
            answer = true;
       
        return answer;
    }
}
