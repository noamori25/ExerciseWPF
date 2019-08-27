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
using System.Windows.Threading;

namespace EX6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            EventHandler ev = (o, e) => {
                SetValue(userp, $"{user.Text} {pass.Text}" == "Noam 1234");
            };

            DispatcherTimer timer = new DispatcherTimer(TimeSpan.FromSeconds(1), DispatcherPriority.Normal,
                ev, Dispatcher);
        }


        public bool Login
        {
            get { return (bool)GetValue(userp); }
            set { SetValue(userp, value); }
        }

        public static readonly DependencyProperty userp =
            DependencyProperty.Register("Login", typeof(bool), typeof(MainWindow), new PropertyMetadata(false));
    }
}
