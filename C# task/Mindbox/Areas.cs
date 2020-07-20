using System;

namespace Mindbox
{
    public class Areas
    {

        //Функция проверки ввода корректных чисел
        public static void CheckRight(double par1, double par2 = 1, double par3 = 1)
        {
            if (par1 <= 0 || par2 <= 0 || par3 <= 0)
            {
                throw new ArgumentException("Стороны должны быть больше 0");
            }
        }

        //Функция проверки существования треугольника
        public static void CheckTriangle(double side1, double side2, double side3)
        {
            if (side1 > side2 + side3 || side2 > side1 + side3 || side3 > side1 + side2)
            {
                throw new ArgumentException("Треугольник не существует");
            }
        }

        //Вычисление площади круга
        public static double AreaCircle(double rad)
        {
            CheckRight(rad);
            return Math.Round(Math.PI * Math.Pow(rad, 2), 5);
        }

        //Вычисление площади треугольника по трем сторонам
        public static double AreaTriangle(double side1, double side2, double side3)
        {
            CheckRight(side1, side2, side3);
            CheckTriangle(side1, side2, side3);
            double p = (side1 + side2 + side3) / 2;
            return Math.Round(Math.Pow((p * (p - side1) * (p - side2) * (p - side3)), 0.5), 5);
        }

        //Проверка, является ли треугольник прямоугольным
        public static bool IsTriangleRectangular(double side1, double side2, double side3)
        {
            bool triangle = false;
            CheckRight(side1, side2, side3);
            CheckTriangle(side1, side2, side3);
            if (Math.Pow(side1, 2) == Math.Pow(side2, 2) + Math.Pow(side3, 2) || Math.Pow(side2, 2) == Math.Pow(side1, 2) + Math.Pow(side3, 2) || Math.Pow(side3, 2) == Math.Pow(side1, 2) + Math.Pow(side2, 2))
            {
                triangle = true;
            }
            return triangle;
        }

        //Вычисление площади фигуры, без знания ее типа, т.е. вычисление по стороне и высоте
        public static double[] AreaFigure(double h, double a)
        {
            CheckRight(h, a);
            //если это треугольник
            double triangle = 0.5 * a * h;
            //если четырехугольник
            double quadrangle = h * a;
            //если пятиугольник, то h - это апофема
            double pentagon = (5 * a * h) / 2;
            //и т.д. с остальными фигурами

            double[] mas = new double[3] { triangle, quadrangle, pentagon };
            return mas;
        }
    }
}
