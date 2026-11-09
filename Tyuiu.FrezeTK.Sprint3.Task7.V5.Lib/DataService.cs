using System;

namespace Tyuiu.FrezeTK.Sprint3.Task7.V5.Lib
{
    public class DataService
    {
        public static double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;
            double[] valueArray = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 3 * x + 1.2;

                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[count] = 0;
                }
                else
                {
                    double y = (2 * Math.Sin(x)) / denominator + Math.Cos(x) - 7 * x * 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }

            return valueArray;
        }
    }
}
