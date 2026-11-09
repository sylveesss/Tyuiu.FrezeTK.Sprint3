using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task1.V25.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task1.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeriesValid()
        {
            int a = 2;
            int start = 1;
            int stop = 6;
            double res = DataService.GetMultiplySeries(a, start, stop);
            Assert.IsNotNull(res);
        }
    }
}
