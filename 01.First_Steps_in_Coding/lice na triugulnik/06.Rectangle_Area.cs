/* Задача 6: Лице на правоъгълник
Напишете C# програма, която прочита от конзолата две числа a и b, пресмята и отпечатва лицето на правоъгълник със страни a и b. Примерен вход и изход:
a	b	area
2	7	14
7	8	56
12	5	60*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lice_na_triugulnik
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("a = ");
            var a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("b = ");
            var b = decimal.Parse(Console.ReadLine());
            var sum = a * b;
            Console.WriteLine("The area of the rectangle is {0}.", sum);
        }
    }
}
