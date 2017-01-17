/* Задача 9: Къщичка
Напишете програма, която въвежда число n (2 ≤ n ≤ 100) и печата къщичка с размер n x n:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.House
{
    class House
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 == 0) //EVEN NUMBER
            {
                //upper part
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.Write(new string('-', ((n - (2 + (2 * i))) / 2)));
                    Console.Write(new string('*', (2 + (2 * i))));
                    Console.Write(new string('-', ((n - (2 + (2 * i))) / 2)));
                    Console.WriteLine();
                }
                //lower part
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
            }

            if (n % 2 == 1) //ODD NUMBER
            {
                //upper part
                for (int i = 0; i < ((n + 1) / 2); i++)
                {
                    Console.Write(new string('-', ((n - (1 + (2 * i))) / 2)));
                    Console.Write(new string('*', (1 + (2 * i))));
                    Console.Write(new string('-', ((n - (1 + (2 * i))) / 2)));
                    Console.WriteLine();
                }
                //lower part
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
            }
        }
    }
}
/*
            int n = int.Parse(Console.ReadLine());
            int numberType = 0;
            if (n % 2 == 0) //EVEN NUMBER
            {
                numberType = 2;
            }

            if (n % 2 == 1) //ODD NUMBER
            {
                numberType = 1;
            }
 *              //upper part
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.Write(new string('-', ((n - (2 + (2 * i))) / 2)));
                    Console.Write(new string('*', (numberType + (2 * i))));
                    Console.Write(new string('-', ((n - (2 + (2 * i))) / 2)));
                    Console.WriteLine();
                }
                //lower part
                for (int i = 0; i < (n / 2); i++)
                {
                    Console.Write('|');
                    Console.Write(new string('*', n - 2));
                    Console.Write('|');
                    Console.WriteLine();
                }
*/