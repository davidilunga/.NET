using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Classes
{
    class Contacts
    {
        public Contacts() { }
        // Constructor setting new Contact information using the parameters passed.
        public Contacts(String FName, String LName, String sCode, String expiryDate, String aNumber, String cardName, String userEmail)
        {
            this.FirstName = FName;
            this.Surname = LName;
            this.SortCode = sCode;
            this.ExpiryDate = expiryDate;
            this.AccountNumber = aNumber;
            this.CardName = cardName;
            this.userEmail = userEmail;
        }
        string fname;
        //----------------------------------------------------------------------------
        //Getters and setters for each variable.
        public String FirstName 
        { 
            get { return fname; } 
            set { fname = value; } 
        }

        string sname;

        public String Surname
        {
            get { return sname; }
            set { sname = value; }
        }

        string sortCode;

        public String SortCode
        {
            get { return sortCode; }
            set { sortCode = value; }
        }

        string expiryDate;

        public String ExpiryDate
        {
            get { return expiryDate; }
            set { expiryDate = value; }
        }

        string accountNumber;

        public String AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        string cardName;

        public String CardName
        {
            get { return cardName; }
            set { cardName = value; }
        }

        string userEmail;

        public String UserEmail
        {
            get { return userEmail; }
            set { userEmail = value; }
        }
    }
}
