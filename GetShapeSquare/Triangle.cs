namespace GetShapeSquare
{
    /// <summary>
    /// Треугольник.
    /// </summary>
    public class Triangle : Shape
    {
        /// <summary>
        /// Первая сторона треугольника.
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Вторая сторона треугольника.
        /// </summary>
        public double SideB { get; private set; }

        /// <summary>
        /// Третья сторона треугольника.
        /// </summary>
        public double SideC { get; private set; }

        /// <summary>
        /// Является ли треугольник прямоугольным.
        /// </summary>
        public bool IsRightTriangle()
        {
            List<double> sides = new() { SideA, SideB, SideC };
            sides.Sort();

            return Math.Pow(sides[2], 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2);
        }

        /// <summary>
        /// Конструктор с инициализацией сторон треугольника.
        /// </summary>
        /// <param name="sideA">Первая сторона.</param>
        /// <param name="sideB">Вторая сторона.</param>
        /// <param name="sideC">Третья сторона.</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentOutOfRangeException("Длины сторон должны быть положительными числами.");
            }

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        /// <summary>
        /// Возвращает площадь треугольника.
        /// </summary>
        /// <returns>Площадь треугольника.</returns>
        public override double CalculateArea()
        {
            double semiPerimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiPerimeter * (semiPerimeter - SideA) * (semiPerimeter - SideB) * (semiPerimeter - SideC));
        }
    }
}
