/* Задача 8: Слънчеви очила
Напишете програма, която въвежда цяло число n (3 ≤ n ≤ 100) и печата слънчеви очила с размер 5*n x n*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sunglasses
{
    class Sunglasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool valid_values = ((3 <= n) && (n <= 100));
            
            if (valid_values)
	        {
                ////////// First row
                Console.Write(new string ('*', n*2));
                Console.Write(new string (' ', n));
                Console.Write(new string ('*', n*2));
                Console.WriteLine();
                ////////// Second row
                for (int rows = 0; rows < n-2; rows++)
                {
                    Console.Write('*' + new string('/', 2*n - 2) + '*');
                    char filler = ' ';     /////// you can do it without it too

                    if (rows == (((n - 1) / 2) - 1))
	                {
                        filler = '|';
		                Console.Write(new string (filler, n));
	                }
                    else
                    {
                        Console.Write(new string(filler, n));
                    }
                    Console.WriteLine('*' + new string('/', 2*n - 2) + '*');                   
                }
                ////////// Third row
                Console.Write(new string('*', n * 2));
                Console.Write(new string(' ', n));
                Console.Write(new string('*', n * 2));		       
	        }
            else
            {
                Console.WriteLine("Invalid input!");
            }

        }
    }
}
