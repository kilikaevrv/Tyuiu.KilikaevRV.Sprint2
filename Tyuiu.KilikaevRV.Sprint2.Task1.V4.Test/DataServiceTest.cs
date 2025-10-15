namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Test;


using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;


    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            // Arrange
            DataService ds = new DataService();
            int a = 175, b = 176, c = 414, d = 414;
            bool[] expected = { false, false, false, false, true, false };

            // Act
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void ValidGetLogicOperationsArrayLength()
        {
            // Arrange
            DataService ds = new DataService();
            int a = 175, b = 176, c = 414, d = 414;

            // Act
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Assert
            Assert.AreEqual(6, result.Length);
        }

        [TestMethod]
        public void ValidGetLogicOperationsFourthElementTrue()
        {
            // Arrange
            DataService ds = new DataService();
            int a = 175, b = 176, c = 414, d = 414;

            // Act
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Assert
            Assert.IsTrue(result[4]); // Пятый элемент должен быть True (индекс 4)
        }

        [TestMethod]
        public void ValidGetLogicOperationsAllOtherFalse()
        {
            // Arrange
            DataService ds = new DataService();
            int a = 175, b = 176, c = 414, d = 414;

            // Act
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Assert
            Assert.IsFalse(result[0]);
            Assert.IsFalse(result[1]);
            Assert.IsFalse(result[2]);
            Assert.IsFalse(result[3]);
            Assert.IsFalse(result[5]);
        }

        [TestMethod]
        public void ValidGetLogicOperationsWithDifferentValues()
        {
            // Arrange
            DataService ds = new DataService();
            int a = 100, b = 200, c = 300, d = 400;

            // Act
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            // Assert
            Assert.AreEqual(6, result.Length);
        }
    }
