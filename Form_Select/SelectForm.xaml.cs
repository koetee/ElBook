using System;
using System.Collections.Generic;
using System.IO;
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
using Newtonsoft.Json;

namespace ElBook.Form_Select
{
    /// <summary>
    /// Логика взаимодействия для SelectForm.xaml
    /// </summary>
    public partial class SelectForm : Window
    {
        private void ForeachEntityCustomer()
        {
            List<string> usersTemp = new List<string>();
            foreach (Customer aPart in MainWindow.users) {
                usersTemp.Add(aPart.ToString());
            }
            UsersComboBox.ItemsSource = usersTemp;

            ObjectC.SaveUsers(path: MainWindow.CurretJsonFile);
           

            MainWindow.IsUpdateMode = true;
        }

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

            ForeachEntityCustomer();
        }


        private void UsersComboBox_Loaded(object sender, RoutedEventArgs e)
        {
            ForeachEntityCustomer();

        }

        private void deleteUserBut_click(object sender, RoutedEventArgs e)
        {
            MainWindow.users.RemoveAt(UsersComboBox.SelectedIndex);
            ForeachEntityCustomer();
        }
    }
}
