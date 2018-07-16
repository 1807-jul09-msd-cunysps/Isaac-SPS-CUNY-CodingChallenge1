using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PalindromeLibrary;

namespace PalindromeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cont = true;
            PalindromeChecker checker = new PalindromeChecker();

            Console.WriteLine("Welcome to Palindrom Checker!" + Environment.NewLine + "**********" + Environment.NewLine);

            while (cont)
            {
                Console.WriteLine("Enter the word 'exit' to end the program.");
                Console.WriteLine("Please enter a string or number to check.");
                string input = Console.ReadLine();

                if(input == "exit")
                {
                    cont = false;
                }
                else
                {
                    Console.WriteLine("It's..." + (checker.Check(input) ? "A PALINDROME!" : "NOT A PALINDROME"));
                }
            }
        }
    }
}
