/* 10. Animal Type
Write a program to print animal type by its name:
•	dog -> mammal
•	crocodile, tortoise, snake -> reptile
•	others -> unknown */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class animal_type
    {
        static void Main()
        {
            var animal = Console.ReadLine().ToLower();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                    Console.WriteLine("reptile");
                    break;
                case "tortoise":
                    Console.WriteLine("reptile");
                    break;
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }

        }
    }
}
