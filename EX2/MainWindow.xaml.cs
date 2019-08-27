using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace EX2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ViewModel vm;
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            vm = new ViewModel();
            InitializeComponent();
            DataContext = vm;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //first way
            //vm.WithAsyncAwait();

            //second way
            //Task.Run(() => { WithDispacherSafePattern(() => { vm.Number--; }); });

            //Third Way
            //timer.Interval = TimeSpan.FromSeconds(0.25);
            //timer.Tick += WithDispatcherTimer;
            //timer.Start();
        }

        //Second way
        public void WithDispacherSafePattern (Action a)
        {
            while (vm.Number > 0)
            {
                if (Dispatcher.CheckAccess())
                {
                    a.Invoke();
                }
                else
                {
                    Dispatcher.Invoke(a);
                    Thread.Sleep(250);
                }
            }
        }

        //Third way
        public void WithDispatcherTimer(object sender, EventArgs e)
        {
            if (vm.Number > 0)
            {
                vm.Number--;
                Task.Run(() => { Thread.Sleep(250); });
            }
            else
            {
                timer.Stop();
            }
        }


    }
}
