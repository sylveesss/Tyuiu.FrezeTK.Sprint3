using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task0.V30.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task0.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMultiplySeriesValid()
        {
            double res = DataService.GetMultiplySeries();
            Assert.IsTrue(res > 0);
        }
    }
}
