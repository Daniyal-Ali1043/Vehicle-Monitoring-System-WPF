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
using System.Windows.Shapes;

namespace p2
{
    /// <summary>
    /// Interaction logic for InOutWindow.xaml
    /// </summary>
    public partial class InOutWindow : Window
    {   
        enrtypage e1=new enrtypage();
        MainWindow mainWindow = new MainWindow();
        public InOutWindow()
        {
            InitializeComponent();
            myframe.Content = e1;
        }
        private void entrypage_Click(object sender, RoutedEventArgs e)
        {
            myframe.Content = e1;
        }

        
        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the current SuperAdmin window
            this.Close();

            // Open a new instance of the MainWindow

            mainWindow.Show();
        }
    }
}
