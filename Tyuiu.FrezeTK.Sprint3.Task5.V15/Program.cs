using System;
using Tyuiu.FrezeTK.Sprint3.Task5.V15.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task5.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет сумму ряда по формуле             *");
            Console.WriteLine("* с использованием вложенных циклов, при X=5.                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x = 5;
            int startValue1 = 1;
            int stopValue1 = 3;
            int startValue2 = 1;
            int stopValue2 = 10;

            Console.WriteLine("Переменная X = " + x);
            Console.WriteLine("Старт шага первого цикла = " + startValue1);
            Console.WriteLine("Конец шага первого цикла = " + stopValue1);
            Console.WriteLine("Старт шага второго цикла = " + startValue2);
            Console.WriteLine("Конец шага второго цикла = " + stopValue2);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = DataService.GetSumSumSeries(x, startValue1, stopValue1, startValue2, stopValue2);
            Console.WriteLine("Сумма ряда = " + res);

            Console.ReadKey();
        }
    }
}
