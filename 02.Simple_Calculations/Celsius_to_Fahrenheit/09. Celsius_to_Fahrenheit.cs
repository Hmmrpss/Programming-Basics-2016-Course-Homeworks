// Задача 9: Конзолен конвертор: от градуси °C към градуси °F
//Напишете програма, която чете градуси по скалата на Целзий (°C) и ги преобразува до градуси по скалата на Фаренхайт (°F). Потърсете в Интернет подходяща формула, с която да извършите изчисленията. Закръглете резултата до 2 знака след десетичната точка. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class Program
    {
        static void Main()
        {
            var celsius = double.Parse(Console.ReadLine());
            var fahrenheit = ((celsius * 9) / 5) + 32;
            Console.WriteLine(Math.Round(fahrenheit, 2));
        }
    }
}
