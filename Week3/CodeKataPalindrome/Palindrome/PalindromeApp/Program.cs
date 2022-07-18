
namespace PalindromeApp;

public  class Program

{

    public bool Palindrome(string entry)
    {
        bool answer = false;
        var myStack = new Stack<char>();
        for (int i = 0; i < entry.Length; i++)
            myStack.Push(entry[i]);
        
        var stackPalindrome = "";
        foreach(char ch in myStack)
            stackPalindrome += ch;

        if (stackPalindrome == entry)
            answer = true;
       
        return answer;
    }
}