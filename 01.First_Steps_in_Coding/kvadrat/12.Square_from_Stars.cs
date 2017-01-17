/* Задача 12: Квадрат от звездички
Напишете C# конзолна програма, която прочита от конзолата цяло положително число N и отпечатва на конзолата квадрат от N звездички, */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadrat
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Kolko golqm iskash da e kvadrata?");
            var a = int.Parse(Console.ReadLine());
            string firstrow = new string('*', a);
            Console.WriteLine(firstrow);
                        for (int i = 0; i < a - 2; i++)
            {
                Console.WriteLine("*" + new string (' ', a - 2) + "*");
                
            }
                        Console.WriteLine(firstrow);
        }
    }
}
