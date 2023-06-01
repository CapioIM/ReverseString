using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Weolcome to Reverse String Programm");
            string userInput = Console.ReadLine();

            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
    }
}