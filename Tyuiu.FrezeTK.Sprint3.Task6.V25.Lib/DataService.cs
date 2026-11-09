using System;

namespace Tyuiu.FrezeTK.Sprint3.Task6.V25.Lib
{
    public class DataService
    {
        public static int GetSumTheDivisors(int startValue, int stopValue)
        {
            int sum = 0;

            for (int i = startValue; i <= stopValue; i++)
            {
                for (int d = 1; d <= i; d++)
                {
                    if (i % d == 0 && d < 10)
                    {
                        sum += d;
                    }
                }
            }

            return sum;
        }
    }
}
