/* Task #8: Конвертор за мерни единици
Да се напише програма, която преобразува разстояние между следните 8 мерни единици: m, mm, cm, mi, in, km, ft, yd. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Converter
    {
        static void Main()
        {
            double lenght = double.Parse(Console.ReadLine());            
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double lenghtinmeters = 0;
            double result = 0;
            if (from == "m")                //converting to length in meters
            {
                lenghtinmeters = lenght;
            }
            else if (from == "mm")
            {
                lenghtinmeters = lenght / 1000;
            }
            else if (from == "cm")
            {
                lenghtinmeters = lenght / 100;
            }
            else if (from == "mi")
            {
                lenghtinmeters = lenght / 0.000621371192;
            }
            else if (from == "in")
            {
                lenghtinmeters = lenght / 39.3700787;
            }
            else if (from == "km")
            {
                lenghtinmeters = lenght / 0.001;
            }
            else if (from == "ft")
            {
                lenghtinmeters = lenght / 3.2808399;
            }
            else if (from == "yd")
            {
                lenghtinmeters = lenght / 1.0936133;
            }

            if (to == "mm")
            {
                result = lenghtinmeters * 1000;
            }
            else if (to == "cm")
            {
                result = lenghtinmeters * 100;
            }
            else if (to == "mi")
            {
                result = lenghtinmeters * 0.000621371192;
            }
            else if (to == "in")
            {
                result = lenghtinmeters * 39.3700787;
            }
            else if (to == "km")
            {
                result = lenghtinmeters * 0.001;
            }
            else if (to == "ft")
            {
                result = lenghtinmeters * 3.2808399;
            }
            else if (to == "yd")
            {
                result = lenghtinmeters * 1.0936133;
            }
            else
            {
                result = lenghtinmeters;
            }
            Console.WriteLine(result + " " + to);
        }
    }
}