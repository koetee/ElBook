using ElBook.Form_Select;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Windows.Markup;

namespace ElBook
{
   
    public enum StateMark
    {
        ㅤ,
        Н,

        [Display(Name = "2")]
        d,
        [Display(Name = "3")]
        c,
        [Display(Name = "4")]
        b,
        [Display(Name = "5")]
        a
    }
    public class Customer 
    {
        public string FirstName { get; set; }

        #region mark
        public StateMark Mark1 { get; set; }
        public StateMark Mark2 { get; set; }
        public StateMark Mark3 { get; set; }
        public StateMark Mark4 { get; set; }
        public StateMark Mark5 { get; set; }
        public StateMark Mark6 { get; set; }
        public StateMark Mark7 { get; set; }
        public StateMark Mark8 { get; set; }
        public StateMark Mark9 { get; set; }
        public StateMark Mark10 { get; set; }
        public StateMark Mark11 { get; set; }
        public StateMark Mark12 { get; set; }
        public StateMark Mark13 { get; set; }
        public StateMark Mark14 { get; set; }
        public StateMark Mark15 { get; set; }
        public StateMark Mark16 { get; set; }
        public StateMark Mark17 { get; set; }
        public StateMark Mark18 { get; set; }
        public StateMark Mark19 { get; set; }
        public StateMark Mark20 { get; set; }
        public StateMark Mark21 { get; set; }
        public StateMark Mark22 { get; set; }
        public StateMark Mark23 { get; set; }
        public StateMark Mark24 { get; set; }
        public StateMark Mark25 { get; set; }
        public StateMark Mark26 { get; set; }
        public StateMark Mark27 { get; set; }
        public StateMark Mark28 { get; set; }
        public StateMark Mark29 { get; set; }
        public StateMark Mark30 { get; set; }
        public StateMark Mark31 { get; set; }
        #endregion

        public override string ToString()
        {
            return FirstName;
        }
    }


    
    public partial class MainWindow : Window
    {

        public static List<Customer> users = new List<Customer>();

        public MainWindow()
        {
            InitializeComponent();
            //DataGridMain.ItemsSource = users
           

            users.Add(new Customer() { FirstName = "Лукьянов Владислав"});
          
            users.Add(new Customer() { FirstName = "Ли Дмитрий"});







           


        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ExitBut_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(-1);
        }

        private void MinBut_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        SelectForm SForm = new SelectForm();
        private void FormSh_Click(object sender, RoutedEventArgs e)
        {
           
            SForm.Show();
        }

        private void ReloadBut_Click(object sender, RoutedEventArgs e)
        {
            
            DataGridMain.ItemsSource = users;
            DataGridMain.Items.Refresh();
           
        }
    }
}
