namespace GeometryLibrary
{   
    public class Pyramid
    {
        public double BaseArea { get; set; } // Площадь основания пирамиды
        public double Height { get; set; }   // Высота пирамиды

        public double CalculateVolume()
        {
            // Вычисление объема пирамиды: Объем = (Площадь основания * Высота) / 3
            return (BaseArea * Height) / 3;
        }
    }
}
