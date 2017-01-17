//Задача 3: Числа от 20 до 2n
// Напишете програма, която чете от конзолата цяло число n и печата числата от 1 до 2n. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_2_from_0_to_N
{
    class Program
    {
        static void Main()
         {
            int n = int.Parse(Console.ReadLine());
            int baseNumber = 1;
            Console.WriteLine('1');     // How to get it in the cycle?
            for (int i = 0; i < n; i++)
            {
                baseNumber *= 2;
                Console.WriteLine(baseNumber);
            }
        }
    }
}
