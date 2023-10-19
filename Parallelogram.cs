
namespace GeometryLibrary
{
    internal class Parallelogram
    {
        public double Base { get; set; } // Основание (база)
        public double Height { get; set; } // Высота
        public double Side { get; set; } // Сторона

        public double CalculateArea()
        {
            return Base * Height; // Вычисление площади параллелограмма: Площадь = Основание * Высота
        }

        public double CalculatePerimeter()
        {
            return 2 * (Base + Side); // Вычисление периметра параллелограмма: Периметр = 2 * (Основание + Сторона)
        }
    }
}
