/* 5.	Най-голямо число
Напишете програма, която въвежда n цели числа (n > 0) и намира най-голямото измежду тях. Първо се въвежда броят числа n, а след това самите n числа, по едно на ред. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Max_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = int.Parse(Console.ReadLine());
            int max = number;
            int other = 0;
            for (int i = 0; i < n - 1; i++)
            {
                other = int.Parse(Console.ReadLine());
                if (other > number)
                {
                    max = other;
                }
            }
            Console.WriteLine("{0}", max);
        }
    }
}
