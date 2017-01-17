/* 5. Невалидно число
Дадено число е валидно, ако е в диапазона [100…200] или е 0. Да се напише програма, която въвежда цяло число и печата “invalid” ако въведеното число не е валидно. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    class invalid_number
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200 || number == 0)
            {
                
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
