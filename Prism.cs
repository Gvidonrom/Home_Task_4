namespace GeometryLibrary
{
    public class Prism
    {
        public double BaseArea { get; set; } // Площадь основания призмы
        public double Height { get; set; }   // Высота призмы

        public double CalculateVolume()
        {
            // Вычисление объема призмы: Объем = Площадь основания * Высота
            return BaseArea * Height;
        }
    }
}
