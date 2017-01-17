/* Задача 10: Диамант
Напишете програма, която въвежда цяло число n (1 ≤ n ≤ 100) и печата диамант с размер n */ 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Diamond
{
    class Diamond
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool odd = ((n % 2) == 1);
            bool valid_value = ((n >= 1) && (n <= 100));
            if (valid_value)
            {
                switch (n)
                {
                    case 1:
                        Console.WriteLine(new string('*', n));
                        break;
                    case 2:
                        Console.WriteLine(new string('*', n));
                        break;
                    default:
                        if (n % 2 == 0)
                        {
                            n -= 1;
                        }
                        if (odd)                               
                            {
                            Console.Write(new string('_', (n / 2)));
                            Console.Write('*');
                            Console.Write(new string('_', (n / 2)));
                            Console.WriteLine("odd");
                            for (int first_half = 0; first_half < n / 2; first_half++)   /*filler*/ 
                                {
                                Console.Write(new string('_', (((n / 2) - first_half) - 1)));
                                Console.Write('*');
                                Console.Write(new string('_', (1 + 2 * first_half)));
                                Console.Write('*');
                                Console.Write(new string('_', (((n / 2) - first_half) - 1)));
                                Console.WriteLine("first half");
                                }
                            for (int lower_half = 0; lower_half < ((n / 2) - 1); lower_half++)
                                {
                                Console.Write(new string('_', (lower_half + 1)));
                                Console.Write('*');
    /*CHECK IT OUT */           Console.Write(new string('_', (((n - 4) - 2 * lower_half))));   // pri 9 e s 1 po-malko
                                Console.Write('*');
                                Console.Write(new string('_', (lower_half + 1)));
                                Console.WriteLine("lower half");
                                }
                            Console.Write(new string('_', (n / 2)));
                            Console.Write('*');
                            Console.Write(new string('_', (n / 2)));
                            Console.WriteLine("odd");
                            }
                        else
                            {
                            Console.Write(new string('_', (n / 2)));
                            Console.Write("**");
                            Console.Write(new string('_', (n / 2)));
                            Console.WriteLine("even");
                            for (int first_half = 0; first_half < n / 2; first_half++)        /*filler*/
                                {
                                Console.Write(new string('_', (((n / 2) - first_half) - 1)));
                                Console.Write('*');
                                Console.Write(new string('_', (2 + 2*first_half)));
                                Console.Write('*');
                                Console.Write(new string('_', (((n / 2) - first_half) - 1)));
                                Console.WriteLine("first half");
                                }
                            for (int lower_half = 0; lower_half < ((n / 2) - 1); lower_half++)
                                {
                                Console.Write(new string('_', (lower_half + 1)));
                                Console.Write('*');
    /*CHECK IT OUT */           Console.Write(new string('_', ((((n / 2) - 2 * lower_half) + 1)))); // 6 i 5  ima 1 v poveche
                                Console.Write('*');
                                Console.Write(new string('_', (lower_half + 1)));
                                Console.WriteLine("lower half");
                                }
                            Console.Write(new string('_', (n / 2)));
                            Console.Write("**");
                            Console.Write(new string('_', (n / 2)));
                            Console.WriteLine("even");
                            }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid value!");
            }
        }
    }
}