/* /* Напишете програма, която отпечатва числата от 1 до 100, по едно на ред.
вход	изход
(няма)	1
2
3
…
98
99
100
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_from_1_to_100
{
    class Program
    {
        static void Main()
        {
            var number = 0;
            for (int i = 1; i < 101; i++)
            {
                number = i;
                Console.WriteLine(number);
            }
        }
    }
}
