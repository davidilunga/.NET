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
    public partial class FinancialReport : Form
    {
        User user;
        List<Contacts> contacts = new List<Contacts>();                     //Global Variables accessed throughout the class.
        List<Transaction> transactionList = new List<Transaction>();
        JSON_Database data = new JSON_Database();
        List<Transaction> transactionBetweenDatesList = new List<Transaction>();
        List<int> year = new List<int>();
        List<int> monthsList = new List<int>();
        DateTime FirstExpense = DateTime.Now;
        DateTime dateFrom;
        DateTime dateTo;
        float monthlyIncome = 0; 
        float monthlyExpense = 0;
        float yearlyIncome = 0;
        float yearlyExpense = 0;
        public FinancialReport()
        {
            InitializeComponent();
        }

        public FinancialReport(User person)
        {
            InitializeComponent();
            
            user = person;

            transactionList = data.ReadJSONTransactionDatabase();   // Gains access to the transaction list for that user if one already exists.
            contacts = data.ReadJSONContactDatabase();  // Gains access to the contacts list if one already exists.
        }

        private void FindExpensesButton_Click(object sender, EventArgs e)
        {
            dateFrom = DatePickerFrom.Value;
            dateTo = DatePickerTo.Value;

            if (dateFrom > dateTo ) 
            {
                MessageBox.Show("That dates you select must be correct. Please try again.", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                year.Clear();
                transactionBetweenDatesList.Clear();
                monthlyIncome = 0;
                monthlyExpense = 0;
                for (int i = 0; i < transactionList.Count; i++)
                {
                    if (transactionList.ElementAt(i).Date >= dateFrom && transactionList.ElementAt(i).Date <= dateTo) 
                    {
                        transactionBetweenDatesList.Add(transactionList.ElementAt(i));
                    }
                }

                for (int i = dateFrom.Year; i <= dateTo.Year; i++)
                {
                    year.Add(i);
                }
                
                ReportListView.Items.Clear();

                for (int j = 0; j < year.Count; j++)
                {
                    yearlyIncome = 0;
                    yearlyExpense = 0;
                    FirstExpense = DateTime.Now;
                    for (int i = 0; i < transactionBetweenDatesList.Count; i++)
                    {
                        if (transactionBetweenDatesList.ElementAt(i).Date.Year == year.ElementAt(j))
                        {
                            if (transactionBetweenDatesList.ElementAt(i).Date < FirstExpense && transactionBetweenDatesList.ElementAt(i).Date.Year == year.ElementAt(j))
                            {
                                FirstExpense = transactionBetweenDatesList.ElementAt(i).Date;
                            }
                            
                            if (transactionBetweenDatesList.ElementAt(i).Type == "Income")
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float amount);
                                yearlyIncome += amount;
                                if (!monthsList.Contains(transactionBetweenDatesList.ElementAt(i).Date.Month))
                                {
                                    monthsList.Add(transactionBetweenDatesList.ElementAt(i).Date.Month);
                                }
                            }

                            else if (transactionBetweenDatesList.ElementAt(i).Type == "Outgoing")
                            {
                                float.TryParse(transactionBetweenDatesList.ElementAt(i).Amount, out float amount);
                                yearlyExpense += amount;
                                if (!monthsList.Contains(transactionBetweenDatesList.ElementAt(i).Date.Month))
                                {
                                    monthsList.Add(transactionBetweenDatesList.ElementAt(i).Date.Month);
                                }
                            }
                        }
                    }

                    if (yearlyIncome == 0 && yearlyExpense == 0)
                    {
                        monthlyIncome = 0;
                        monthlyExpense = 0;
                    }
                    else 
                    { 
                        monthlyIncome = yearlyIncome / monthsList.Count;
                        monthlyExpense = yearlyExpense / monthsList.Count;
                    }

                    string[] row = { year.ElementAt(j).ToString(), FirstExpense.ToString("d"),monthlyIncome.ToString("c2"), monthlyExpense.ToString("c2"), yearlyIncome.ToString("c2"), yearlyExpense.ToString("c2"), monthsList.Count + " Months"};
                    ListViewItem item = new ListViewItem(row);
                    ReportListView.Items.Add(item);
                }
            }
        }

        private void Prediction_Click(object sender, EventArgs e)
        {
            FinancialPrediction fp = new FinancialPrediction(user);
            fp.Show();
            this.Hide();
        }
    }
}
