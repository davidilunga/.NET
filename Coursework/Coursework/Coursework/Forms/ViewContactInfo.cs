using Coursework.Classes;
using Coursework.Databases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace Coursework.Forms
{
    public partial class ViewContactInfo : Form
    {
        String FName, LName, sortCode, accountNumber, ExpiryDate, CardName;
        List<Contacts> contacts = new List<Contacts>();
        List<Contacts> YourContacts = new List<Contacts>();
        User account;

        EntryValidation validation = new EntryValidation();
        JSON_Database data = new JSON_Database();

        public ViewContactInfo()
        {
            InitializeComponent();
        }
        
        public ViewContactInfo(User person)
        {
            InitializeComponent();
            ContactInfoListView.View = View.Details;
            account = person;
            UpdateListview();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (ContactInfoListView.Items.Count > 0)
            {
                i = ContactInfoListView.Items.IndexOf(ContactInfoListView.SelectedItems[0]);
            }

            fName_InfoLabel.Text = contacts.ElementAt(i).FirstName;
            lName_InfoLabel.Text = contacts.ElementAt(i).Surname;
            sCode_InfoLabel.Text = contacts.ElementAt(i).SortCode;
            aNumber_InfoLabel.Text = contacts.ElementAt(i).AccountNumber;
            expiryDate_InfoLabel.Text = contacts.ElementAt(i).ExpiryDate;
            cName_InfoLabel.Text = contacts.ElementAt(i).CardName;
        }

        private void sCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumFieldOnly(sender, e);
            string text = sCodeTextBox.Text;
            if((text.Length + 1) % 3 == 0)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                {}
                else
                {
                    if (text.Length == 8)
                    {
                        sCodeTextBox.Text = text;
                        sCodeTextBox.Select(sCodeTextBox.Text.Length, sCodeTextBox.Text.Length);
                    }
                    else
                    {
                        sCodeTextBox.Text = text + "-";
                        sCodeTextBox.Select(sCodeTextBox.Text.Length, sCodeTextBox.Text.Length);
                    }
                }
            }
        }

        private void expiryDateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumFieldOnly(sender, e);
            string text = expiryDateTextBox.Text;
            if ((text.Length + 1) % 3 == 0)
            {
                if (e.KeyChar == Convert.ToChar(Keys.Back))
                { }
                else
                {
                    if (text.Length == 5)
                    {
                        expiryDateTextBox.Text = text;
                        expiryDateTextBox.Select(expiryDateTextBox.Text.Length, expiryDateTextBox.Text.Length);
                    }
                    else
                    {
                        expiryDateTextBox.Text = text + "/";
                        expiryDateTextBox.Select(expiryDateTextBox.Text.Length, expiryDateTextBox.Text.Length);
                    }
                }
            }
        }

        private void aNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumFieldOnly(sender, e);
        }

        public void NumFieldOnly(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        
        private void AddContact(object sender, EventArgs e)
        {
            FName = validation.ValidateNames(fNameTextBox.Text.ToUpper());
            LName = validation.ValidateNames(lNameTextBox.Text.ToUpper());
            sortCode = sCodeTextBox.Text;
            accountNumber = validation.ValidateAccountNumber(aNumberTextBox.Text);
            ExpiryDate = expiryDateTextBox.Text;
            CardName = validation.ValidateNames(cardNameTextBox.Text.ToUpper());

            if (validation.ValidateContactInformation(FName, LName, sortCode, ExpiryDate, accountNumber, CardName) == true)
            {
                System.Windows.MessageBox.Show("All fields must be properly populated!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            Contacts contact = new Contacts(FName,LName,sortCode, ExpiryDate, accountNumber, CardName, account.Email);
            contacts.Add(contact);
            data.WriteJSONContactDatabase(contacts);
            ClearForm();
            UpdateListview();
        }

        private void UpdateListview()
        {
            contacts = data.ReadJSONContactDatabase();
            ContactInfoListView.Items.Clear();
            label1.Visible = false;
            
            for (int i = 0; i < contacts.Count; i++)
            {
                if (contacts.ElementAt(i).UserEmail == account.Email)
                {
                    YourContacts.Add(contacts.ElementAt(i));
                }
            }
            
            if (YourContacts.Count != 0)
            {
                for (int i = 0; i < YourContacts.Count; i++)
                {
                    string[] row = { i.ToString(), YourContacts.ElementAt(i).FirstName, YourContacts.ElementAt(i).Surname, YourContacts.ElementAt(i).SortCode, YourContacts.ElementAt(i).AccountNumber, YourContacts.ElementAt(i).ExpiryDate, YourContacts.ElementAt(i).CardName };
                    ListViewItem item = new ListViewItem(row);
                    ContactInfoListView.Items.Add(item);
                }
            }
            else
            {
                label1.Visible = true;
            }
        }

        private void ClearForm()
        {
            fNameTextBox.Text = "";
            lNameTextBox.Text = "";
            sCodeTextBox.Text = "";
            aNumberTextBox.Text = "";
            expiryDateTextBox.Text = "";
            cardNameTextBox.Text = "";
        }
    }
}
