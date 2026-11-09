using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task4.V27.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckCalculateValid()
        {
            int start = -5;
            int stop = 5;
            double res = DataService.Calculate(start, stop);
            Assert.IsNotNull(res);
        }
    }
}
