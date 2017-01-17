/* 16.	* Елемент, равен на сумата на останалите
Да се напише програма, която въвежда n цели числа и проверява дали сред тях съществува число, което е равно на сумата на всички останали. Ако има такъв елемент, печата "Yes" + неговата стойност; иначе печата "No" + разликата между най-големия елемент и сумата на останалите (по абсолютна стойност). 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Half_Sum_Element
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int number = 0;
            int sum = 0;
            int max = int.MinValue; //?
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (number > max)
                {
                    max = number;
                }
                sum += number;
            }
            sum = sum - max;
            if (sum == max)
            {
                Console.WriteLine("Yes Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(sum - max));
            }
        }
    }
}
