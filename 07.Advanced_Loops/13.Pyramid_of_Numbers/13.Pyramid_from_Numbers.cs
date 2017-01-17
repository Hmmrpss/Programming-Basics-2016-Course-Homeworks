/* Задача 13: Пирамида от числа
Напишете програма, която въвежда цяло число n и отпечатва пирамида от числа 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Pyramid_from_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            for (int row = 1; row <= n; row++)
                {
                    for (int col = 1; col <= row; col++)
                    {
                        if (col > 1)
	                    {
		                    Console.Write(' ');
	                    }
                        Console.Write(current);
                        current++;
                        if (current > n)
                        {
                            break;
                        }
                    }
	                Console.WriteLine();
                    if (current > n)
                    {
                        break;
                    }
                }
            }
        }
    }
}
