using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mindbox_Tests
{
    [TestClass]
    public class Areas_tests
    {
        // Тестируем работу функции по вычислению площади круга
        [TestMethod]
        public void AreaCircle_rad3_28_27433returned()
        {
            double rad = 3;
            double check = 28.27433;
            Assert.AreEqual(check, Mindbox.Areas.AreaCircle(rad));
        }
        
        // Тестируем работу функции по вычислению площади треугольника по трем сторонам
        [TestMethod]
        public void AreaTriangle_3and6and4_5_33268returned()
        {
            double side1 = 3;
            double side2 = 6;
            double side3 = 4;
            double check  = 5.33268;
            Assert.AreEqual(check, Mindbox.Areas.AreaTriangle(side1, side2, side3));
        }

        // Тестируем работу функций по проверке, является ли треугольник прямоугольным
        [TestMethod]
        public void TestTriangleIsRectangular()
        {
            bool fromLibrary = Mindbox.Areas.IsTriangleRectangular(5, 4, 3);
            Assert.IsTrue(fromLibrary);

        }

        [TestMethod]
        public void TestTriangleIsNotRectangular()
        {
            bool fromLibrary = Mindbox.Areas.IsTriangleRectangular(6, 4, 3);
            Assert.IsFalse(fromLibrary);

        }

        //Без знания типа фигуры, вычисляем площадь возможных вариантов, при известной высоте и стороне
        [TestMethod]
        public void AreaOfFigure_5and3_7_5and15and37_5returned()
        {
            double h = 5;
            double a = 3;
            double triangle = 7.5;
            double quadrangle = 15;
            double pentagon = 37.5;
            double[] areas = new double[3] { triangle, quadrangle, pentagon };
            double[] areasLibrary = Mindbox.Areas.AreaFigure(h, a);
            for (int i = 0; i < areas.GetLength(0); i++)
            {
                Assert.AreEqual(areas[i], areasLibrary[i]);
            }
        }

        // Тестируем обработку ошибок
        //Существует ли треугольник
        [TestMethod]
        public void CheckErrorMessage()
        {
            bool fromLibrary = Mindbox.Areas.IsTriangleRectangular(5, 4, 3);
            Assert.IsTrue(fromLibrary);
        }

        //Отрицательны ли стороны
        [TestMethod]
        public void CheckErrorMessage2()
        {
            bool fromLibrary = Mindbox.Areas.IsTriangleRectangular(5, 4, 3);
            Assert.IsTrue(fromLibrary);
        }
    }
}
