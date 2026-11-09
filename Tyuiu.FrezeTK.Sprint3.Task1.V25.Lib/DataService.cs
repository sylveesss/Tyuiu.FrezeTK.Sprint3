using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FrezeTK.Sprint3.Task1.V25.Lib
{
    public class DataService: ISprint3Task1V25
    {
        public static double GetMultiplySeries(int a, int startValue, int stopValue)
        {
            double product = 1.0;
            int k = startValue;

            while (k <= stopValue)
            {
                product *= (Math.Pow(a, k) - 0.25) * Math.Cos(5);
                k++;
            }

            return Math.Round(product, 3);
        }
    }
}
