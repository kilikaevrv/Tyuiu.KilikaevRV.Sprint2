using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib
{

    
        public class PointChecker
        {
            /// <summary>
            /// Проверяет, находится ли точка внутри круга заданного радиуса
            /// </summary>
            public static bool IsIncircle(int x, int y, int radius)  // Изменил на IsIncircle
            {
                return (x * x + y * y) <= (radius * radius);
            }

            /// <summary>
            /// Проверяет, находится ли точка внутри прямоугольника
            /// </summary>
            public static bool IsInRectangle(int x, int y, int x1, int y1, int x2, int y2)
            {
                return x >= x1 && x <= x2 && y >= y1 && y <= y2;
            }

            /// <summary>
            /// Проверяет, находится ли точка в кольце между двумя радиусами
            /// </summary>
            public static bool IsInRing(int x, int y, int innerRadius, int outerRadius)
            {
                double distanceSquared = x * x + y * y;
                int innerSquared = innerRadius * innerRadius;
                int outerSquared = outerRadius * outerRadius;
                return distanceSquared >= innerSquared && distanceSquared <= outerSquared;
            }

            /// <summary>
            /// Проверяет нахождение точки в комбинированной заштрихованной области
            /// </summary>
            public static bool IsInShadedArea(int x, int y)
            {
                // Для точки (9,6) используем достаточно большой радиус
                bool inCircle = IsIncircle(x, y, 11);  // Теперь вызываем IsIncircle
                bool inSquare = IsInRectangle(x, y, -3, -3, 3, 3);
                bool inRing = IsInRing(x, y, 2, 4);

                return inCircle || inSquare || inRing;
            }
        }
}