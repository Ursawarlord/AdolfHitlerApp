using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
namespace Launcher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void ButonVizualizator3D(object sender, RoutedEventArgs e)
        {
                var vizualizator3d = new Vizualizator3D.MainWindow();
                vizualizator3d.Show();
        }

        private void ButonLectie(object sender, RoutedEventArgs e)
        {
            var lectie = new lectie.MainWindow();
            lectie.Show();
        }

        private void ButonReadMe(object sender, RoutedEventArgs e)
        {
            Process.Start(AppDomain.CurrentDomain.BaseDirectory + "../../readme.doc");
        }
    }
}
