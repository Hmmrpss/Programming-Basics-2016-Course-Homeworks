/* 8. Търговски комисионни
Фирма дава следните комисионни на търговците си според града, в който работят и обема на продажбите. Напишете конзолна програма, която чете име на град (стринг) и обем на продажби (десетично число) и изчислява и извежда размера на търговската комисионна според горната таблица. Резултатът да се изведе закръглен с 2 цифри след десетичната точка. При невалиден град или обем на продажбите (отрицателно число) да се отпечата “error”. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_8
{
    class Trade_Comissions
    {
        static void Main()
        {
            var city = Console.ReadLine().ToLower();
            var sales = double.Parse(Console.ReadLine());
            double comission = 0;

            bool validvalues = (sales < 0);
            switch (city)
                {
                case "sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = (sales * 5) / 100;
                        Console.WriteLine("{0:f2}", comission);
                        
                    }
                    else if (sales >= 501 && sales <= 1000)
                    {
                        comission = (sales * 7) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales >= 1001 && sales <= 10000)
                    {
                        comission = (sales * 8) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales > 10001)
                    {
                        comission = (sales * 12) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "varna":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = (sales * 4.5) / 100;
                        Console.WriteLine("{0:f2}", comission);

                    }
                    else if (sales >= 501 && sales <= 1000)
                    {
                        comission = (sales * 7.5) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales >= 1001 && sales <= 10000)
                    {
                        comission = (sales * 10) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales > 10001)
                    {
                        comission = (sales * 13) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "plovdiv":
                    if (sales >= 0 && sales <= 500)
                    {
                        comission = (sales * 5.5) / 100;
                        Console.WriteLine("{0:f2}", comission);

                    }
                    else if (sales >= 501 && sales <= 1000)
                    {
                        comission = (sales * 8) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales >= 1001 && sales <= 10000)
                    {
                        comission = (sales * 12) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else if (sales > 10000)
                    {
                        comission = (sales * 14.5) / 100;
                        Console.WriteLine("{0:f2}", comission);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    break;

                default:
                    Console.WriteLine("error");
                    break;
               }
        }
    }
}
