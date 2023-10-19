namespace GeometryLibrary
{
    public class Cube
    {
        public double SideLength { get; set; } // Длина стороны куба

        public double CalculateVolume()
        {
            // Вычисление объема куба: Объем = a^3, где a - длина стороны куба
            return Math.Pow(SideLength, 3);
        }
    }
}
