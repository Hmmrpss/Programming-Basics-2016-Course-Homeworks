//Задача 1: Числата от 1 до N през 3
// Напишете програма, която въвежда число n и отпечатва числата от 1 до n през 3 (със стъпка 3). 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers_1_to_N_with_Step_3
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
