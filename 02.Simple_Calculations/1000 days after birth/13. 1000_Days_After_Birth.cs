// Задача 13: Пресмятане с дати: 1000 дни на Земята
//Напишете програма, която въвежда рождена дата във формат “dd-MM-yyyy” и пресмята датата, на която се навършват 1000 дни от тази рождена дата и я отпечатва в същия формат.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateofbirth = DateTime.Parse(Console.ReadLine());
            DateTime result = ateofbirth.AddDays(999);
            Console.WriteLine(result.ToString("dd-MM-yyyy"));
        }
    }
}