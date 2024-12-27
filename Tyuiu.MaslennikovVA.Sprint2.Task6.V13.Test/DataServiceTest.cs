using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslennikovVA.Sprint2.Task6.V13.Lib;

namespace Tyuiu.MaslennikovVA.Sprint2.Task6.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int n = 31;
            int m = 12;
            int g = 1999;

            var res = ds.FindDateOfNextDay(g, m, n);
            string wait = "01.01.2000";
            Assert.AreEqual(res, wait);
        }
    }
}