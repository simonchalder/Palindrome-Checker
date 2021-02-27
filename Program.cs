using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word...");
            string word = Console.ReadLine();
            char[] wordArray = word.ToCharArray();
            Array.Reverse(wordArray);
            string reverseWord = String.Concat(wordArray);

            if (word == reverseWord)
            {
                Console.WriteLine("This is a palindrome!");
            }
            else
            {
                Console.WriteLine("This is NOT a plaindrome");
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
