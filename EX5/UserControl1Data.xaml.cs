﻿using System;
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
    /// Interaction logic for UserControl1Data.xaml
    /// </summary>
    public partial class UserControl1Data : UserControl
    {
        ViewModel vm;
        public UserControl1Data()
        {
            vm = new ViewModel();
            InitializeComponent();
            datagrid.ItemsSource = vm.orders;
        }
    }
}
