using Coursework.Classes;
using Coursework.Databases;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coursework.Pages
{
    /// <summary>
    /// Interaction logic for NewPassword.xaml
    /// </summary>
    public partial class NewPassword : Page
    {
        List<User> userList = new List<User>();
        User account;
        JSON_Database data = new JSON_Database();

        public NewPassword()
        {
            InitializeComponent();
        }
        public NewPassword(User person)
        {
            InitializeComponent();
            account = person;
            userList = data.ReadJSONDatabase();//ReadTextDatabase();
            UserSignedIn.Content = person.FirstName + " " + person.Surname;
            
        }

        private void Button_GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (DefaultPassword.Password == ConfirmPassword.Password)
            {
                SaveChanges();
                NavigationService.Navigate(new LoginPage());
            } else 
            {
                MessageBox.Show("Incorrect details inputted. Please try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveChanges()
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList.ElementAt(i).FirstName == account.FirstName)
                {
                    userList.ElementAt(i).Password = ConfirmPassword.Password;
                    // WriteTextDatabase(userList);
                    MessageBox.Show("Your Password change has been successful", "Password Change", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            data.WriteJSONDatabase(userList);
        }
    }
}
