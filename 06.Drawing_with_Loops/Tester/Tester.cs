
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Tester
    {
        static void Main()
        
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 == 1) //ODD NUMBER
            {
                Console.Write(new string('-', (n / 2)));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', (n / 2)));
                Console.WriteLine();
                for (int i = 0; i < (n - 1); i++)
                {
                    if (i < (n / 2) )
                    {
                        Console.Write(new string('-', (((n / 2) - 1) - i)));
                        Console.Write('*');
                        Console.Write(new string('-', (n - (2*(((n / 2) - 1) - i) + 2))));
                        Console.Write('*');
                        Console.WriteLine(new string('-', (((n / 2) - 1) - i)));
                    }
                    else
                    {
                        Console.Write(new string('-', (i - (n / 2) + 1)));
                        Console.Write('*');
                        Console.Write(new string('-', (n - 2 - (2 * ((i - (n / 2) + 1))))));
                        Console.Write('*');
                        Console.WriteLine(new string('-', (i - (n / 2) + 1)));
                    }
                   // Console.WriteLine();
                }
                Console.Write(new string('-', (n / 2)));
                Console.Write(new string('*', 1));
                Console.Write(new string('-', (n / 2)));
                Console.WriteLine();
            }

            if (n % 2 == 0) //EVEN NUMBER == DONE
            {
                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write(new string('-', Math.Abs((n / 2) - 1 - i)));
                    Console.Write('*');
                    if (i < n / 2)
                        {
                             Console.Write(new string('-', (i * 2)));
                        }
                    else
                        {
                            Console.Write(new string('-', (((n - 2) - 2 * (Math.Abs((n / 2) - 1 - i))))));
                        }
                    Console.Write('*');
                    Console.Write(new string('-', Math.Abs((n / 2) - 1 - i)));
                    Console.WriteLine();
                }
            }
        }
    }
}
/*int n = int.Parse(Console.ReadLine());
           Console.WriteLine("%, {0}", (n  % (n-1))); // ostatuk
           Console.WriteLine("/, {0}", (n / (n-1)));*/
