namespace GeometryLibrary
{
    public class Cone
    {
        public double Radius { get; set; } // Радиус основания конуса
        public double Height { get; set; } // Высота конуса

        public double CalculateVolume()
        {
            // Вычисление объема конуса: Объем = (π * R^2 * H) / 3, где R - радиус, H - высота
            return (Math.PI * Math.Pow(Radius, 2) * Height) / 3;
        }
    }
}
