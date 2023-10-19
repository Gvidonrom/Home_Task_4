namespace GeometryLibrary
{
    public class Quadrilateral
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public double CalculateArea()
        {
            // Вычисление площади свободного четырехугольника с использованием формулы Герона
            double s = (SideA + SideB + SideC + SideD) / 2;
            double area = Math.Sqrt((s - SideA) * (s - SideB) * (s - SideC) * (s - SideD));
            return area;
        }

        public double CalculatePerimeter()
        {
            // Вычисление периметра свободного четырехугольника
            return SideA + SideB + SideC + SideD;
        }
    }
}
