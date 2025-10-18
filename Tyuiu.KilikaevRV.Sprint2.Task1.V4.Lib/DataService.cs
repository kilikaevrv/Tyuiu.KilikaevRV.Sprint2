
using System;
using tyuiu.cources.programming.interfaces.Sprint1;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.KilikaevRV.Sprint2.Task1.V4.Lib
{
    public class DataService : ISprint1Task1V4
    {
        public double Calculate(double x, double y)
        {
            throw new NotImplementedException();
        }

        public bool[] GetCompareOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Операции сравнения (каждая используется один раз)
            result[0] = a == b;  // ==
            result[1] = c != d;  // !=
            result[2] = a < b;   // <
            result[3] = c > d;   // >
            result[4] = a <= b;  // <=
            result[5] = c >= d;  // >=

            return result;
        }
    }
}