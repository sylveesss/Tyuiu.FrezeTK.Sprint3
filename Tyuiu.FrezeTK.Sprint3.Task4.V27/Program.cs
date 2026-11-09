using System;
using Tyuiu.FrezeTK.Sprint3.Task4.V27.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #3 | Выполнил: Фрезе Т. К. | ИБКСб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Используя операторы continue и break в циклах                     *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Фрезе Т. К. | ИБКСб-26-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* На отрезке, где х принимает значения от -5 до 5, вычислить значение     *");
            Console.WriteLine("* функции y = x / (cos(x) + sin(x)). При x = 0 пропустить значение.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = DataService.Calculate(startValue, stopValue);
            Console.WriteLine("Сумма значений функции = " + res);

            Console.ReadKey();
        }
    }
}
