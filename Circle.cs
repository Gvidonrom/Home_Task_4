namespace GeometryLibrary
{
    public class Circle
    {
        public double Radius { get; set; } // Радиус круга

        public double CalculateArea()
        {
            // Вычисление площади круга: Площадь = π * R^2
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double CalculateCircumference()
        {
            // Вычисление длины окружности (периметра круга): Длина = 2 * π * R
            return 2 * Math.PI * Radius;
        }
    }
}
