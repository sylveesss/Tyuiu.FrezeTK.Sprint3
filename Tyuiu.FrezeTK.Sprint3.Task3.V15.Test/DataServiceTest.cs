using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.FrezeTK.Sprint3.Task3.V15.Lib;

namespace Tyuiu.FrezeTK.Sprint3.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMinInRowCharValid()
        {
            string str = "lrmmse mg sermmmrt";
            char chr = 'm';
            int res = DataService.GetMinInRowChar(str, chr);
            Assert.AreEqual(2, res);
        }
    }
}
