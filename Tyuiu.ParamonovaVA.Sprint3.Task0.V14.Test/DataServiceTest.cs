using Tyuiu.ParamonovaVA.Sprint3.Task0.V14.Lib;

namespace Tyuiu.ParamonovaVA.Sprint3.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int k = 1;
            int stop = 5;
            double n = 2;

            Assert.AreEqual(55, ds.GetSumSeries(n, k, stop));
        }
    }
}