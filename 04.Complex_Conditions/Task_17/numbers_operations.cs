﻿/* 17. Операции между числа
Напишете програма, която чете две цели числа (N1 и N2) и оператор с който да се извърши дадена математическа операция с тях. Възможните операции са: Събиране(+), Изваждане(-), Умножение(*), Деление(/) и Модулно деление(%). При събиране, изваждане и умножение на конзолата трябва да се отпечатат резултата и дали той е четен или нечетен. При обикновеното деление – резултата. При модулното деление – остатъка. Трябва да се има предвид, че делителят може да е равен на 0(нула), а на нула не се дели. В този случай трябва да се отпечата специално съобщениe.
Вход
От конзолата се прочитат 3 реда:
•	N1 – цяло число в интервала [0...40 000]
•	N2 – цяло число в интервала [0...40 000]
•	Оператор – един символ измеду: „+“, „-“, „*“, „/“, „%“
Изход
Да се отпечата на конзолата един ред:
•	Ако операцията е събиране, изваждене или умножение:
o	 „{N1} {оператор} {N2} = {резултат} – {even/odd}“
•	Ако операцията е деление:
o	„{N1} / {N2} = {резултат}“ – резултата е фораматиран до вторият знак след дес.запетая
•	Ако операцията е модулно деление: 
o	„{N1} % {N2} = {остатък}“
•	В случай на деление с 0(нула): 
o	„Cannot divide {N1} by zero“ */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_17
{
    class numbers_operations
    {
        static void Main()
        {
        }
    }
}
