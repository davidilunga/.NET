using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Classes
{
    class Transaction
    {
        public Transaction()
        {

        }
        // Constructor setting new transaction information using the parameters passed.
        public Transaction(string userAccount, string selectedContact, bool recurring, string timePeriod, string schedule, DateTime date, int duration, string amount, string type, string email)
        {
            this.userAccount = userAccount;
            this.selectedContact = selectedContact;
            this.recurring = recurring;
            this.timePeriod = timePeriod;
            this.schedule = schedule;
            this.date = date;
            this.duration = duration;
            this.amount = amount;
            this.type = type;
            this.email = email;
        }
        //----------------------------------------------------------------------------
        //Getters and setters for each variable.
        string userAccount;

        public string UserAccount 
        { 
            get { return userAccount; } 
            set { userAccount = value; } 
        }
        
        string selectedContact;
        
        public string SelectedContact 
        { 
            get { return selectedContact; }
            set { selectedContact = value; }
        }
        
        bool recurring;
        
        public bool Recurring
        {
            get { return recurring; }
            set { recurring = value; }
        }
        
        string timePeriod;
        
        public string TimePeriod 
        {
            get { return timePeriod; }
            set { timePeriod = value; }
        }
        
        string schedule;
        
        public string Schedule 
        {
            get { return schedule; }
            set { schedule = value; }
        }
        
        DateTime date;
        
        public DateTime Date 
        {
            get { return date; } 
            set { date = value; }
        }
        
        int duration;
        
        public int Duration 
        {
            get { return duration; }
            set { duration = value; }
        }
        
        string amount;
        
        public string Amount 
        {
            get { return amount; }
            set { amount = value; } 
        }
        
        string email;
        
        public string Email 
        {
            get { return email; }
            set { email = value; }
        }

        string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
