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
    public partial class FinancialPrediction : Form
    {
        User user;
        List<Contacts> contacts = new List<Contacts>();                     //Global Variables accessed throughout the class.
        List<Transaction> transactionList = new List<Transaction>();
        JSON_Database data = new JSON_Database();
        List<Transaction> transactionBetweenDatesList = new List<Transaction>();
        List<int> year = new List<int>();
        DateTime FirstExpense = DateTime.Now;
        DateTime dateFrom;
        DateTime dateTo;
        float incomeAmount1 = 0;
        float incomeAmount2 = 0;
        float outgoingAmount1 = 0;
        float outgoingAmount2 = 0;
        int count1 = 0;
        int count2 = 0;
        float finalIncome = 0;
        float finalOutgoing = 0;

        public FinancialPrediction()
        {
            InitializeComponent();
        }
        public FinancialPrediction(User person)
        {
            InitializeComponent();
            user = person;

            transactionList = data.ReadJSONTransactionDatabase();   // Gains access to the transaction list for that user if one already exists.
            contacts = data.ReadJSONContactDatabase();  // Gains access to the contacts list if one already exists.
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FinancialReport fr = new FinancialReport(user);
            fr.Show();
            this.Hide();
        }

        private void ProjectionButton_Click(object sender, EventArgs e)
        {
            dateFrom = DatePickerFrom.Value;
            dateTo = DatePickerTo.Value;
            count1 = 0;
            count2 = 0;
            incomeAmount1 = 0;
            outgoingAmount1 = 0;
            incomeAmount2 = 0;
            outgoingAmount2 = 0;

            if (dateFrom > dateTo && (dateFrom.Date <= DateTime.Now.Date || dateTo.Date <= DateTime.Now.Date))
            {
                MessageBox.Show("That dates you select must be correct. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (dateFrom.Date >= DateTime.Now.Date.AddYears(1) || dateTo.Date >= DateTime.Now.Date.AddYears(1))
            {
                MessageBox.Show("That dates you select must be within the next year. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                for (int i = 0; i < transactionList.Count; i++)
                {
                    if (transactionList.ElementAt(i).Date.Year >= (dateFrom.Date.Year - 2) && transactionList.ElementAt(i).Date.Year <= dateTo.Date.Year - 1)
                    {
                        transactionBetweenDatesList.Add(transactionList.ElementAt(i));
                    }
                }

                for (int i = 0; i < transactionBetweenDatesList.Count; i++)
                {
                    if(transactionBetweenDatesList.ElementAt(i).Date.Month >= dateFrom.Date.Month && transactionBetweenDatesList.ElementAt(i).Date.Month <= dateTo.Date.Month)
                    {
                        
                        if (transactionBetweenDatesList.ElementAt(i).Date.Year >= (dateFrom.Date.Year - 2) && transactionBetweenDatesList.ElementAt(i).Date.Year <= (dateTo.Date.Year - 2))
                        {
                            if (transactionBetweenDatesList.ElementAt(i).Type == "Outgoing") 
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float transfer);
                                outgoingAmount1 += transfer;
                                count1++;
                            }
                            else if (transactionBetweenDatesList.ElementAt(i).Type == "Income")
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float transfer);
                                incomeAmount1 += transfer;
                                count1++;
                            }

                        }

                        if (transactionBetweenDatesList.ElementAt(i).Date.Year >= (dateFrom.Date.Year - 1) && transactionBetweenDatesList.ElementAt(i).Date.Year <= (dateTo.Date.Year - 1))
                        {
                            if (transactionBetweenDatesList.ElementAt(i).Type == "Outgoing")
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float transfer);
                                outgoingAmount2 += transfer;
                                count2++;
                            }
                            else if (transactionBetweenDatesList.ElementAt(i).Type == "Income")
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float transfer);
                                incomeAmount2 += transfer;
                                count2++;
                            }
                        }
                    }
                }

                //finalAmount = ((incomeAmount1 - outgoingAmount1) + (incomeAmount2 - outgoingAmount2)) / 2;
                finalIncome = ((incomeAmount1 + incomeAmount2) / 2) * 1.5f;
                finalOutgoing = ((outgoingAmount1 + outgoingAmount2) / 2) * 1.5f;
                PredictionLabel.Text = "Your yearly income for " + (dateFrom.Date.Year - 2) + " is " + incomeAmount1.ToString("c2") + ".\n\n" +
                    "Your yearly outgoings for " + (dateFrom.Date.Year - 2) + " is " + outgoingAmount1.ToString("c2") + ".\n\n" +
                    "Your yearly income for " + (dateTo.Date.Year - 1) + " is " + incomeAmount2.ToString("c2") + ".\n\n" +
                    "Your yearly outgoings for " + (dateFrom.Date.Year - 1) + " is " + outgoingAmount2.ToString("c2") + ".\n\n" +
                    "Your projected financial forcast between the dates " + dateFrom.ToString("d") +" to "+ dateTo.ToString("d") + " is: \n\n" +
                    "Income:" + finalIncome.ToString("c2") + "\n\n" +
                    "Outgoing: " + finalOutgoing.ToString("c2");
                PredictionLabel.Visible = true;
            }
        }
    }
}
