using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task5.V15.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task5.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumSumSeriesValid()
        {
            int x = 5;
            int start1 = 1, stop1 = 3;
            int start2 = 1, stop2 = 10;
            double res = DataService.GetSumSumSeries(x, start1, stop1, start2, stop2);
            Assert.IsNotNull(res);
        }
    }
}
