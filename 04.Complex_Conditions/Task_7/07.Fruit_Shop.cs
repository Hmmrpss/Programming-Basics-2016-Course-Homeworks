/* 7. Магазин за плодове
Магазин за плодове през работните дни работи на следните цени... Събота и неделя магазинът работи на по-високи цени. Напишете програма, която чете от конзолата плод (banana / apple / orange / grapefruit / kiwi / pineapple / grapes), ден от седмицата (Monday / Tuesday / Wednesday / Thursday / Friday / Saturday / Sunday) и количество (десетично число) и пресмята цената според цените от таблиците по-горе. Резултатът да се отпечата закръглен с 2 цифри след десетичната точка. При невалиден ден от седмицата или невалидно име на плод да се отпечата “error”. */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class fruit_shop
    {
        static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var dayoftheweek = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            double value = 0;
            bool weekday = (dayoftheweek == "monday" || dayoftheweek == "tuesday"|| dayoftheweek == "wednesday" || dayoftheweek == "thursday" || dayoftheweek == "friday");
            bool weekend= (dayoftheweek == "saturday" || dayoftheweek == "sunday");

            if (weekday)
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:f2}", quantity * 2.5);
                        break;
                    case "apple":
                        Console.WriteLine("{0:f2}", quantity * 1.2);
                        break;
                    case "orange":
                        Console.WriteLine("{0:f2}", quantity * 0.85);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:f2}", quantity * 1.45);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:f2}", quantity * 2.7);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:f2}", quantity * 5.5);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:f2}", quantity * 3.85);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (weekend)
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:f2}", quantity * 2.7);
                        break;
                    case "apple":
                        Console.WriteLine("{0:f2}", quantity * 1.25);
                        break;
                    case "orange":
                        Console.WriteLine("{0:f2}", quantity * 0.9);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:f2}", quantity * 1.6);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:f2}", quantity * 3);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:f2}", quantity * 5.6);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:f2}", quantity * 4.2);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }  
            }
            else
	        {
                Console.WriteLine("error");
	        }
        }
    }
}