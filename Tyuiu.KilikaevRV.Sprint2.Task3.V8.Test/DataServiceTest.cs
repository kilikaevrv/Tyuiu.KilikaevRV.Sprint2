
    using System;
    using Tyuiu.KilikaevRV.Sprint2.Task3.V8.Lib;

    namespace Tyuiu.KilikaevRV.Sprint2.Task3.V8.Test
    {
        
            [TestClass]
            public class DataServiceTest
            {
                [TestMethod]
                public void TestForPositiveX()
                {
                    DataService ds = new DataService();
                    double res = ds.Calculate(1);
                    double expected = Math.Round((Math.Sin(1) + Math.Cos(1)) / (Math.Cos(1) - Math.Sin(1)), 3);
                    Assert.AreEqual(expected, res);
                }

                [TestMethod]
                public void TestForZeroX()
                {
                    DataService ds = new DataService();
                    double res = ds.Calculate(0);
                    double expected = Math.Round(0 * 0 - Math.Cos(0 * 0) + 10, 3);
                    Assert.AreEqual(expected, res);
                }

                [TestMethod]
                public void TestForNegativeX()
                {
                    DataService ds = new DataService();
                    double res = ds.Calculate(-5);
                    double expected = Math.Round(Math.Pow(1 + (3 / Math.Pow(-5, 2)), -5), 3);
                    Assert.AreEqual(expected, res);
                }

                [TestMethod]
                public void TestForXLessThanMinus12()
                {
                    DataService ds = new DataService();
                    double res = ds.Calculate(-13);
                    double expected = Math.Round(-13 + 10 * (-13) - (5 / (-13)), 3);
                    Assert.AreEqual(expected, res);
                }
            }
    }
    }