using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task6.V25.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task6.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetSumTheDivisorsValid()
        {
            int start = 16;
            int stop = 24;
            int res = DataService.GetSumTheDivisors(start, stop);
            Assert.IsNotNull(res);
        }
    }
}
