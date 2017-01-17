/* 4.	Сумиране на числа
Да се напише програма, която въвежда n цели числа и ги сумира.
•	От първия ред на входа се въвежда броят числа n.
•	От следващите n реда се въвежда по едно цяло число.
Програмата трябва да прочете числата, да ги сумира и да отпечата сумата им. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Sum_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                sum = sum + number;
            }

            Console.WriteLine("{0}", sum);
        }
    }
}
