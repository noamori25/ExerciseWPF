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

namespace EX5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       // ViewModel vm;
        public MainWindow()
        {
           // vm = new ViewModel();
            InitializeComponent();
            //DataContext = vm;
            
        }

        private void Button_ReadOnly(object sender, RoutedEventArgs e)
        {
            ReadOnlyData.Visibility = Visibility.Visible;
            EditData.Visibility = Visibility.Hidden;
            CustomizeData.Visibility = Visibility.Hidden;
        }

        private void Button_Auto(object sender, RoutedEventArgs e)
        {
            ReadOnlyData.Visibility = Visibility.Hidden;
            EditData.Visibility = Visibility.Visible;
            CustomizeData.Visibility = Visibility.Hidden;
        }

        private void Button_Customize(object sender, RoutedEventArgs e)
        {
            ReadOnlyData.Visibility = Visibility.Hidden;
            EditData.Visibility = Visibility.Hidden;
            CustomizeData.Visibility = Visibility.Visible;
        }
    }
}
