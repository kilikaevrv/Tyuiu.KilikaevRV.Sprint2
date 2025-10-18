
using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib

{
    public class DataService : ISprint2Task1V4
    {
        private List<string> _items; // например, хранение данных в памяти

        public DataService()
        {
            _items = new List<string> { "Элемент1", "Элемент2", "Элемент3" };
        }

        // получить все элементы
        public List<string> GetAll()
        {
            return _items;
        }

        // получить количество элементов
        public int GetItemsCount()
        {
            return _items.Count;
        }

        // добавить элемент
        public void AddItem(string item)
        {
            _items.Add(item);
        }

        // удалить элемент
        public bool RemoveItem(string item)
        {
            return _items.Remove(item);
        }

        // пример метода, который проверяет условие
        public bool SomeMethod()
        {
            return _items.Count > 0;
        }

        public bool[] GetCompareOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}