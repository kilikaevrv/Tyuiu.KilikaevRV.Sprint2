
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Test

{
    [TestClass]
    public class DataServiceTest
    {
        private DataService _service;

        [TestInitialize]
        public void Setup()
        {
            _service = new DataService(); // создаём объект сервиса
        }

        [TestMethod]
        public void TestMethod1()
        {
            // пример теста: проверяем, что метод возвращает true
            bool result = _service.SomeMethod();
            Assert.IsTrue(result, "Метод должен возвращать true");
        }

        [TestMethod]
        public void TestMethod2()
        {
            // пример теста с проверкой значения
            int count = _service.GetItemsCount();
            Assert.AreEqual(5, count, "Количество элементов должно быть 5");
        }
    }
}