using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Coursework.Classes
{
    class EntryValidation
    {
        //Regular Expression, checking the validity of strings.
        string StringRegex = "^([a-zA-Z]+|[a-zA-Z]+\\s+[a-zA-Z]+|[a-zA-Z]+\\s+[a-zA-Z]+\\s+[a-zA-Z]+|[a-zA-Z]+\\s+[a-zA-Z]+\\s+[a-zA-Z]+\\s+[a-zA-Z]+)$";
        string NumberRegex = "^[0-9]*$";
        //if any of the required fields are empty
        public bool ValidateUserInformation(string FName, string LName, string email, string dob, string sCode, string password, string aNumber, string cardName)
        {
            return ((FName == "" || FName == null) || (LName == "" || LName == null) || (email == "" || email == null) || (dob == "" || dob == null) || (sCode == "" || sCode == null)
                || (password == "" || password == null) || (aNumber == "" || aNumber == null) || (cardName == "" || cardName == null));
        }

        public bool ValidateContactInformation(string FName, string LName, string sCode, string expiryDate, string aNumber, string cardName)
        {
            return ((FName == "" || FName == null) || (LName == "" || LName == null) ||  (sCode == "" || sCode == null)
                || (expiryDate == "" || expiryDate == null) || (aNumber == "" || aNumber == null) || (cardName == "" || cardName == null));
        }
        //String Validation for Names - can accept text with up to 4 spaces.
        public string ValidateNames(string name)
        {
            name = name.Trim();
            if (Regex.Match(name, StringRegex).Success)
            {
                return name;
            }
            else
            {
                return null;
            }
        }
        //Validating that the account number only constists of numbers.
        public string ValidateAccountNumber(string accountNumber)
        {
            if (Regex.Match(accountNumber, NumberRegex).Success)
            {
                return accountNumber;
            }
            else
            {
                return null;
            }
        }
    }
}
