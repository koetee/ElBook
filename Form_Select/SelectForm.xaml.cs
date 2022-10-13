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

namespace ElBook.Form_Select
{
    /// <summary>
    /// Логика взаимодействия для SelectForm.xaml
    /// </summary>
    public partial class SelectForm : Window
    {
        public SelectForm()
        {
            InitializeComponent();
           
        }

        private void SelectForm_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
        }
    }
}
