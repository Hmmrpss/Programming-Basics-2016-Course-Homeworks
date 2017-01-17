//Задача 4: Четни степени на 2
// Да се напише програма, която въвежда n и печата четните степени на 2 ≤ 2n: 20, 22, 24, 28, …, 2n. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program      
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            for (int i = 0; i <= n; i+=2)
                {
                    Console.WriteLine(num);
                    num = num * 2 * 2;
                }
        }
    }
}