//Задача 2:	Числата от N до 1 в обратен ред
// Напишете програма, която въвежда цяло положително число n и печата числата от n до 1 в обратен ред (от най-голямото към най-малкото).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Numbers_From_N_to_1_in_reverse
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n; i > 0; i -= 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
