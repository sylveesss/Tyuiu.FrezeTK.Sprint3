using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FrezeTK.Sprint3.Task0.V30.Lib
{
    public class DataService: ISprint3Task0V30
    {
        public static double GetMultiplySeries()
        {
            double product = 1.0;

            for (int k = 1; k <= 20; k++)
            {
                product *= (k / Math.Pow(Math.Sin(1), -10));
            }

            return Math.Round(product, 3);
        }
    }
}
