using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task2.V13.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task2.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSeriesValid()
        {
            double t = 0.7;
            int start = 1;
            int stop = 10;
            double res = DataService.GetSumSeries(t, start, stop);
            Assert.IsNotNull(res);
        }
    }
}
