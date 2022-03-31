using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ViewModels.BaseClass;
using RectangleProject.Models;
using System.Windows;

namespace RectangleWpfProject.ViewModels
{
    class RectangleViewModel : ViewModelBase
    {
        private Rectangle rectangle;


        public RectangleViewModel()
        {
            rectangle = new Rectangle(1, 1);
            // RC.06 A két parancsot példányosítjuk. Meghatározzuk azokat a metódusokat, amelyeket végrehajtanak.
            CloseCommand = new RelayCommand(execute => CloseWindow());
            ComputeCommand = new RelayCommand(execute => ComputeResult());
        }

        public string SideA
        {
            get
            {
                return rectangle.SideA.ToString();
            }

            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    rectangle.SideA = side;
                }
                catch (Exception e)
                {
                }
            }
        }

        public string SideB
        {
            get
            {
                return rectangle.SideB.ToString();
            }

            set
            {
                try
                {
                    double side = Convert.ToDouble(value);
                    rectangle.SideB = side;
                }
                catch (Exception e)
                {
                }
            }
        }

        public string Perimeter
        {
            get
            {
                double roundedPerimeter = Math.Round(rectangle.Perimeter, 2);
                return "A téglalap kerülete: " + roundedPerimeter.ToString() + " méter.";
            }
        }

        public string Area
        {
            get
            {
                double roundedArea = Math.Round(rectangle.Area, 2);
                return "A téglalap területe: " + roundedArea.ToString() + " négyzetméter.";
            }
        }

        // RC.05 Két parancsot hozunk létre a kötésben szereplő nevekkel
        public RelayCommand CloseCommand { get; private set; }
        public RelayCommand ComputeCommand { get; private set; }

        // RC.07 a két metódust megírjuk. A program működik.
        public void CloseWindow()
        {
            Application.Current.Windows[0].Close();
        }

        public void ComputeResult()
        {
            OnPropertyChanged("Perimeter");
            OnPropertyChanged("Area");
        }
    }
}
