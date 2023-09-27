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
    public partial class SendFinances : Form
    {
        User user;
        List<string> accountInfo = new List<string>();
        List<Contacts> contacts = new List<Contacts>();                     //Global Variables accessed throughout the class.
        List<Transaction> transactionList = new List<Transaction>();
        JSON_Database data = new JSON_Database();
        string timePeriod;
        string schedule;
        Transaction transaction;
        public SendFinances()
        {
            InitializeComponent();
        }

        public SendFinances(User person)
        {
            InitializeComponent();
            user = person;

            string info = person.SortCode + "/" + person.AccountNumber;
            accountInfo.Add(info);
            for(int i = 0; i < accountInfo.Count;i++)
            {
                AccountBox.Items.Add(accountInfo.ElementAt(i));
            }
            transactionList = data.ReadJSONTransactionDatabase();   // Gains access to the transaction list for that user if one already exists.
            contacts = data.ReadJSONContactDatabase();  // Gains access to the contacts list if one already exists.
            for (int i = 0; i < contacts.Count; i++)    // ISolates the user's contacts from all the contacts that were saved in the file.
            {
                if (contacts.ElementAt(i).UserEmail == person.Email)
                {
                    string contactInfo = contacts.ElementAt(i).SortCode + "/" + contacts.ElementAt(i).AccountNumber;
                    ContactAccount.Items.Add(contactInfo);
                }
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //Event Handlers that react to the changes the user makes.
        private void ScheduledPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (ScheduledPayment.Checked == true)
            {
                ScheduleSelector.Visible = true;
                CheckEstimationLabel();
            }
            else
            {
                ScheduleSelector.Visible = false;
            }
        }
        
        private void RecurringPayment_CheckedChanged(object sender, EventArgs e)
        {
            if (!Income.Checked && !Outgoing.Checked && RecurringPayment.Checked)
            {
                MessageBox.Show("You must select what type of payment this is. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RecurringPayment.Checked = false;
                return;
            }
            if (RecurringPayment.Checked == true)
            {
                TimeIInterval.Visible = true;
                Duration.Value = 1;
                CheckEstimationLabel();
            }
            else
            {
                TimeIInterval.Visible = false;
                EstimationLabel.Visible = false;
                DurationPanel.Visible = false;

                Monthly.Checked = false;
                Yearly.Checked = false;
                Duration.Value = 0;
                ScheduledPayment.Checked = false;
                ImmediatePayment.Checked = false;
            }
        }

        private void ScheduleSelector_ValueChanged(object sender, EventArgs e)
        {
            CheckEstimationLabel();
        }

        private void Duration_ValueChanged(object sender, EventArgs e)
        {
            if(Duration.Value == 0)
            {
                RecurringPayment.Checked = false;
                Monthly.Checked = false;
                Yearly.Checked = false;
            }
            CheckEstimationLabel();
        }

        private void Yearly_CheckedChanged(object sender, EventArgs e)
        {
            CheckEstimationLabel();
        }

        private void Monthly_CheckedChanged(object sender, EventArgs e)
        {
            CheckEstimationLabel();
        }
        private void AmountTextbox_TextChanged(object sender, EventArgs e)
        {
            CheckEstimationLabel();
        }

        private void ImmediatePayment_CheckedChanged(object sender, EventArgs e)
        {
            CheckEstimationLabel();
        }

        private void ContactAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string info = ContactAccount.SelectedItem.ToString();
            string[] findInfo = info.Split('/');

            for (int i = 0; i < contacts.Count; i++)
            {
                if ((contacts.ElementAt(i).SortCode == findInfo[0])&&(contacts.ElementAt(i).AccountNumber == findInfo[1])) 
                {
                    fName_InfoLabel.Text = contacts.ElementAt(i).FirstName;
                    lName_InfoLabel.Text = contacts.ElementAt(i).Surname;
                    sCode_InfoLabel.Text = contacts.ElementAt(i).SortCode;
                    aNumber_InfoLabel.Text = contacts.ElementAt(i).AccountNumber;
                    expiryDate_InfoLabel.Text = contacts.ElementAt(i).ExpiryDate;
                    cName_InfoLabel.Text = contacts.ElementAt(i).CardName;
                    break;
                }
            }
        }

        private void AmountTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&(e.KeyChar != '.'))    //This ensures that the user can only enter numbers (no letters) and one decimal
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1)) // allows the user to only enter one decimal place.
            {
                e.Handled = true;
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------

        public void CheckEstimationLabel() 
        {
            DateTime Date = ScheduleSelector.Value;
            int duration = (int)Duration.Value;

            string amount = AmountTextbox.Text.ToString();

            if (Monthly.Checked == true)
            {
                if (ImmediatePayment.Checked) 
                {
                    EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + DateTime.Now.ToString("d") + " for " + duration + " months"; // Tells the user when their next payment is due, depending on their selectiions.
                }
                else
                {
                    DateTime MonthDate = Date.AddMonths(1);
                    if (Date <= DateTime.Now.Date && DateTime.Now.Month - Date.Month <= 1)
                    {
                        EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + MonthDate.ToString("d") + " for " + duration + " months";
                    }
                    else
                    {
                        EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + Date.ToString("d") + " for " + duration + " months";
                    }
                }
            } 
            else if (Yearly.Checked == true)
            {
                if (ImmediatePayment.Checked)
                {
                    EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + DateTime.Now.ToString("d") + " for " + duration + " years";
                }
                else
                {
                    DateTime YearDate = Date.AddYears(1);
                    if (Date <= DateTime.Now.Date && DateTime.Now.Year - Date.Year <= 1)
                    {
                        EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + YearDate.ToString("d") + " for " + duration + " years";
                    }
                    else
                    {
                        EstimationLabel.Text = "Next payment of £" + amount + " is due on: " + Date.ToString("d") + " for " + duration + " years";
                    }
                }
            } 

            if ((RecurringPayment.Checked == true) && ((Monthly.Checked == true || Yearly.Checked == true)))
            {
                EstimationLabel.Visible = true;
                DurationPanel.Visible = true;
            }
            else 
            {
                EstimationLabel.Visible = false;
            }
        }
        //When the submit button is pressed to save the new transaction/expense
        private void Continue_Click(object sender, EventArgs e)
        {
            string userAccount = AccountBox.SelectedItem.ToString();
            string selectedContact = ContactAccount.SelectedItem.ToString();
            bool recurring = RecurringPayment.Checked;

            if (!Income.Checked && !Outgoing.Checked)
            {
                MessageBox.Show("You must select what type of payment this is. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RecurringPayment.Checked)
            {
                if (Monthly.Checked) 
                {
                    timePeriod = "Monthly"; 
                }
                else if (Yearly.Checked) 
                {
                    timePeriod = "Yearly";
                }
                else
                {
                    recurring = !RecurringPayment.Checked;
                    timePeriod = null;
                }
            }
            
            if (ScheduledPayment.Checked)
            {
                schedule = "Scheduled";
            }
            else if (ImmediatePayment.Checked)
            {
                schedule = "Immediate";
            }

            if ((ImmediatePayment.Checked = false) && ScheduledPayment.Checked == false)
            {
                MessageBox.Show("You must select when the payment will be made. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((Monthly.Checked && (DateTime.Now.Month - ScheduleSelector.Value.Month >= 1)) || (Yearly.Checked && (DateTime.Now.Year - ScheduleSelector.Value.Year >= 1)))    //Sets a limit, the user cannot set up a recurring payment that started more than 1 month or 1 year (depending on selection)  before the date the application is run.
            {
                MessageBox.Show("This date is out of range. Please try again. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime Date = ScheduleSelector.Value;
            int duration = (int)Duration.Value;
            string amount = AmountTextbox.Text.ToString();
            Int32.TryParse(amount, out int transAmount);
            if (transAmount >= 10000) // MAximum transaction amount is £10,000
            {
                MessageBox.Show("This is an invalid amount. Please try again.", "Invalid Amount",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
            if (Income.Checked)
            {
                transaction = new Transaction(userAccount, selectedContact, recurring, timePeriod, schedule, Date, duration, amount, "Income", user.Email); // Creates a new teansaction
            }
            else if (Outgoing.Checked)
            {
                transaction = new Transaction(userAccount, selectedContact, recurring, timePeriod, schedule, Date, duration, amount, "Outgoing", user.Email); // Creates a new teansaction
            }
            
            transactionList.Add(transaction); // Adds the transaction to the list
            data.WriteJSONTransactionDatabase(transactionList); // List is then written into the transaction text file to store it's data.
            MessageBox.Show("Transaction successfully added", "Transaction added", MessageBoxButtons.OK, MessageBoxIcon.Information); // User is notified that it was a sucess.
        }
    }
}
