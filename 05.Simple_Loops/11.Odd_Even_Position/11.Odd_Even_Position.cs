/* 17.	* Четни / нечетни позиции
Напишете програма, която чете n числа и пресмята сумата, минимума и максимума на числата на четни и нечетни позиции (броим от 1). Когато няма минимален / максимален елемент, отпечатайте “No”. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Even_Position
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            float number = 0;
            float OddSum = 0;
            float OddMin = 0;
            float OddMax = 0;
            float EvenSum = 0;
            float EvenMin = 0;
            float EvenMax = 0;
            for (int i = 1; i <= n; i++)
            {
                number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    EvenSum += number;
                    if (number < EvenMin)
                    {
                        EvenMin = number;
                    }
                    if (number > EvenMax)
                    {
                        EvenMax = number;
                    }
                }
                else
                {
                    OddSum += number;

                    if (number < OddMin)
                    {
                        OddMin = number;
                    }
                    if (number > OddMax)
                    {
                        OddMax = number;
                    }
                }

            }


            if (n == 0)
            {
                Console.WriteLine("OddSum = 0,");
                Console.WriteLine("OddMin = No,");
                Console.WriteLine("OddMax = No,");
                Console.WriteLine("EvenSum = 0,");
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");
            }
            else if (n == 1)
            {
                Console.WriteLine("OddSum = {0}", OddSum);
                Console.WriteLine("OddMin = {0}", OddMin);
                Console.WriteLine("OddMax = {0}", OddMax);
                Console.WriteLine("EvenSum = 0,");
                Console.WriteLine("EvenMin = No,");
                Console.WriteLine("EvenMax = No");
            }
            else
            {
                Console.WriteLine("OddSum = {0}", OddSum);
                Console.WriteLine("OddMin = {0}", OddMin);
                Console.WriteLine("OddMax = {0}", OddMax);
                Console.WriteLine("EvenSum = {0}", EvenSum);
                Console.WriteLine("EvenMin = {0}", EvenMin);
                Console.WriteLine("EvenMax = {0}", EvenMax);
            }
        }
    }
}
