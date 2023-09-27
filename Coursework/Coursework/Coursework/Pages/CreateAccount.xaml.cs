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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using Coursework.Classes;
using Coursework.Databases;
using System.IO;

namespace Coursework.Pages
{
    /// <summary>
    /// Interaction logic for CreateAccount.xaml
    /// </summary>
    public partial class CreateAccount : Page
    {
        
        string FName, LName, email, dob, sCode, password, aNumber, cardName;

        List<User> userList = new List<User>();
        EntryValidation validation = new EntryValidation();
        JSON_Database data = new JSON_Database();

        public CreateAccount()
        {
            InitializeComponent();
            SortCode.MaxLength = 8;
            AccountNumber.MaxLength = 8;
            userList = data.ReadJSONDatabase();//ReadTextDatabase();
        }

        private void SortCode_KeyDown(object sender, KeyEventArgs e)
        {
            string text = SortCode.Text;
            if ((text.Length + 1) % 3 == 0)
            {
                if (e.Key == Key.Back)
                { }
                else
                {
                    if (text.Length == 8)
                    {
                        SortCode.Text = text;
                        SortCode.Select(SortCode.Text.Length, SortCode.Text.Length);
                    }
                    else
                    {
                        SortCode.Text = text + "-";
                        SortCode.Select(SortCode.Text.Length, SortCode.Text.Length);
                    }
                }
            }
        }
        
        private void DOB_KeyDown(object sender, KeyEventArgs e)
        {
            string text = DOB.Text;
            if (text.Length <= 6)
            {
                if ((text.Length + 1) % 3 == 0)
                {
                    if (e.Key == Key.Back)
                    { }
                    else
                    {
                        DOB.Text = text + "-";
                        DOB.Select(DOB.Text.Length, DOB.Text.Length);
                    }
                }
            }
        }

        private void Button_GoBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void Button_Submit_Click(object sender, RoutedEventArgs e)
        {           
            FName = validation.ValidateNames(FirstName.Text);
            LName = validation.ValidateNames(LastName.Text);
            dob = DOB.Text;
            email = Email.Text;
            sCode = SortCode.Text;
            aNumber = validation.ValidateAccountNumber(AccountNumber.Text);
            cardName = validation.ValidateNames(NameOnCard.Text);
            password = Password.Password;

            if (validation.ValidateUserInformation(FName, LName, email, dob, sCode, password, aNumber, cardName) == true)
            {
                MessageBox.Show("All fields must be properly populated!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            User user = new User(FName, LName, email, dob, sCode, password, aNumber, cardName);
            userList.Add(user);
            //data.WriteTextDatabase(userList);
            data.WriteJSONDatabase(userList);

            ClearForm();
            ResultLabel.Content = "Form submitted successful";
            ResultLabel.Visibility = Visibility.Visible;
        }

        private void ClearForm()
        {
            FirstName.Text = string.Empty;
            LastName.Text = string.Empty;
            DOB.Text = string.Empty;
            Email.Text = string.Empty;
            SortCode.Text = string.Empty;
            AccountNumber.Text = string.Empty;
            NameOnCard.Text = string.Empty;
            Password.Password = string.Empty;
        }
    }
}
