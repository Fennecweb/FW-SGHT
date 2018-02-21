using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EchoTesterThing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Started with arguments: ");
            foreach (string arg in args)
            {
                Console.Write(arg + " ");
            }
            Console.WriteLine();
            bool run = true;
            while (run)
            {
                string input = Console.ReadLine();
                Console.WriteLine(input);
                if (input.ToLower() == "quit") { run = false; }
            }
        }
    }
}
