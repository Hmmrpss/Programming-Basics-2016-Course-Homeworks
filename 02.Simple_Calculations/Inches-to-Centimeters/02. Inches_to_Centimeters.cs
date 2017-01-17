//Задача 2: От инчове към сантиметри
// Да се напише програма, която чете от конзолата число (не непременно цяло) и преобразува числото от инчове в сантиметри. За целта умножава инчовете по 2.54 (защото 1 инч = 2.54 сантиметра).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to_Centimeters
{
    class Program
    {
        static void Main()
        {
            Console.Write("inches = ");
            var inches = double.Parse(Console.ReadLine());
            var centimeters = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.WriteLine(centimeters);
        }
    }
}
