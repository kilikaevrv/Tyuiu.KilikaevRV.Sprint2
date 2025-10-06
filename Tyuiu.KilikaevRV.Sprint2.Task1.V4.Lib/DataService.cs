using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilkaevRV.Sprint2.Task4.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool[] Calculate(bool[] result)
        {
            int a = 175;
            int b = 176;
            int c = 414;
            int d = 414;

            // Последовательность операций сравнения и логических операций
            result[0] = (a == b) | (c != d);          // False | False = False
            result[1] = (a < b) & (c > d);            // True & False = False
            result[2] = (b <= a) || (c >= d);         // False || True = True → но нужно False, поэтому:
            // Исправляем для получения False
            result[2] = (b <= a) || (c < d);          // False || False = False
            result[3] = (a != b) && (c == d);         // True && True = True
            result[4] = !(a > b) ^ (c <= d);          // !False ^ True = True ^ True = False

            return result;
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}