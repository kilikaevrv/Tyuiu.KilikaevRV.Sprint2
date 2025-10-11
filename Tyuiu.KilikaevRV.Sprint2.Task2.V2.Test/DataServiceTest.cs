



using Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            // Точки внутри заштрихованной области
            Assert.AreEqual(true, ds.CheckDotInShadedArea(5, 5));  // в прямоугольнике
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 7));  // в центре круга
            Assert.AreEqual(true, ds.CheckDotInShadedArea(7, 11)); // в треугольнике
            Assert.AreEqual(true, ds.CheckDotInShadedArea(8, 6));  // на границе круга

            // Точки вне заштрихованной области
            Assert.AreEqual(false, ds.CheckDotInShadedArea(1, 1));  // далеко
            Assert.AreEqual(false, ds.CheckDotInShadedArea(15, 15)); // далеко
            Assert.AreEqual(false, ds.CheckDotInShadedArea(5, 2));   // под прямоугольником
            Assert.AreEqual(false, ds.CheckDotInShadedArea(10, 10)); // над прямоугольником, но не в треугольнике
        }
    }
}