
    using Tyuiu.KilikaevRV.Sprint2.Task6.V6.Lib;

    namespace Tyuiu.KilikaevRV.Sprint2.Task6.V6.Test
    {
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void ValidFindCardNameAndSuit()
            {
                DataService ds = new DataService();

                // Тест: Дама пик (m=1, k=12)
                Assert.AreEqual("Дама пик", ds.FindCardNameAndSuit(1, 12));

                // Тест: Шестерка бубен (m=3, k=6)
                Assert.AreEqual("Шестерка бубен", ds.FindCardNameAndSuit(3, 6));

                // Тест: Туз червей (m=4, k=14)
                Assert.AreEqual("Туз червей", ds.FindCardNameAndSuit(4, 14));

                // Тест: Валет треф (m=2, k=11)
                Assert.AreEqual("Валет треф", ds.FindCardNameAndSuit(2, 11));

                // Тест: Король пик (m=1, k=13)
                Assert.AreEqual("Король пик", ds.FindCardNameAndSuit(1, 13));

                // Тест: Десятка червей (m=4, k=10)
                Assert.AreEqual("Десятка червей", ds.FindCardNameAndSuit(4, 10));
            }

            [TestMethod]
            public void ValidFindCardNameAndSuitEdgeCases()
            {
                DataService ds = new DataService();

                // Граничные значения
                Assert.AreEqual("Шестерка пик", ds.FindCardNameAndSuit(1, 6));
                Assert.AreEqual("Туз червей", ds.FindCardNameAndSuit(4, 14));

                // Неверные значения
                Assert.AreEqual("Неизвестная карта неизвестной масти", ds.FindCardNameAndSuit(5, 12));
                Assert.AreEqual("Неизвестная карта неизвестной масти", ds.FindCardNameAndSuit(1, 15));
                Assert.AreEqual("Неизвестная карта неизвестной масти", ds.FindCardNameAndSuit(0, 10));
            }
        }
    }