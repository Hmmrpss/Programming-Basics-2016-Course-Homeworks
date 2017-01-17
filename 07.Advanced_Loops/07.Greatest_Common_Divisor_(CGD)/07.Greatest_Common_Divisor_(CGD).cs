/* Задача 7: Най-голям общ делител (НОД)
Напишете програма, която въвежда две цели положителни числа a и b и изчислява и отпечатва най-големият им общ делител (НОД).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int checker = 0;
            while (b != 0)
            {
                checker = b;
                b = a % b;
                a = checker;
            }
            Console.WriteLine(a);
        }
    }
}
