// Task #3: Четно или нечетно Да се напише програма, която въвежда цяло число и печата дали е четно или нечетно.//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Even_or_odd
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
