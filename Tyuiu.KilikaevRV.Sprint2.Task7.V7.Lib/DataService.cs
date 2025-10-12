using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.KilikaevRV.Sprint2.Task7.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Область находится под параболой y = 2 - x²
            // То есть y <= 2 - x²
            // И обычно ограничена по x (предположим от -2 до 2)

            bool underParabola = y <= (2 - Math.Pow(x, 2));
            bool inXRange = x >= -2 && x <= 2;
            bool inYRange = y >= -2 && y <= 2; // ограничение по y для реалистичной области

            return underParabola && inXRange && inYRange;
        }
    }
}