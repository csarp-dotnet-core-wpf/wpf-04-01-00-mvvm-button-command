using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using RectangleWpfProject.Views;
using RectangleWpfProject.ViewModels;

namespace RectangleWpfProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            RectangleViewModel rectangleViewModel = new RectangleViewModel();
            window.DataContext = rectangleViewModel;
            window.Show();

            base.OnStartup(e);
        }
    }
}
