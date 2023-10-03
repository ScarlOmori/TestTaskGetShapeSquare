using GetShapeSquare;

namespace ShapeSquareTests
{
    /// <summary>
    /// Тестирование функциональности связанной со счетом площади фигур.
    /// </summary>
    [TestClass]
    public class ShapeSquareTests
    {
        /// <summary>
        /// Выбрасывается ли исключение при вводе нулевого или отрицательного радиуса.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(-50)]
        [DataRow(-50000)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CircleConstructor_NonPositiveRaduis_ArgumentOutOfRangeExceptionIsThrows(double radius)
        {
            var circle = new Circle(radius);

            circle.CalculateArea();
        }

        /// <summary>
        /// Выбрасывается ли исключение при вводе нулевых или отрицательных сторон треугольника.
        /// </summary>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(-1, -1, -1)]
        [DataRow(-50, -50, -50)]
        [DataRow(-50000, -50000, -50000)]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TriangleConstructor_NonPositiveSides_ArgumentOutOfRangeExceptionIsThrows(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            triangle.CalculateArea();
        }

        /// <summary>
        /// Правильно ли считается площадь треугольника.
        /// </summary>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        [TestMethod]
        [DataRow(3.897114, 3, 3, 3)]
        [DataRow(40.326015, 29, 5, 25)]
        [DataRow(6473.42826, 145, 90, 180)]
        [DataRow(178673.80927, 500, 1000, 742)]
        public void TriangleSquare_TriangleSquareValue_ReturnsCorrectSquare(double expectedArea, double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            var squareValue = triangle.CalculateArea();

            Assert.AreEqual(Math.Round(expectedArea, 4), Math.Round(squareValue, 4));
        }

        /// <summary>
        /// Правильно ли считается площадь круга.
        /// </summary>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        /// <param name="radius">Радиус круга.</param>
        [TestMethod]
        [DataRow(78.53981633974483, 5)]
        [DataRow(314.1592653589793, 10)]
        public void CircleSquare_CircleSquareValue_ReturnsCorrectSquare(double expectedArea, double radius)
        {
            var circle = new Circle(radius);

            var squareValue = circle.CalculateArea();

            Assert.AreEqual(Math.Round(squareValue, 4), Math.Round(expectedArea, 4));

        }

        /// <summary>
        /// Правильно ли считается площадь при счёте площади без знания типа фигуры на этапе компиляции.
        /// </summary>
        /// <param name="expectedArea">Ожидаемая площадь.</param>
        /// <param name="radius">Радиус фигуры.</param>
        [TestMethod]
        [DataRow(78.53981633974483, 5)]
        [DataRow(314.1592653589793, 10)]
        public void ShapeSquare_ShapeSquareValue_ReturnsCorrectSquare(double expectedArea, double radius)
        {
            var shapeCalculator = new ShapeCalculator();
            Shape shape = new Circle(radius);

            double dynamicArea = shapeCalculator.CalculateArea(shape);

            Assert.AreEqual(Math.Round(dynamicArea, 4), Math.Round(expectedArea, 4));
        }

        /// <summary>
        /// Правильно ли определяется прямоугольный ли треугольник.
        /// </summary>
        /// <param name="expectedValue">Ожидаемый ответ.</param>
        /// <param name="firstSide">Первая сторона.</param>
        /// <param name="secondSide">Вторая сторона.</param>
        /// <param name="thirdSide">Третья сторона.</param>
        [TestMethod]
        [DataRow(true, 3, 4, 5)]
        [DataRow(false, 5, 6, 10)]
        public void RectangularTriangle_IsItRectangular_ReturnsCorrectBoolValue(bool expectedValue, double firstSide, double secondSide, double thirdSide)
        {
            var rectangular = new Triangle(firstSide, secondSide, thirdSide);

            var isRectangular = rectangular.IsRightTriangle();

            Assert.AreEqual(expectedValue, isRectangular);
        }
    }
}