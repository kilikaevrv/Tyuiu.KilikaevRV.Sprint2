


using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperation()
        {
            DataService ds = new DataService();

            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;

            bool[] result = ds.GetLogicOperation(a, b, c, d);
            bool[] wait = new bool[] { false, false, false, false, true, false };

            CollectionAssert.AreEqual(wait, result);
        }
    }
}