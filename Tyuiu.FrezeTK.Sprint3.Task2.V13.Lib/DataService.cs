using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FrezeTK.Sprint3.Task2.V13.Lib
{
    public class DataService: ISprint3Task2V13
    {
        public static double GetSumSeries(double t, int startValue, int stopValue)
        {
            double sum = 0;
            int k = startValue;

            do
            {
                sum += (Math.Pow(t, k) + 2.0 / (k + 1)) * Math.Sin(t);
                k++;
            } while (k <= stopValue);

            return Math.Round(sum, 3);
        }
    }
}
