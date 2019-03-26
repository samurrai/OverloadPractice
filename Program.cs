using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Person first = new Person() {
                Name = "Andrey", 
                Surname = "Ivanov"
            };
            Person second = new Person()
            {
                Name = "Andrey",
                Surname = "Ivanov"
            };
            Console.WriteLine(first == second);
            Console.WriteLine();

            MagicNumbers firstNumbers = new MagicNumbers()
            {
                Numbers = new int[] { 0, 3, 1, 65}
            };
            MagicNumbers secondNumbers = new MagicNumbers()
            {
                Numbers = new int[] { 1, 2, 3, 4 }
            };
            Console.WriteLine(firstNumbers > secondNumbers);
        }
    }
}
