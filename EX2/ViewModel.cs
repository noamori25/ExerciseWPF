using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;
using System.Windows.Threading;

namespace EX2
{
    class ViewModel : INotifyPropertyChanged, ICommand
    {
        private int number;
        public event PropertyChangedEventHandler PropertyChanged;
        public event EventHandler CanExecuteChanged;

        public int Number
        {
            get
            {
                return number;
            }
            set
            {
                number = value;
                OnPropertyChange("Number");
            }
        }

        public ViewModel()
        {
            Number = 50;
         
        }

        //first way
        public async void WithAsyncAwait()
        {
            while (Number > 0)
            {
                Number--;
                await Task.Run(() =>
                {
                    Thread.Sleep(250);
                });
            }
        }


        public void OnPropertyChange(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            for (int i = 50; i > 0; i--)
            {
                Number--;
            }
        }
    }
}
