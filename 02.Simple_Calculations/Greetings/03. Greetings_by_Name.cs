// Задача 3: Поздрав по име
//Да се напише програма, която чете от конзолата име на човек и отпечатва “Hello, <name>!”, където <name> е въведеното преди това име.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greetings
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Enter your name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
