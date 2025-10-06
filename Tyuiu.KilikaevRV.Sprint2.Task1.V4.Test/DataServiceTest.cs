

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

            bool[] wait = { false, false, false, false, true, false };
            bool[] res = ds.Calculate();

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckSequenceLength()
        {
            DataService ds = new DataService();

            bool[] res = ds.Calculate();

            Assert.AreEqual(6, res.Length);
            Assert.AreEqual(false, res[0]);
            Assert.AreEqual(false, res[1]);
            Assert.AreEqual(false, res[2]);
            Assert.AreEqual(false, res[3]);
            Assert.AreEqual(true, res[4]);
            Assert.AreEqual(false, res[5]);
        }
    }
}