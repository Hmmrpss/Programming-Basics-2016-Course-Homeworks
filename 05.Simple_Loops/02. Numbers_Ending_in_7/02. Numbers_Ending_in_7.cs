/* 2.	Числа до 1000, завършващи на 7
Напишете програма, която отпечатва числата в диапазона [1…1000], които завършват на 7.
вход	изход
(няма)	7
17
27
…
997
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_Ending_in_7
{
    class Program
    {
        static void Main()
        {
            var number = 0;
            for (int i = 1; i < 1000; i++)
            {
                number = i;
                if (number % 10 == 7)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
