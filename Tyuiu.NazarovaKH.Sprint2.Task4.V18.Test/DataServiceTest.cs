using Tyuiu.NazarovaKH.Sprint2.Task4.V18.Lib;

namespace Tyuiu.NazarovaKH.Sprint2.Task4.V18.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double res = ds.Calculate(x, y);
            double wait = 6;
            Assert.AreEqual(wait, res);       
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            double res = ds.Calculate(x, y);
            double wait = 49;
            Assert.AreEqual(wait, res);
        }
    }
}