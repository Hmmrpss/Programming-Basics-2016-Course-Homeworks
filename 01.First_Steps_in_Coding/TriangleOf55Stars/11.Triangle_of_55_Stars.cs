/* Задача 11: Триъгълник от 55 звездички
Напишете C# конзолна програма, която отпечатва триъгълник от 55 звездички, разположени на 10 реда*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(new string('*', i));
            }
        }
    }
}
