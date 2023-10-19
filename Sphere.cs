namespace GeometryLibrary
{   
    public class Sphere
    {
        public double Radius { get; set; } // Радиус шара

        public double CalculateVolume()
        {
            // Вычисление объема шара: Объем = (4/3) * π * R^3, где R - радиус
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }
    }
}
