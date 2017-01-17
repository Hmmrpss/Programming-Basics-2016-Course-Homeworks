/* Задача 12: Конзолен междувалутен конвертор
Напишете програма за конвертиране на парична сума от една валута в друга. Трябва да се поддържат следните валути: BGN, USD, EUR, GBP. Използвайте следните фиксирани валутни курсове:
Курс	USD	EUR	GBP
1 BGN	1.79549	1.95583	2.53405
Входът e сума за конвертиране + входна валута + изходна валута. Изходът е едно число – преобразуваната сума по посочените по-горе курсове, закръглен до 2 цифри след десетичната точка.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// look it up!!!
namespace Currency_Converter
{
    class Currency_Converter
    {
        static void Main()
        {
            double amount = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double bgnconverter = 0;
            double result = 0;
            if (from == "BGN")                //converting to length in meters
            {
                bgnconverter = amount;
            }
            else if (from == "USD")
            {
                bgnconverter = amount * 1.79549;
            }
            else if (from == "EUR")
            {
                bgnconverter = amount * 1.95583;
            }
            else if (from == "GBP")
            {
                bgnconverter = amount * 2.53405;
            }
            
            if (to == "BGN")
            {
                result = bgnconverter;
            }
            else if (to == "USD")
            {
                result = bgnconverter / 1.79549;
            }
            else if (to == "EUR")
            {
                result = bgnconverter / 1.95583;
            }
            else if (to == "GBP")
            {
                result = bgnconverter / 2.53405;
            }
            
            Console.WriteLine(Math.Round(result, 2) + " " + to);
            }
    }
}
