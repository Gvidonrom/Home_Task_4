namespace GeometryLibrary
{
    public class Ellipse
    {
        public double SemiMajorAxis { get; set; } // Большая полуось
        public double SemiMinorAxis { get; set; } // Малая полуось

        public double CalculateArea()
        {
            // Вычисление площади эллипса: Площадь = π * a * b, где a - большая полуось, b - малая полуось
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }

        public double CalculatePerimeter()
        {
            // Вычисление приближенной длины периметра эллипса (нет точной формулы)
            // Можно использовать аппроксимацию Пафагоровой теоремы: Длина ≈ 2 * π * √((a^2 + b^2) / 2), где a и b - полуоси
            return 2 * Math.PI * Math.Sqrt((Math.Pow(SemiMajorAxis, 2) + Math.Pow(SemiMinorAxis, 2)) / 2);
        }
    }
}
