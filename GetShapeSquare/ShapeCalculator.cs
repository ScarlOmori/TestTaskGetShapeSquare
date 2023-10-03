namespace GetShapeSquare
{
    /// <summary>
    /// Калькулятор для вычисления площади фигуры без знания её типа.
    /// </summary>
    public class ShapeCalculator
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        /// <param name="shape">Фигура.</param>
        /// <returns>Площадь фигуры.</returns>
        public double CalculateArea(Shape shape) => shape.CalculateArea();

    }
}
