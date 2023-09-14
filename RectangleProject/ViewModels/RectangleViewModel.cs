using RectangleProject.Models;
using System;

namespace RectangleProject.ViewModels
{
    public class RectangleViewModel
    {
        private Rectangle _rectangle;

        public RectangleViewModel()
        {
            _rectangle = new Rectangle(1, 1);
        }

        public string SideA
        {
            get
            {
                return _rectangle.SideA.ToString();
            }
            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    _rectangle.SideA = side;
                }
                catch (Exception e)
                {
                }
            }
        }
    }
}
