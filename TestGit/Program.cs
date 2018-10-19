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
            }

        }
    }
}
