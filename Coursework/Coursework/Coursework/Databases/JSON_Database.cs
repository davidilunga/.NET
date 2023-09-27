using Coursework.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Coursework.Databases
{
    class JSON_Database
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Write to the User JSON Database
        public void WriteJSONDatabase(List<User> userList)
        {
            var json = SerializeList(userList);
            WriteListToFile(json);
        }

        private static string SerializeList(List<User> user)
        {
            var serializedObject = JsonConvert.SerializeObject(user, Formatting.Indented);
            return serializedObject;
        }
        private static void WriteListToFile(string json)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\Users.txt", json);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Read entries from the User JSON Database

        public List<User> ReadJSONDatabase()
        {
            var json = ReadListFromFile();
            List<User> userList = DeserializeList(json);
            return userList;
        }

        private static string ReadListFromFile()
        {
            var serializedObject = File.ReadAllText(Environment.CurrentDirectory + "\\Users.txt");
            return serializedObject;
        }
        private static List<User> DeserializeList(string json)
        {
            var deserializedObject = JsonConvert.DeserializeObject<List<User>>(json);
            return deserializedObject;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Write to the Contact JSON Database
        public void WriteJSONContactDatabase(List<Contacts> contactList)
        {
            var json = SerializeContactList(contactList);
            WriteListToContactFile(json);
        }

        private static string SerializeContactList(List<Contacts> contacts)
        {
            var serializedObject = JsonConvert.SerializeObject(contacts, Formatting.Indented);
            return serializedObject;
        }
        private static void WriteListToContactFile(string json)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\Contacts.txt", json);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Read entries from the Contact JSON Database

        public List<Contacts> ReadJSONContactDatabase()
        {
            var json = ReadListFromContactFile();
            List<Contacts> contactList = DeserializeContactList(json);
            return contactList;
        }

        private static string ReadListFromContactFile()
        {
            var serializedObject = File.ReadAllText(Environment.CurrentDirectory + "\\Contacts.txt");
            return serializedObject;
        }
        private static List<Contacts> DeserializeContactList(string json)
        {
            var deserializedObject = JsonConvert.DeserializeObject<List<Contacts>>(json);
            return deserializedObject;
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Write to the Transaction JSON Database
        public void WriteJSONTransactionDatabase(List<Transaction> TransactionList)
        {
            var json = SerializeTransactionList(TransactionList);
            WriteListToTransactionFile(json);
        }

        private static string SerializeTransactionList(List<Transaction> transactions)
        {
            var serializedObject = JsonConvert.SerializeObject(transactions, Formatting.Indented);
            return serializedObject;
        }
        private static void WriteListToTransactionFile(string json)
        {
            File.WriteAllText(Environment.CurrentDirectory + "\\Transactions.txt", json);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------
        //Read entries from the Transaction JSON Database

        public List<Transaction> ReadJSONTransactionDatabase()
        {
            var json = ReadListFromTransactionFile();
            List<Transaction> TransactionList = DeserializeTransactionList(json);
            return TransactionList;
        }

        private static string ReadListFromTransactionFile()
        {
            var serializedObject = File.ReadAllText(Environment.CurrentDirectory + "\\Transactions.txt");
            return serializedObject;
        }
        private static List<Transaction> DeserializeTransactionList(string json)
        {
            var deserializedObject = JsonConvert.DeserializeObject<List<Transaction>>(json);
            return deserializedObject;
        }
    }
}
