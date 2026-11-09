using System;

namespace Tyuiu.FrezeTK.Sprint3.Task5.V15.Lib
{
    public class DataService
    {
        public static double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double sum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    sum += Math.Sin(x) + (Math.Pow(k, 2) / 2.0);
                }
            }

            return Math.Round(sum, 3);
        }
    }
}
