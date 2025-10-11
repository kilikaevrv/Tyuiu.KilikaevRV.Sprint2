using tyuiu.cources.programming.interfaces.Sprint2;


namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint2Task1V4
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            throw new NotImplementedException();
        }

        public bool[] GetLogicOperation(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Используем требуемые операции сравнения и логические операции
            // Каждая операция используется один раз в соответствии с условием

            // 1. False
            result[0] = (a == b) & (c != d);

            // 2. False  
            result[1] = (b < a) | (c > d);

            // 3. False
            result[2] = (c <= b) && (d >= a) ^ (a != c);

            // 4. False
            result[3] = (d == c) | (b > a) && (c < d);

            // 5. True
            result[4] = (a != b) && (c == d) | (b <= c);

            // 6. False
            result[5] = (d >= c) ^ (a < b) | (c != d);

            return result;
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}}