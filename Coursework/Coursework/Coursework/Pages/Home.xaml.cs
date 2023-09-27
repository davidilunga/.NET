using Coursework.Classes;
using Coursework.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Coursework.Pages
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        User account;
        public Home()
        {
            InitializeComponent();
        }

        public Home(User person)
        {
            InitializeComponent();
            UserSignedIn.Content = person.FirstName + " " + person.Surname;
            account = person;
        }

        public void ViewContacts (object sender, RoutedEventArgs e)
        {
            ViewContactInfo f1 = new ViewContactInfo(account);
            f1.Show();
        }

        private void SendMoney(object sender, RoutedEventArgs e)
        {
            SendFinances f1 = new SendFinances(account);
            f1.Show();
        }
        
        private void ViewHistory(object sender, RoutedEventArgs e)
        {
            ViewTransactionHistory f1 = new ViewTransactionHistory(account);
            f1.Show();
        }
        
        private void ProduceFinancialReport(object sender, RoutedEventArgs e)
        {
            FinancialReport fr = new FinancialReport(account);
            fr.Show();
        }
        
        private void SignOut(object sender, RoutedEventArgs e)
        {
            DialogResult dialogResult = System.Windows.Forms.MessageBox.Show("Are you sure you want to sign out?","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                NavigationService.Navigate(new LoginPage());
            }
            
        }
    }
}
