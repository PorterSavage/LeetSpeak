using System;
using System.Collections.Generic;

namespace LeetSpeak
{
    public class LeetSpeakClass
    {
        public static char Words(char userWords)
        {
            if (userWords == 'e' || userWords == 'E')
            {
                return '3';
            }
            else if (userWords == 'o' || userWords == 'O')
            {
                return '0';
            }
            else if (userWords == 'I')
            {
                return '1';
            }
            else if (userWords == 't' || userWords == 'T')
            {
                return '7';
            }
            else if (userWords == 's' || userWords == 'S')
            {
                return 'z';
            }
            else
            {
                return userWords;
            }
        }
        public static void Main()
        {
            Console.WriteLine("Enter a sentence and I'll translate it to 1337 Sp3ak!");
            string userInput = Console.ReadLine();
            char[] inputArray = userInput.ToCharArray();
            for (int i=0; i < inputArray.Length; i++)
            {
                inputArray[i] = Words(inputArray[i]);
            }
            string wordSentence = string.Join("", inputArray);
            Console.WriteLine(wordSentence);
            
        }
    }
}