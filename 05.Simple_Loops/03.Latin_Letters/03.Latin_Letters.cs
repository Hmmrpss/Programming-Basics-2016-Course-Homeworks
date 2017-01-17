/* 3.	Всички латински букви
Напишете програма, която отпечатва всички букви от латинската азбука: a, b, c, …, z.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Latin_Letters
{
    class Program
    {
        static void Main()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            foreach (char c in alphabet)
            {
                Console.WriteLine(c);
            }
        }
    }
}
