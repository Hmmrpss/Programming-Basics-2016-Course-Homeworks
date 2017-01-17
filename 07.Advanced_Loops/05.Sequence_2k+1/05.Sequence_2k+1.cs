/* Задача 5: Редица числа 2k+1
Напишете програма, която въвежда число n и отпечатва всички числа ≤ n от редицата: 1, 3, 7, 15, 31, …. Всяко следващо число се изчислява като предишното число * 2 + 1. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Sequence_2k_1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            while (number <= n)
            {
                Console.WriteLine(number);
                number = 2 * number + 1;
            }
        }
    }
}
