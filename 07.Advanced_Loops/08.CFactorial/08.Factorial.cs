/* Задача 8: Факториел
Напишете програма, която въвежда цяло число n (1 ≤ n ≤ 12) и изчислява и отпечатва n! = 1 * 2 * … * n (n факториел). 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CFactorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;
            if (1 <= n || n <= 12)
            {
                for (int i = 1; i <= n; i++)
                {
                    number *= i;
                }
                Console.WriteLine(number);
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
