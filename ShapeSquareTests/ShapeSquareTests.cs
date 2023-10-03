using GetShapeSquare;

namespace ShapeSquareTests
{
    /// <summary>
    /// ������������ ���������������� ��������� �� ������ ������� �����.
    /// </summary>
    [TestClass]
    public class ShapeSquareTests
    {
        /// <summary>
        /// ������������� �� ���������� ��� ����� �������� ��� �������������� �������.
        /// </summary>
        /// <param name="radius">������ �����.</param>
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
        /// ������������� �� ���������� ��� ����� ������� ��� ������������� ������ ������������.
        /// </summary>
        /// <param name="firstSide">������ �������.</param>
        /// <param name="secondSide">������ �������.</param>
        /// <param name="thirdSide">������ �������.</param>
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
        /// ��������� �� ��������� ������� ������������.
        /// </summary>
        /// <param name="expectedArea">��������� �������.</param>
        /// <param name="firstSide">������ �������.</param>
        /// <param name="secondSide">������ �������.</param>
        /// <param name="thirdSide">������ �������.</param>
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
        /// ��������� �� ��������� ������� �����.
        /// </summary>
        /// <param name="expectedArea">��������� �������.</param>
        /// <param name="radius">������ �����.</param>
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
        /// ��������� �� ��������� ������� ��� ����� ������� ��� ������ ���� ������ �� ����� ����������.
        /// </summary>
        /// <param name="expectedArea">��������� �������.</param>
        /// <param name="radius">������ ������.</param>
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
        /// ��������� �� ������������ ������������� �� �����������.
        /// </summary>
        /// <param name="expectedValue">��������� �����.</param>
        /// <param name="firstSide">������ �������.</param>
        /// <param name="secondSide">������ �������.</param>
        /// <param name="thirdSide">������ �������.</param>
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