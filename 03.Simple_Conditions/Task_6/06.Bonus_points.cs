
/* Task #6: Бонус точки. Дадено е цяло число – брой точки. Върху него се начисляват бонус точки по правилата, описани по-долу. Да се напише програма, която пресмята бонус точките за това число и общия брой точки с бонусите.
•	Ако числото е до 100 включително, бонус точките са 5.
•	Ако числото е по-голямо от 100, бонус точките са 20% от числото.
•	Ако числото е по-голямо от 1000, бонус точките са 10% от числото.
•	Допълнителни бонус точки (начисляват се отделно от предходните):
o	За четно число  + 1 т.
o	За число, което завършва на 5  + 2 т.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    class Bonus_points
    {
        static void Main()
        {
            double points = double.Parse(Console.ReadLine());
            double bonuspoints = 0;
            double score = bonuspoints + points;
            if (points <= 100 && points >= 0)
            {
                bonuspoints += 5;
                score += bonuspoints;
            }
            else if (points >= 1000 && points >= 0)
            {
                bonuspoints = points * 0.1;
                score += bonuspoints;
            }
            else
            {
                points = Math.Abs(points);
                bonuspoints = points * 0.2;
                score += bonuspoints;
            }
            if (points % 10 == 5)
            {
                bonuspoints += 2;
                score += 2;
            }
            else if (points % 2 == 0)
            {
                bonuspoints += 1;
                score += 1;
            }
            else
            {
            }
                Console.WriteLine(bonuspoints);
                Console.WriteLine(score);
        }
    }
}
