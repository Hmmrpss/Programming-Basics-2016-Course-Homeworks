/* Задача 3: Квадрат от звездички
Напишете програма, която чете от конзолата число n и чертае квадрат от n * n звездички. Разликата с предходната задача е, че между всеки две звездички има по един интервал. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_with_stars
{
    class Square_with_stars
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                for (int p = 0; p < n; p++)
                {
                    Console.Write('*');
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
