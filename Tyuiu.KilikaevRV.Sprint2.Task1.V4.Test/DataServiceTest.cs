
using Tyuiu.KilkaevRV.Sprint2.Task4.V4.Lib;

namespace Tyuiu.KilkaevRV.Sprint2.Task4.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            bool[] result = new bool[5];
            bool[] wait = { false, false, false, true, false };
            bool[] res = ds.Calculate(result);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckIndividualOperations()
        {
            DataService ds = new DataService();

            bool[] result = new bool[5];
            bool[] res = ds.Calculate(result);

            // Проверяем каждую операцию отдельно
            Assert.AreEqual(false, res[0]); // (175 == 176) | (414 != 414) = False | False = False
            Assert.AreEqual(false, res[1]); // (175 < 176) & (414 > 414) = True & False = False
            Assert.AreEqual(false, res[2]); // (176 <= 175) || (414 < 414) = False || False = False
            Assert.AreEqual(true, res[3]);  // (175 != 176) && (414 == 414) = True && True = True
            Assert.AreEqual(false, res[4]); // !(175 > 176) ^ (414 <= 414) = !False ^ True = True ^ True = False
        }
    }
}