namespace GeometryLibrary
{
    public class Trapezoid
    {
        public double Base1 { get; set; } // Большее основание
        public double Base2 { get; set; } // Меньшее основание
        public double Height { get; set; } // Высота
        public double Side1 { get; set; } // Боковая сторона 1
        public double Side2 { get; set; } // Боковая сторона 2

        public double CalculateArea()
        {
            // Вычисление площади трапеции: Площадь = (Сумма оснований / 2) * Высота
            return ((Base1 + Base2) / 2) * Height;
        }

        public double CalculatePerimeter()
        {
            // Вычисление периметра трапеции: Периметр = Сумма всех сторон
            return Base1 + Base2 + Side1 + Side2;
        }
    }
}
