using System;

namespace Tyuiu.FrezeTK.Sprint3.Task4.V27.Lib
{
    public class DataService
    {
        public static double Calculate(int startValue, int stopValue)
        {
            double sum = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                sum += (double)x / (Math.Cos(x) + Math.Sin(x));
            }

            return Math.Round(sum, 3);
        }
    }
}
