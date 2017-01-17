// Задача 8: Лице на триъгълник
//Напишете програма, която чете от конзолата страна и височина на триъгълник и пресмята неговото лице. Използвайте формулата за лице на триъгълник: area = a * h / 2. Закръглете резултата до 2 знака след десетичната точка използвайки Math.Round(area, 2).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (a * h) / 2;
            Console.WriteLine("Triangle area = " + Math.Round(area, 2));
        }
    }
}
