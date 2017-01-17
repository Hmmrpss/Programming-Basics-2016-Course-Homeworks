/* Задача 9: Сумиране на цифрите на число
Напишете програма, която въвежда цяло число num и отпечатва сумата от цифрите му. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_of_the_Digits_in_a_Number
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            while (n % 10 > 0)
            {
                sum += n % 10;
                n = n / 10;
            }
            Console.WriteLine(sum);  
        }
    }
}
