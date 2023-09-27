using Coursework.Classes;
using Coursework.Databases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class ViewTransactionHistory : Form
    {
        User user;
        JSON_Database data = new JSON_Database();
        List<User> FullUsers = new List<User>();
        List<Contacts> FullContact = new List<Contacts>();
        List<Transaction> FullTransaction = new List<Transaction>();

        List<Contacts> UsedContactList = new List<Contacts>();
        List<Transaction> UsedTransactionList = new List<Transaction>();
        string ContactFName, ContactLName, contactSortCode,ContactANumber, recurring;
        public ViewTransactionHistory(User person)
        {
            InitializeComponent();
            user = person;
            

            FullUsers = data.ReadJSONDatabase();
            FullContact = data.ReadJSONContactDatabase();
            FullTransaction = data.ReadJSONTransactionDatabase();

            for (int i = 0; i < FullContact.Count; i++)
            {
                if (FullContact.ElementAt(i).UserEmail.Equals(user.Email)) 
                {
                    UsedContactList.Add(FullContact.ElementAt(i));
                }
            }

            for (int i = 0; i < FullTransaction.Count; i++)
            {
                if (FullTransaction.ElementAt(i).Email.Equals(user.Email))
                {
                    UsedTransactionList.Add(FullTransaction.ElementAt(i));
                }
            }

            for (int i = 0; i < UsedTransactionList.Count; i++) 
            {
                string[] info = UsedTransactionList.ElementAt(i).SelectedContact.Split('/');
                foreach (Contacts contact in UsedContactList) 
                {
                    if ((contact.SortCode == info[0]) && (contact.AccountNumber == info[1]))
                    {
                        ContactFName = contact.FirstName;
                        ContactLName = contact.Surname;
                        contactSortCode = contact.SortCode;
                        ContactANumber = contact.AccountNumber;
                    }
                }
                if (UsedTransactionList.ElementAt(i).Recurring == true)
                {
                    recurring = "Yes";
                }
                else 
                {
                    recurring = "No";
                }
                if (UsedTransactionList.ElementAt(i).Type == "Outgoing")
                {
                    string[] row = { user.FirstName + " " + user.Surname+" (Myself)", UsedTransactionList.ElementAt(i).SelectedContact,ContactFName + " " + ContactLName, contactSortCode,
                    ContactANumber, recurring, UsedTransactionList.ElementAt(i).Date.ToString("d"), UsedTransactionList.ElementAt(i).Duration.ToString(), UsedTransactionList.ElementAt(i).Schedule,
                    UsedTransactionList.ElementAt(i).TimePeriod, "£"+UsedTransactionList.ElementAt(i).Amount};
                    ListViewItem item = new ListViewItem(row);
                    TransactionListView.Items.Add(item);
                }
                else if (UsedTransactionList.ElementAt(i).Type == "Income")
                {
                    string[] row = { ContactFName + " " + ContactLName, UsedTransactionList.ElementAt(i).UserAccount, user.FirstName + " " + user.Surname+" (Myself)", user.SortCode,
                    user.AccountNumber, recurring, UsedTransactionList.ElementAt(i).Date.ToString("d"), UsedTransactionList.ElementAt(i).Duration.ToString(), UsedTransactionList.ElementAt(i).Schedule,
                    UsedTransactionList.ElementAt(i).TimePeriod, "£"+UsedTransactionList.ElementAt(i).Amount};
                    ListViewItem item = new ListViewItem(row);
                    TransactionListView.Items.Add(item);
                }
            }
        }
    }
}