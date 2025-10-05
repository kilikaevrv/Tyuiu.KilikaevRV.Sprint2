using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilikaevRV.Sprint1.Task0.V8.Lib
{
    public class DataService : ISprint2Task0V8
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] result = new bool[6];

            // Последовательность операций сравнения
            result[0] = x == 185;        // True (x = 185)
            result[1] = 1 == y;          // False (y = 251)
            result[2] = x < y;           // True (185 < 251)
            result[3] = x > y;           // False (185 > 251)
            result[4] = x <= y;          // True (185 <= 251)
            result[5] = x >= y;          // False (185 >= 251)

            return result;
        }
    }
}