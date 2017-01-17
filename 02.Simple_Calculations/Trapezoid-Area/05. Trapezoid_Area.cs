// Задача 5: Лице на трапец
//Напишете програма, която чете от конзолата три числа b1, b2 и h и пресмята лицето на трапец с основи b1 и b2 и височина h. Формулата за лице на трапец е (b1 + b2) * h / 2.
//На фигурата по-долу е показан трапец със страни 8 и 13 и височина 7. Той има лице (8 + 13) * 7 / 2 = 73.5.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trapezoid_Area
{
    class Program
    {
        static void Main()
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var area = (b1 + b2) * h / 2;
            Console.WriteLine("Trapezoid area = " + area);
        }
    }
}

