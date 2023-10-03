namespace GetShapeSquare
{
    /// <summary>
    /// Круг.
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// Радиус круга.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструктор с инициализацией радиуса.
        /// </summary>
        /// <param name="radius">Радиус круга.</param>
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException("Радиус должен быть положительным числом.");
            }

            Radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга.
        /// </summary>
        /// <returns>Площадь круга.</returns>
        public override double CalculateArea() => Math.PI * Math.Pow(Radius, 2);

    }
}
