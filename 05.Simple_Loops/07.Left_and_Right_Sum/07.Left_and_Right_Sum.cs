/* 7.	Лява и дясна сума
Да се напише програма, която въвежда 2*n цели числа и проверява дали сумата на първите n числа (лява сума) е равна на сумата на вторите n числа (дясна сума). При равенство печата "Yes" + сумата; иначе печата "No" + разликата. Разликата се изчислява като положително число (по абсолютна стойност). 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Left_and_Right_Sum
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int leftsum = 0;
            int rightsum = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                leftsum += num;
            }
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                rightsum += num;
            }
            if (leftsum == rightsum)
            {
                Console.WriteLine("yes sum {0}", leftsum);
            }
            else
            {
                Console.WriteLine("no diff {0}", Math.Abs(leftsum - rightsum));
            }
        }
    }
}
