// Task #4: Намиране на по-голямото число. Да се напише програма, която въвежда две цели числа и отпечатва по-голямото от двете. //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Greater_number
    {
        static void Main()
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
        }
    }
}
