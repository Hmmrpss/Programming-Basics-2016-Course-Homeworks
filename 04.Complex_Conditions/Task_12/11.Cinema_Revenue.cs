/* 11. Кино
В една кинозала столовете са наредени в правоъгълна форма в r реда и c колони. Има три вида прожекции с билети на различни цени:
•	Premiere – премиерна прожекция, на цена 12.00 лева.
•	Normal – стандартна прожекция, на цена 7.50 лева.
•	Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.
Напишете програма, която въвежда тип прожекция (стринг), брой редове и брой колони в залата (цели числа) и изчислява общите приходи от билети при пълна зала. Резултатът да се отпечата във формат като в примерите по-долу, с 2 знака след десетичната точка. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class cinema_revenue
    {
        static void Main()
        {
            var typeofscreening = Console.ReadLine().ToLower();
            var row = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            double price = 0;
            double totalrevenue = 0;

            switch (typeofscreening)
            {
                case "premiere":
                    price = 12.00;
                    totalrevenue = row * columns * price;
                    Console.WriteLine("{0:f2} leva", totalrevenue);
                    break;
                case "normal":
                    price = 7.50;
                    totalrevenue = row * columns * price;
                    Console.WriteLine("{0:f2} leva", totalrevenue);
                    break;
                case "discount":
                    price = 5.00;
                    totalrevenue = row * columns * price;
                    Console.WriteLine("{0:f2} leva", totalrevenue);
                    break;
            }
        }
    }
}
