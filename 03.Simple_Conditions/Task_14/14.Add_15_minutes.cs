/*  Task #14: Време + 15 минути
Да се напише програма, която въвежда час и минути от 24-часово денонощие и изчислява колко ще е часът след 15 минути. Резултатът да се отпечата във формат hh:mm. Часовете винаги са между 0 и 23, а минутите винаги са между 0 и 59. Часовете се изписват с една или две цифри. Минутите се изписват винаги с по две цифри, с водеща нула когато е необходимо. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Task_14
{
    class Add_15_minutes
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int minutesplus15 = 0;
            string h = "";
            string m = "";
            if (hour >= 0 && hour <= 23 && minutes >= 0 && minutes <= 59) // !!!!
            {
                if (minutes < 45 && minutes >= 0)
                {
                    minutesplus15 = minutes + 15;
                    h = hour.ToString();
                    m = minutesplus15.ToString().PadLeft(2, '0');
                    Console.WriteLine(h + ":" + m);
                }
                else if (hour == 0 && minutes == 45)
                {
                    Console.WriteLine("1:00");
                }
                else if (hour == 12 && minutes == 45)
                {
                    Console.WriteLine("13:00");
                }
                else if (minutes <= 59 && minutes >= 0)
                {
                    if (hour == 23)
                    {
                        hour = 0;
                    }
                    else
                    {
                    hour += 1;
                    }
                    
                    minutesplus15 = (minutes + 15) - 60;
                    h = hour.ToString();
                    m = minutesplus15.ToString().PadLeft(2, '0');
                    Console.WriteLine(h + ":" + m);
                }
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }
    }
}