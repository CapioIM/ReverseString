using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome Lets Have some FUN");
            Console.WriteLine("Whatever you type will return in reverse");

            string userInput = Console.ReadLine().ToLower();
            int countUp = 0;

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
                if (userInput[countUp] == userInput[i])
                {
                    countUp++;
                }
            }
            Console.WriteLine("\n");
            if (countUp == userInput.Length)
            {
                Console.WriteLine("\n\tThis word is Palindrome");
            }
            else
                Console.WriteLine("\n\tThis word NOT Palindrome, which means it doesn't read same backwards!"); 
        }
    }
}