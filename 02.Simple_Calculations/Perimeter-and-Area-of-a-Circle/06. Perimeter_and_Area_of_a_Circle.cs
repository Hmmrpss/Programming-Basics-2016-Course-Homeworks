// Задача 6: Периметър и лице на кръг
//Напишете програма, която чете от конзолата число r и пресмята и отпечатва лицето и периметъра на кръг / окръжност с радиус r.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perimeter_and_Area_of_a_Circle
{
    class Program
    {
        static void Main()
        {
            var r = double.Parse(Console.ReadLine());
            var area = Math.PI * r * r;
            var perimeter = 2 * Math.PI * r;
            Console.WriteLine("Area = " + area);
            Console.WriteLine("Perimeter = %.4f\n", perimeter);
        }
    }
}
