using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab2p2rpm
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
        private void ColorChange(object sender, SelectionChangedEventArgs e)
        {
            int a = ClrCg.SelectedIndex;
            switch (a)
            {
                case 0:
                    {
                        inkC.DefaultDrawingAttributes.Color = Colors.Black;
                        break;
                    }
                case 1:
                    {
                        inkC.DefaultDrawingAttributes.Color = Colors.DarkBlue;
                        break;
                    }
                case 2:
                    {
                        inkC.DefaultDrawingAttributes.Color = Colors.DarkRed;
                        break;
                    }
            }
        }

        private void Tolshina_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            inkC.DefaultDrawingAttributes.Width = Tolshina.Value;
            inkC.DefaultDrawingAttributes.Height = Tolshina.Value;
        }

        private void risovat_Checked(object sender, RoutedEventArgs e)
        {
            inkC.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void vybor_Checked(object sender, RoutedEventArgs e)
        {
            inkC.EditingMode = InkCanvasEditingMode.Select;
        }

        private void yDelete_Checked(object sender, RoutedEventArgs e)
        {
            inkC.EditingMode = InkCanvasEditingMode.EraseByStroke;
        }
    }
}
