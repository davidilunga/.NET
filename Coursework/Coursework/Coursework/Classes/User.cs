using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Classes
{
    public class User
    {
        public User(){}
        // Constructor setting new User information using the parameters passed.
        public User(String FName, String LName, String email, String dob, String sCode, String password, String aNumber, String cardName)
        {
            this.FirstName = FName;
            this.Surname = LName;
            this.Email = email;
            this.DOB = dob;
            this.SortCode = sCode;
            this.Password = password;
            this.AccountNumber = aNumber;
            this.CardName = cardName;
        }

        //----------------------------------------------------------------------------
        //Getters and setters for each variable.

        string fname;
        
        public String FirstName { get { return fname;} set { fname = value;} }
        
        string sname;
        
        public String Surname 
        {
            get { return sname; } 
            set { sname = value; } 
        }
        
        string email;
        
        public String Email 
        {
            get { return email; } 
            set { email = value; } 
        }
        
        string dob;
        
        public String DOB 
        {
            get { return dob; } 
            set { dob = value; } 
        }
        
        string sortCode;
        
        public String SortCode 
        {
            get { return sortCode; } 
            set { sortCode = value; } 
        }
        
        string password;
        
        public String Password 
        { 
            get { return password; } 
            set { password = value; } 
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
    }
}
