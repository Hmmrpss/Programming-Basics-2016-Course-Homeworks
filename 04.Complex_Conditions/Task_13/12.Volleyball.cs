﻿/* 12. Волейбол
Влади е студент, живее в София и си ходи от време на време до родния град. Той е много запален по волейбола, но е зает през работните дни и играе волейбол само през уикендите и в празничните дни. Влади играе в София всяка събота, когато не е на работа и не си пътува до родния град, както и в 2/3 от празничните дни. Той пътува до родния си град h пъти в годината, където играе волейбол със старите си приятели в неделя. Влади не е на работа 3/4 от уикендите, в които е в София. Отделно, през високосните години Влади играе с 15% повече волейбол от нормалното. Приемаме, че годината има точно 48 уикенда, подходящи за волейбол.
Напишете програма, която изчислява колко пъти Влади е играл волейбол през годината. Закръглете резултата надолу до най-близкото цяло число (например 2.15  2; 9.95  9).
Входните данни се четат от конзолата:
•	Първият ред съдържа думата “leap” (високосна година) или “normal” (невисокосна).
•	Вторият ред съдържа цялото число p – брой празници в годината (които не са събота и неделя).
•	Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class volleyball
    {
        static void Main()
        {
            string typeOfYear = Console.ReadLine();
            var p = 0;  // брой празници в гброй уикенди, в които Влади си пътува до родния град.одината (които не са събота и неделя
            var h = 0;  //брой уикенди, в които Влади си пътува до родния град.
            int weekendsInTheYear = 48;
            int weekendsInSofia = weekendsInTheYear - h;
            var sundaysHome = h;

        }
    }
}
//y==h && x>h && x<2*h  za 14 zadacva
// 