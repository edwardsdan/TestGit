using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hi there! What's your name?");
                string userName = Console.ReadLine();
                Console.WriteLine("Welcome, " + userName + "! Enter a number between 1 and 100!");
                string input = Console.ReadLine();
                int number;
                while (!int.TryParse(input, out number))
                {
                    if (number < 1 || number > 100)
                    {
                        Console.WriteLine($"Hey {userName}! That's not in range! Try again");
                    }
                }
                if (number % 2 == 0)
                {
                    if (number >= 2 && number < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (number >= 26 && number <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (number > 61 && number <=100)
                    {
                        Console.WriteLine(number + " Even");
                    }
                }
                else
                {
                    Console.WriteLine("Odd");
                }
                Console.WriteLine("Would you like to keep going? (y/n)");
                string cont = Console.ReadLine().ToLower();
                if (cont == "y")
                {

                }
                else if (cont == "n")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Sorry, {userName}. I didn't understand that! Try again (y/n)");
                    cont = Console.ReadLine().ToLower();
                }
            }
        }
    }
}