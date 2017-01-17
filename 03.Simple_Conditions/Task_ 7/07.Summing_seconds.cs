/* Task #7: Сумиране на секунди
Трима спортни състезатели финишират за някакъв брой секунди (между 1 и 50). Да се напише програма, която въвежда времената на състезателите и пресмята сумарното им време във формат "минути:секунди". Секундите да се изведат с водеща нула (2  "02", 7  "07", 35  "35").*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Summing_seconds
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3;
            int minutes = sum / 60;
            int seconds = sum % 60;
            Console.WriteLine(minutes.ToString() + ":" + seconds.ToString());
            
            //int seconds = sum % 60;
            //int munutes = sum / 60;
            //if (seconds >= 10)
            //{
            //    Console.WriteLine("{minutes}:{seconds}.ToString().PadLeft(2, '0')");
            //}
            //else
            //{
            //    Console.WriteLine("{minutes}:{seconds}.ToString().PadLeft(2, '0')");
            //}
        }
    }
}
