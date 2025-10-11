
    using Tyuiu.KilikaevRV.Sprint2.Task4.V23.Lib;

    namespace Tyuiu.KilikaevRV.Sprint2.Task4.V23.Test
    {
        [TestClass]
        public class DataServiceTest
        {
            [TestMethod]
            public void ValidCalculateFirstCondition()
            {
                DataService ds = new DataService();

                // Тест для случая x + 2 < sqrt(y) + 3 (первое условие)
                double x = 1;
                double y = 25; // sqrt(25) = 5, 1+2=3 < 5+3=8 -> true

                double result = ds.Calculate(x, y);
                double wait = Math.Round(Math.Pow(1 + 1 / Math.Pow(25, 2), 1), 3);

                Assert.AreEqual(wait, result);
            }

            [TestMethod]
            public void ValidCalculateSecondCondition()
            {
                DataService ds = new DataService();

                // Тест для случая x + 2 >= sqrt(y) + 3 (второе условие)
                double x = 10;
                double y = 1; // sqrt(1) = 1, 10+2=12 >= 1+3=4 -> false

                double result = ds.Calculate(x, y);
                double wait = Math.Round(1 + 12 * 10 - (1 / 10.0), 3);

                Assert.AreEqual(wait, result);
            }

            [TestMethod]
            public void ValidCalculateBoundary()
            {
                DataService ds = new DataService();

                // Тест для граничного случая
                double x = 2;
                double y = 1; // sqrt(1) = 1, 2+2=4 >= 1+3=4 -> false (равенство)

                double result = ds.Calculate(x, y);
                double wait = Math.Round(1 + 12 * 2 - (1 / 2.0), 3);

                Assert.AreEqual(wait, result);
            }
        }
    }