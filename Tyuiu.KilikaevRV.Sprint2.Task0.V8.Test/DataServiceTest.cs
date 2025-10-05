
    using Tyuiu.KilikaevRV.Sprint1.Task0.V8.Lib;

    namespace Tyuiu.KilikaevRV.Sprint1.Task0.V8.Test
    {
        [TestClass]
        public sealed class DataServiceTest
        {
            [TestMethod]
            public void ValidGetCompareOperations()
            {
                DataService ds = new DataService();

                int x = 185;
                int y = 251;
                bool[] wait = { true, false, true, false, true, false };
                bool[] res = ds.GetCompareOperations(x, y);

                CollectionAssert.AreEqual(wait, res);
            }

            [TestMethod]
            public void ValidGetCompareOperationsDifferentValues()
            {
                DataService ds = new DataService();

                int x = 100;
                int y = 100;
                bool[] res = ds.GetCompareOperations(x, y);

                // Проверяем первую операцию (x == 185)
                Assert.AreEqual(false, res[0]);
            }
        }
    }