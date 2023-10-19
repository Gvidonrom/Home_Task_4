namespace GeometryLibrary
{
    public class Parallelepiped
    {
        public double Length { get; set; } // Длина
        public double Width { get; set; }  // Ширина
        public double Height { get; set; } // Высота

        public double CalculateVolume()
        {
            // Вычисление объема параллелепипеда: Объем = Длина * Ширина * Высота
            return Length * Width * Height;
        }
    }
}
