/* Задача 5: Квадратна рамка
Напишете програма, която въвежда цяло положително число n и чертае на конзолата квадратна рамка с размер n * n 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Square_Frame
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("+ ");
                    break;
                case 2:
                    Console.Write("+ +");
                    break;
            }
            if (n >= 3)
            {
                for (int firsrow = 0; firsrow < 1; firsrow++)
                {
                    Console.Write("+ ");
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write('-');
                        Console.Write(' ');
                    }
                    Console.WriteLine('+');
                }
                for (int filler = 0; filler < n - 2; filler++)
                {
                    Console.Write("| ");
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write("- ");
                    }
                    Console.WriteLine('|');
                }
                for (int lastrow = 0; lastrow < 1; lastrow++)
                {
                    Console.Write("+ ");
                    for (int i = 0; i < n - 2; i++)
                    {
                        Console.Write('-');
                        Console.Write(' ');
                    }
                    Console.WriteLine('+');
                }
                //for (1, 2)
            }
            
        }
    }
}
