using tyuiu.cources.programming.interfaces.Sprint2;
using System;

namespace Tyuiu.KilikaevRV.Sprint2.Task2.V2.Lib
{

    
        public class DataService : ISprint2Task2V2
        {
            public bool CheckDotInShadedArea(int x, int y)
            {
                // Определяем заштрихованную область
                // Предположим, что это прямоугольник + круг + треугольник

                // Прямоугольник: от (3,3) до (10,8)
                bool inRectangle = (x >= 3 && x <= 10 && y >= 3 && y <= 8);

                // Круг с центром в (7,7) и радиусом 3
                bool inCircle = (Math.Pow(x - 7, 2) + Math.Pow(y - 7, 2) <= 9);

                // Треугольник с вершинами (5,10), (9,10), (7,13)
                bool inTriangle = (y >= 10 && y <= 13 &&
                                  x >= 5 + (y - 10) &&
                                  x <= 9 - (y - 10));

                // Точка находится в заштрихованной области, если попадает в любую из фигур
                return inRectangle || inCircle || inTriangle;
            }
        }
}