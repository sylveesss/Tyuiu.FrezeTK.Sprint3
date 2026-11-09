using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task7.V5.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task7.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMassFunctionValid()
        {
            int start = -5;
            int stop = 5;
            double[] res = DataService.GetMassFunction(start, stop);
            Assert.IsNotNull(res);
            Assert.AreEqual(11, res.Length);
        }
    }
}
