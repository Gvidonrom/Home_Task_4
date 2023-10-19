namespace GeometryLibrary
{
    internal class Rhombus
    {
        public double SideA { get; set; } // Длина стороны
        public double Diagonal1 { get; set; } // Диагональ 1
        public double Diagonal2 { get; set; } // Диагональ 2

        public double CalculateArea()
        {
            return (Diagonal1 * Diagonal2) / 2;
        }

        public double CalculatePerimeter()
        {
            return 4 * SideA;
        }
    }
}
