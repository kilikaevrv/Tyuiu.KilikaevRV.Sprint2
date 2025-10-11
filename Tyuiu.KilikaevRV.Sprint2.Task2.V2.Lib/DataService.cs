using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib
{
    public class PointChecker : ISprint2Task2V2
    {
        /// <summary>
        /// Проверяет, находится ли точка внутри круга заданного радиуса
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="radius">Радиус круга</param>
        /// <returns>True если точка внутри круга</returns>
        public static bool IsInCircle(int x, int y, int radius)
        {
            return (x * x + y * y) <= radius * radius;
        }

        /// <summary>
        /// Проверяет, находится ли точка внутри прямоугольника
        /// </summary>
        /// <param name="x">Координата X точки</param>
        /// <param name="y">Координата Y точки</param>
        /// <param name="x1">Левый нижний угол X</param>
        /// <param name="y1">Левый нижний угол Y</param>
        /// <param name="x2">Правый верхний угол X</param>
        /// <param name="y2">Правый верхний угол Y</param>
        /// <returns>True если точка внутри прямоугольника</returns>
        public static bool IsInRectangle(int x, int y, int x1, int y1, int x2, int y2)
        {
            return x >= x1 && x <= x2 && y >= y1 && y <= y2;
        }

        /// <summary>
        /// Проверяет, находится ли точка в кольце между двумя радиусами
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="innerRadius">Внутренний радиус</param>
        /// <param name="outerRadius">Внешний радиус</param>
        /// <returns>True если точка в кольце</returns>
        public static bool IsInRing(int x, int y, int innerRadius, int outerRadius)
        {
            double distanceSquared = x * x + y * y;
            return distanceSquared >= innerRadius * innerRadius &&
                   distanceSquared <= outerRadius * outerRadius;
        }

        /// <summary>
        /// Проверяет нахождение точки в комбинированной заштрихованной области
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <returns>True если точка в заштрихованной области</returns>
        public static bool IsInShadedArea(int x, int y)
        {
            // Пример: объединение нескольких областей
            bool inCircle = IsInCircle(x, y, 5);
            bool inSquare = IsInRectangle(x, y, -3, -3, 3, 3);
            bool inRing = IsInRing(x, y, 2, 4);

            return inCircle || inSquare || inRing;
        }

        public bool CheckDotInShadedArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}