using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //  A nut for a jar of tuna
            //  Al lets Della call Ed “Stella.”
            //  Amore, Roma.
            //  Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era.
            //  )(()
            //  1961

            do
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Welcome Lets Have some FUN");
                Console.WriteLine("Whatever you type will return in reverse (Or Upside Down ?)");
                Console.WriteLine("===========================================================");
                string userInput = Console.ReadLine();
                string userOutput = null;

                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    userOutput += userInput[i];
                }

                if (userInput.Length > 8)
                    Console.WriteLine($"\tYour written sentence is spelled in reverse:\n{userOutput}");
                else
                    Console.WriteLine($"\tYour Word or Number is spelled in Reverse:\n{userOutput}");

                userInput = userInput.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("“", "").Replace("?", "").Replace("!", "").Replace("-", "").Replace(".", "").Replace("\"", "").Replace("\'", "").Replace("9", "6");
                userOutput = userOutput.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("“", "").Replace("?", "").Replace("!", "").Replace("-", "").Replace(".", "").Replace("\"", "").Replace("\'", "").Replace("9", "6");
                Console.WriteLine($"Or \n{userOutput}");

                Console.Write("\nAnd ---");
                if (userInput == userOutput)
                {
                    Console.Write("\tThis word or Phrase is Palindrome Yaaaaaaaay");
                }
                else
                    Console.Write("\tThis word or Phrase is NOT Palindrome, which means it doesn't read same backwards!");
                Console.WriteLine("\nWould you like to Try again? Y - Yes / N - No");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Have a Nice Day, and don't forget to check your phone");


        }
    }
}