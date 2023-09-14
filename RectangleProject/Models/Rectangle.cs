namespace RectangleProject.Models
{
    public class Rectangle
    {
        private double _sideA;
        private double _sideB;

        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }

        public double SideA { get => _sideA; set => _sideA = value; }
        public double SideB { get => _sideB; set => _sideB = value; }

        public double Area
        {
            get { return _sideA * _sideB; }
        }

        public double Perimeter
        {
            get { return 2 * (_sideA + _sideB); }
        }
    }
}
