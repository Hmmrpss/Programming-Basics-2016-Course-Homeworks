/* Задача 4: Триъгълник от долари
Да се напише програма, която въвежда число n и печата триъгълник от долари.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trisngle_with_dollar_signs
{
    class Trisngle_with_dollar_signs
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int p = 0; p < i; p++)
                {
                    Console.Write('$');
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
