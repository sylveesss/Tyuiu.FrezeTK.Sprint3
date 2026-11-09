using System;
using Tyuiu.FrezeTK.Sprint3.Task3.V15.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task3.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach                                            *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв m,        *");
            Console.WriteLine("* находящихся на соседних позициях в строке: lrmmse mg sermmmrt           *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string str = "lrmmse mg sermmmrt";
            char chr = 'm';

            Console.WriteLine("Исходная строка: " + str);
            Console.WriteLine("Искомый символ: " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = DataService.GetMinInRowChar(str, chr);
            Console.WriteLine("Минимальное количество соседних букв m = " + res);

            Console.ReadKey();
        }
    }
}
