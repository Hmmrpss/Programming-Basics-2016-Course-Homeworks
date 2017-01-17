/* Задача 1: Правоъгълник от 10 x 10 звездички
Напишете програма, която чертае на конзолата правоъгълник от 10 x 10 звездички:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_10_by_10
{
    class Rectangle_10_by_10
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {

                for (int p = 0; p < 10; p++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
