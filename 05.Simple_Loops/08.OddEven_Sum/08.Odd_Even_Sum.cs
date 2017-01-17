/* 8.	Четна / нечетна сума
Да се напише програма, която въвежда n цели числа и проверява дали сумата от числата на четни позиции е равна на сумата на числата на нечетни позиции. При равенство да се отпечата "Yes" + сумата; иначе да се отпечата "No" + разликата. Разликата се изчислява по абсолютна стойност. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.OddEven_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int evensum = 0;
            int oddsum = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += number;
                }
                else
                {
                    oddsum += number;
                }
            }
            if (oddsum == evensum)
            {
                Console.WriteLine("yes sum {0}", evensum);
            }
            else
            {
                Console.WriteLine("no diff {0}", Math.Abs(evensum - oddsum));
            }
        }
    }
}
