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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        List<User> userList = new List<User>();

        JSON_Database data = new JSON_Database();

        public LoginPage()
        {
            InitializeComponent();
            userList = data.ReadJSONDatabase();
        }

        private void Button_SignIn_Click(object sender, RoutedEventArgs e)
        {
            //foreach (User person in userList)
            for(int i = 0; i < userList.Count; i++)
            {
                if ((UserEmail.Text == userList.ElementAt(i).Email) && (UserPassword.Password == userList.ElementAt(i).Password))
                {
                    MessageBox.Show("All details are correct.", "Sign In Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new Home(userList.ElementAt(i)));
                    break;
                }
                else if ((i == userList.Count - 1) && ((UserEmail.Text != userList.ElementAt(i).Email) || (UserPassword.Password != userList.ElementAt(i).Password)))
                {
                    MessageBox.Show("Incorrect details inputted. Please try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
        private void Button_CreateAccount_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new CreateAccount());
        }

        private void Button_ForgotPassword_Click(object sender, RoutedEventArgs e) 
        {
            NavigationService.Navigate(new ForgotPassword());
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
