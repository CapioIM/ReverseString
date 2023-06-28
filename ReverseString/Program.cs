using System;
using System.Text.RegularExpressions;

namespace ReverseString // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        //static string lettersAndNumbersOnly = "[^a-zA-Z0-9]";   for RagEx  method
        static void Main(string[] args)

        {
            /*
            test phrases to pass programm

A nut for a jar of tuna
Al lets Della call Ed “Stella.”
Amore, Roma.
Are we not pure? “No, sir!” Panama’s moody Noriega brags. “It is garbage!” Irony dooms a man—a prisoner up to new era.
)(()
1961  i don't think theres short code to make numbers upside down as palindromes
            */

            do
            {
                Console.WriteLine("===========================================================");
                Console.WriteLine("Welcome Lets Have Some FUN");
                Console.WriteLine("Whatever you type will return in reverse!");
                Console.WriteLine("===========================================================");
                string userInput = Console.ReadLine();
                string userOutput = null;
                bool inputIsSentence = false;

                for (int i = 0; i <= userInput.Length - 1; i++)
                {
                    userOutput = userInput[i] + userOutput;
                }

                foreach (char s in userInput)      // check for whitespaces in userInput
                {
                    if (char.IsWhiteSpace(s))
                    {
                        inputIsSentence = true;
                        break;
                    }
                }

                if (inputIsSentence)
                {
                    Console.WriteLine($"Your written sentence is spelled in reverse: {userOutput}");
                }
                else
                {
                    Console.WriteLine($"Your word is spelled in Reverse: {userOutput}");
                }

                /*   RageEx method
                 *   
                 Just commented 2 lines under to use an array for phrase comparison, because i have noticed that i am not that much familiar with array
                string userInputWithoutSpecialCharacters= Regex.Replace(userInput, lettersAndNumbersOnly, "").ToLower();
                 string userOutputWithoutSpecialCharacters = Regex.Replace(userOutput, lettersAndNumbersOnly, "").ToLower();
                */



                /* Contains() method
                 * 
                string userInputWithoutSpecialCharacters = null;
                 string userOutputWithoutSpecialCharacters = null;
                 char[] specialCharactersToRemove = { '´', '&', '<', '>', '=', '’', '\'', '*', '@', '\\', '{', '}', '[', ']', '^', '«', '»', '©', '†', '°', '÷', '$', '…', '—', '–', '€', '!', '`', '>', '≥', '-', '\"', '<', '≤', '–', '×', '≠', '#', '¶', '(', ')', '%', 'π', '|', '+', '±', '?', '“', '”', '\"', '\"', '‘', '’', '\'', '\'', '®', '§', '/', '~', '™', '_', ' ', '.', ',', };
                 foreach (char c in userInput.ToLower())
                 {
                     if (specialCharactersToRemove.Contains(c))
                     {
                         continue;
                     }
                     else
                     {
                         userInputWithoutSpecialCharacters = userInputWithoutSpecialCharacters + c;
                         userOutputWithoutSpecialCharacters = c + userOutputWithoutSpecialCharacters;
                     }
                 }
                 */

                // split string method
                string[] separator = { "´", "&", "<", ">", "=", "’", "\'", "*", "@", "\\", "{", "}", "[", "]", "^", "«", "»", "©", "†", "°", "÷", "$", "…", "—", "–", "€", "!", "`", ">", "≥", "-", "\"", "<", "≤", "–", "×", "≠", "#", "¶", "(", ")", "%", "π", "|", "+", "±", "?", "“", "”", "\"", "\"", "‘", "’", "\'", "\'", "®", "§", "/", "~", "™", "_", " ", ".", ",", };
                string[] userInputArray = userInput.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string userInputWithoutSpecialCharacters = string.Join("", userInputArray).ToLower();
                string[] userOutputArray = userOutput.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                string userOutputWithoutSpecialCharacters = string.Join("", userOutputArray).ToLower();

                Console.WriteLine($"Or just letters in reverse: {userOutputWithoutSpecialCharacters}");
                if (userInputWithoutSpecialCharacters == userOutputWithoutSpecialCharacters)
                {
                    Console.Write("\nAnd ---  ");
                    if (inputIsSentence)
                    {
                        Console.Write("This Phrase is Palindrome Yaaaaaaaay");
                    }
                    else
                    {
                        Console.Write("This Word is Palindrome Yay");
                    }
                }
                else
                {
                    if (inputIsSentence)
                    {
                        Console.WriteLine("This sentence is NOT Palindrome, which means it doesn't read same backwards!");
                    }
                    else
                    {
                        Console.WriteLine("This word is NOT Palindrome, which means it doesn't read same backwards!");
                    }
                }

                Console.WriteLine("\n\nWould you like to repeat? Y - Yes / N - No");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Have a Nice Day");

        }



    }
}

