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
                Console.WriteLine("Hi there! Enter a number between 1 and 100!");
                string input = Console.ReadLine();
                int number = int.Parse(input);
                if (number % 2 == 0)
                {
                    if (number >= 2 && number < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                }
            }

        }
    }
}
