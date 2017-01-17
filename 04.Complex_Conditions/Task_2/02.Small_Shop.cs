/* 2. Квартално магазинче
Следващата задача има за цел да тренира работата с вложени проверки (nested if). Ето го и условието: предприемчив българин отваря квартални магазинчета в няколко града и продава на различни цени. Напишете програма, която чете от конзолата град (стринг), продукт (стринг) и количество (десетично число) и пресмята и отпечатва колко струва съответното количество от избрания продукт в посочения град. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class small_shop
    {
        static void Main()
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower(); 
            var productquantity = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(productquantity * 0.5);
                }
                else if (product == "water")
                {
                    Console.WriteLine(productquantity * 0.8);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(productquantity * 1.2);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(productquantity * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(productquantity * 1.6);
                }
            }
            else if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(productquantity * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(productquantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(productquantity * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(productquantity * 1.30);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(productquantity * 1.5);
                }
            }
            else if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(productquantity * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(productquantity * 0.7);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(productquantity * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(productquantity * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(productquantity * 1.55);
                }
            }
        }
    }
}