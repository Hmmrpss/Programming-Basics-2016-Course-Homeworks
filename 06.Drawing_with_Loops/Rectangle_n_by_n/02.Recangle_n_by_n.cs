/* Задача 2: Правоъгълник от N x N звездички
Напишете програма, която въвежда цяло положително число n и печата на конзолата правоъгълник от n * n звездички. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_n_by_n
{
    class Recangle_n_by_n
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {

                for (int p = 0; p < n; p++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}
