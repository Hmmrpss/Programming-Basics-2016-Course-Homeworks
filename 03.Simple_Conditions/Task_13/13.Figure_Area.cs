/*  Task #13: Лица на фигури
Да се напише програма, която въвежда размерите на геометрична фигура и пресмята лицето й. Фигурите са четири вида: квадрат (square), правоъгълник (rectangle), кръг (circle) и триъгълник (triangle). На първия ред на входа се чете вида на фигурата (square, rectangle, circle или  ). Ако фигурата е квадрат, на следващия ред се чете едно число – дължина на страната му. Ако фигурата е правоъгълник, на следващите два реда четат две числа – дължините на страните му. Ако фигурата е кръг, на следващия ред чете едно число – радиусът на кръга. Ако фигурата е триъгълник, на следващите два реда четат две числа – дължината на страната му и дължината на височината към нея. Резултатът да се закръгли до 3 цифри след десетичната точка. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Figure_area
    {
        static void Main()
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0.0;
            double h = 0.0;
            double r = 0.0;
            double area = 0.0;

            if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(area);
            }
            else if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "triangle")
            {
                a = float.Parse(Console.ReadLine());
                h = float.Parse(Console.ReadLine());
                area = (a * h) / 2.0;
                Console.WriteLine(Math.Round(area, 3));
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}
