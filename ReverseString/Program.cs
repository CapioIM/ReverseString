using System;

namespace ReverseString // Note: actual namespace depends on the project name.
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
                bool inputSentence = false;

                for (int i = userInput.Length - 1; i >= 0; i--)
                {
                    userOutput += userInput[i];
                }

                if (userInput.Contains(" "))
                {
                    Console.WriteLine($"\t\tYour written sentence is spelled in reverse:\n{userOutput}");
                    inputSentence = true;
                }
                else
                {
                    Console.WriteLine($"\tYour Word is spelled in Reverse:\n{userOutput}");
                }

                userInput = userInput.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("“", "").Replace("?", "").Replace("!", "").Replace("-", "").Replace(".", "").Replace("\"", "").Replace("\'", "");
                userOutput = userOutput.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "").Replace("“", "").Replace("?", "").Replace("!", "").Replace("-", "").Replace(".", "").Replace("\"", "").Replace("\'", "");
                Console.WriteLine($"\nOr just letters in reverse: {userOutput}");

                if (userInput == userOutput)
                {
                    Console.Write("\nAnd ---  ");
                    if (inputSentence)
                    {
                        Console.Write("This Phrase is Palindrome Yaaaaaaaay");
                    }
                    else
                    {
                        Console.Write("This Word is Palindrome Yaaaaaaaay");
                    }
                }
                else
                {
                    Console.Write("This word or sentence is NOT Palindrome, which means it doesn't read same backwards!");
                }
                

                Console.WriteLine("\n\nWould you like to Try again? Y - Yes / N - No");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Have a Nice Day, before leaving building , have a look ");
        }
    }
}
