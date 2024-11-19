using Tyuiu.NazarovaKH.Sprint2.Task7.V7.Lib;

namespace Tyuiu.NazarovaKH.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            double x = 0.5;
            double y = 0.8;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}