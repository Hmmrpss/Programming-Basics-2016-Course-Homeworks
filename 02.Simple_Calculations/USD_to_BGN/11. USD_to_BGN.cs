// Задача 11: Конзолен конвертор: USD към BGN
//Напишете програма за конвертиране на щатски долари (USD) в български лева (BGN). Закръглете резултата до 2 цифри след десетичната запетая. Използвайте фиксиран курс между долар и лев: 1 USD = 1.79549 BGN.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class Program
    {
        static void Main()
        {
            var usd = double.Parse(Console.ReadLine());
            var bgn = usd * 1.79549;
            Console.WriteLine(Math.Round(bgn, 2));
        }
    }
}
