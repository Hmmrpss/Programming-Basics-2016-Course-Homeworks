/* 6.	Най-малко число
Напишете програма, която въвежда n цели числа (n > 0) и намира най-малкото измежду тях. Първо се въвежда броят числа n, а след това самите n числа, по едно на ред. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Min_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = 999999;
            for (int i = 0; i < n; i++)
            {
                int other = int.Parse(Console.ReadLine());
                if (other < min)
                {
                    min = other;
                }
            }
            Console.WriteLine("{0}", min);
        }
    }
}
