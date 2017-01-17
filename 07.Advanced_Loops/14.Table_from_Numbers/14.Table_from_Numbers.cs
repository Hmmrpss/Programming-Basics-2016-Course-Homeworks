/* Задача 14: Таблица с числа
Напишете програма, която въвежда цяло число n и отпечатва таблица (матрица) от числа
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Table_from_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)          // +
            {
                Console.Write(row);
                for (int col = 1; col <= n-1; col++)
                {
                    if ((row + col) > n)
                    {
                        break;
                    }
                    Console.Write(' ');
                    Console.Write(row + col);
                }
                Console.WriteLine();
            }
            for (int row = 1; row <= n; row++)          // -
            {
                Console.Write(row);
                for (int col = 1; col <= n - 1; col++)
                {
                    if ((row + col) > n)
                    {
                        break;
                    }
                    Console.Write(' ');
                    Console.Write(row + col);
                }
                Console.WriteLine();
            }
        }
    }
}
