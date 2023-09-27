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
    /// Interaction logic for ForgotPassword.xaml
    /// </summary>
    public partial class ForgotPassword : Page
    {
        List<User> userList = new List<User>();

        JSON_Database data = new JSON_Database();
        public ForgotPassword()
        {
            InitializeComponent();
            userList = data.ReadJSONDatabase();//ReadTextDatabase();
        }

        private void Button_GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Continue_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < userList.Count; i++)
            {
                if (Email.Text == userList.ElementAt(i).Email && FirstName.Text == userList.ElementAt(i).FirstName)
                {
                    MessageBox.Show("All details are correct.", "Sign In Successful", MessageBoxButton.OK, MessageBoxImage.Information);
                    NavigationService.Navigate(new NewPassword(userList.ElementAt(i)));
                    break;
                }
                else if ((i == userList.Count - 1) && !(Email.Text == userList.ElementAt(i).Email) && (FirstName.Text == userList.ElementAt(i).FirstName))
                {
                    MessageBox.Show("Incorrect details inputted. Please try again.", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
