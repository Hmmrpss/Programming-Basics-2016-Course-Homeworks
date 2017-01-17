/* 18.	* Еднакви двойки
Дадени са 2*n числа. Първото и второто формират двойка, третото и четвъртото също и т.н. Всяка двойка има стойност – сумата от съставящите я числа. Напишете програма, която проверява дали всички двойки имат еднаква стойност или печата максималната разлика между две последователни двойки. Ако всички двойки имат еднаква стойност, отпечатайте "Yes, value=…" + стойността. В противен случай отпечатайте "No, maxdiff=…" + максималната разлика. 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Equal_Pairs
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int prev_sum = 0;
            int current_sum = 0;
            int differace = 0;
            int max_differance = 0;
            for (int i = 0; i < n; i++)
            {
                prev_sum = current_sum;
                current_sum = 0;
                current_sum += int.Parse(Console.ReadLine());
                current_sum += int.Parse(Console.ReadLine());
                if (i != 0)
                {
                    differace = Math.Abs(current_sum - prev_sum);
                    if (differace != 0 && differace > max_differance)
                    {
                        max_differance = differace;
                    }
                }
            }
            if (prev_sum == current_sum || n == 1)
            {
                Console.WriteLine("Yes, value={0}", current_sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", max_differance);
            }
        }
    }
}
