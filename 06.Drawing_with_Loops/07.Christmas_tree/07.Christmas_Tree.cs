
/* Задача 7: Коледна елха
Напишете програма, която въвежда число n (1 ≤ n ≤ 100) и печата коледна елха с размер n*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Christmas_tree
{
    class Christmas_Tree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool valid_values = ((1 <= n) && (n <= 100)); 
            if (valid_values)
            {
                for (int body = 0; body <= n; body++)
                {  
                    Console.Write(new string (' ', n-body));                                         //
                    Console.Write(new string('*', body));
                    Console.Write(" | ");
                    Console.Write(new string('*', body));
                    Console.Write(new string(' ', n - body));
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
