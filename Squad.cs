namespace GeometryLibrary
{
    internal class Squad
    {
        public double SideA { get; set; }

        public double CalculateArea()
        {
            return SideA * SideA;
        }

        public double CalculatePerimeter()
        {
            return 4 * SideA; 
        }
    }
}
