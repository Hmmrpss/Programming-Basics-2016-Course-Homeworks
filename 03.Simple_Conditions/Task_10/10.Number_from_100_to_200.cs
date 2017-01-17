/* Task #10:  Число от 100 до 200
Да се напише програма, която въвежда цяло число и проверява дали е под 100, между 100 и 200 или над 200. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Number_from_100_to_200
    {
        static void Main() 
         {
            int number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
