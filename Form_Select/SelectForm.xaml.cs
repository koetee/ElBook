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
using System.Windows.Shapes;
using ElBook;

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

        private void addUsersBut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.users.Add(new Customer() { FirstName = UsersTextBox.Text });

            UsersComboBox_Loaded(sender, e);
        }


        private void UsersComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> usersTemp = new List<string>();
            foreach (Customer aPart in MainWindow.users) {
                usersTemp.Add(aPart.ToString());
            }
         
            var combo = sender as ComboBox;

           

            UsersComboBox.ItemsSource = usersTemp;
            UsersComboBox.SelectedIndex = 1;
        }

        private void deleteUserBut_click(object sender, RoutedEventArgs e)
        {
            MainWindow.users.RemoveAt(UsersComboBox.SelectedIndex);
            UsersComboBox_Loaded(sender, e);
        }
    }
}
