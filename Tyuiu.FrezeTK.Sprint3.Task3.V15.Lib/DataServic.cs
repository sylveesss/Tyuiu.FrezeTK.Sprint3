using System;

namespace Tyuiu.FrezeTK.Sprint3.Task3.V15.Lib
{
    public class DataService
    {
        public static int GetMinInRowChar(string value, char item)
        {
            int minRow = int.MaxValue;
            int currentCount = 0;

            foreach (char c in value)
            {
                if (c == item)
                {
                    currentCount++;
                }
                else
                {
                    if (currentCount > 1 && currentCount < minRow)
                    {
                        minRow = currentCount;
                    }
                    currentCount = 0;
                }
            }

            if (currentCount > 1 && currentCount < minRow)
            {
                minRow = currentCount;
            }

            return minRow == int.MaxValue ? 0 : minRow;
        }
    }
}
