/* Задача 6: Ромбче от звездички
Напишете програма, която въвежда цяло положително число n и печата ромбче от звездички с размер n */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Romb_from_stars
{
    class Romb_from_stars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n != 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string(' ', n  - i));
                    Console.Write('*');
                    for (int j = 1; j  < i ; j++)
                    {
                        Console.Write(" *"); 
                    }
                    Console.WriteLine();
                }
                for (int i = 1; i < n; i++)
                {
                    Console.Write(new string(' ', i));
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write("* ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine('*');
            }
        }
    }
}
