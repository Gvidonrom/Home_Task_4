namespace GeometryLibrary
{
    public class Rectangle
    {
        public double SideA { get; set; } // Длина
        public double SideB { get; set; }  // Ширина

        public double CalculateArea()
        {
            // Вычисление площади прямоугольника: Площадь = Длина * Ширина
            return SideA * SideB;
        }

        public double CalculatePerimeter()
        {
            // Вычисление периметра прямоугольника: Периметр = 2 * (Длина + Ширина)
            return 2 * (SideA + SideB);
        }
    }
}
