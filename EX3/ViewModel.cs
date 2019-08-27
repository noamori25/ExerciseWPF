using Prism.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EX3
{
    class ViewModel : INotifyPropertyChanged, IDataErrorInfo
    {
        private string name = "";
        public string Name
        {
            get
            {
                return name;

            }
            set
            {
                name = value;
                OnPropertyChanged("Name");
                CommandCancel.RaiseCanExecuteChanged();
                CommandGo.RaiseCanExecuteChanged();
            }
        }

        public DelegateCommand CommandGo { get; set; }
        public DelegateCommand CommandCancel { get; set; }

        public string Error
        {
            get
            {
                return $"Error";
            }
        }

        public string this[string columnName]
        {
            get
            {
                return GetDataError(columnName);
            }
        }

        public string GetDataError(string propertyName)
        {
            switch (propertyName)
            {
                case "Name":
                    if (Name.Length > 10)
                    {
                        return Error;
                    }
                    else
                        return string.Empty;

            }
            return string.Empty;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel()
        {
            CommandGo = new DelegateCommand(ExecauteGo,CanExecauteGo);
            CommandCancel = new DelegateCommand(ExecauteCancel, CanExecauteCancel);
        }

        public void ExecauteCancel ()
        {
            Name = " ";
        }

        public bool CanExecauteCancel ()
        {
            return (Name.Length > 0);
        }
        public void ExecauteGo ()
        {
            MessageBox.Show("Hello " + Name);
        }

        public bool CanExecauteGo ()
        {
            return (Name.Length >= 3);
        }
        public void OnPropertyChanged (string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
