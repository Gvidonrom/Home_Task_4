namespace GeometryLibrary
{    
    public class Cylinder
    {
        public double Radius { get; set; } // Радиус основания цилиндра
        public double Height { get; set; } // Высота цилиндра

        public double CalculateVolume()
        {
            // Вычисление объема цилиндра: Объем = π * R^2 * H, где R - радиус, H - высота
            return Math.PI * Math.Pow(Radius, 2) * Height;
        }
    }
}
