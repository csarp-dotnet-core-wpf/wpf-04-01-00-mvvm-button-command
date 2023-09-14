using RectangleProject.Models;

namespace RectangleProject.ViewModels
{
    public class RectangleViewModel
    {
        private Rectangle _rectangle;

        public RectangleViewModel()
        {
            _rectangle = new Rectangle(1, 1);
        }
    }
}
