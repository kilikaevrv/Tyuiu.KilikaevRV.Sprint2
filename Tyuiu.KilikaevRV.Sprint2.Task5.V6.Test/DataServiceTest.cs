using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint2.Task5.V6.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindCardNameAndSuit()
        {
            DataService ds = new DataService();

            // Тест 1: Дама пик
            Assert.AreEqual("Дама пик", ds.FindCardNameAndSuit(12, 1));

            // Тест 2: Шестерка бубен
            Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndSuit(6, 3));

            // Тест 3: Туз червей
            Assert.AreEqual("Туз червей", ds.FindCardNameAndSuit(14, 4));

            // Тест 4: Валет треф
            Assert.AreEqual("Валет треф", ds.FindCardNameAndSuit(11, 2));

            // Тест 5: Король пик
            Assert.AreEqual("Король пик", ds.FindCardNameAndSuit(13, 1));

            // Тест 6: Десятка червей
            Assert.AreEqual("Десятка червей", ds.FindCardNameAndSuit(10, 4));
        }

        [TestMethod]
        public void ValidFindCardNameAndSuitEdgeCases()
        {
            DataService ds = new DataService();

            // Граничные значения
            Assert.AreEqual("Шестерка пик", ds.FindCardNameAndSuit(6, 1));
            Assert.AreEqual("Туз червей", ds.FindCardNameAndSuit(14, 4));
        }
    }
}