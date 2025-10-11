




using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib;

namespace Tyulu.KilikaevRY.Sprint2.Task2.V2
{
    [TestClass]
    public class PointCheckerTests
    {
        [TestMethod]
        public void IsInCircle_PointInsideCircle_ReturnsTrue()
        {
            // Arrange
            int x = 3, y = 4, radius = 5;

            // Act
            bool result = PointChecker.IsIncircle(x, y, radius);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsInCircle_PointOutsideCircle_ReturnsFalse()
        {
            // Arrange
            int x = 4, y = 4, radius = 5;

            // Act
            bool result = PointChecker.IsIncircle(x, y, radius);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsInRectangle_PointInsideRectangle_ReturnsTrue()
        {
            // Arrange
            int x = 2, y = 2;

            // Act
            bool result = PointChecker.IsInRectangle(x, y, -3, -3, 3, 3);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsInRectangle_PointOutsideRectangle_ReturnsFalse()
        {
            // Arrange
            int x = 4, y = 4;

            // Act
            bool result = PointChecker.IsInRectangle(x, y, -3, -3, 3, 3);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsInRing_PointInRing_ReturnsTrue()
        {
            // Arrange
            int x = 3, y = 0;

            // Act
            bool result = PointChecker.IsInRing(x, y, 2, 4);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsInRing_PointOutsideRing_ReturnsFalse()
        {
            // Arrange
            int x = 5, y = 0;

            // Act
            bool result = PointChecker.IsInRing(x, y, 2, 4);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void IsInShadedArea_PointInShadedArea_ReturnsTrue()
        {
            // Arrange
            int x = 0, y = 0;  // Точка в начале координат должна быть в заштрихованной области

            // Act
            bool result = PointChecker.IsInShadedArea(x, y);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsInShadedArea_PointNotInShadedArea_ReturnsFalse()
        {
            // Arrange
            int x = 10, y = 10;  // Точка далеко от всех областей

            // Act
            bool result = PointChecker.IsInShadedArea(x, y);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
