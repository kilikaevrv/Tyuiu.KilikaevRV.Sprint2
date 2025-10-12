
using Tyuiu.KilikaevRV.Sprint2.Task7.V7.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task7.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки внутри заштрихованной области (под параболой)
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 0));   // центр области
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 1));   // под параболой
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 0));   // под параболой
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 0));  // под параболой
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0.5, 1)); // под параболой

            // Точки на границе области
            Assert.AreEqual(true, ds.CheckDotInShadedArea(0, 2));   // вершина параболы
            Assert.AreEqual(true, ds.CheckDotInShadedArea(1, 1));   // на параболе (y = 2-1²=1)
            Assert.AreEqual(true, ds.CheckDotInShadedArea(-1, 1));  // на параболе

            // Точки вне заштрихованной области
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, 3));   // над параболой
            Assert.AreEqual(false, ds.CheckDotInShadedArea(2, 1));   // над параболой (y=1 > 2-4=-2)
            Assert.AreEqual(false, ds.CheckDotInShadedArea(3, 0));   // за пределами по x
            Assert.AreEqual(false, ds.CheckDotInShadedArea(-3, 0));  // за пределами по x
            Assert.AreEqual(false, ds.CheckDotInShadedArea(0, -3));  // за пределами по y
        }
    }
}