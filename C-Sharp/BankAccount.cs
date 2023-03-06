using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace C_Sharp
{
    public class BankAccount
    {

        /* Methods */
        public StringBuilder createAccount(string username, string password, string p=null)
        {
            // Instantiate an object of the StringBuilder class
            StringBuilder message = new StringBuilder();

            // Username checker
            if (username.Length < 5)
            {
                message.Append("Name is too short\n");
            }
            if (username.Length > 100)
            {
                message.Append("Name is too long\n");
            }

            // Password checker
            if (password.Length < 8)
            {
                message.Append("The password must be at least 8 characters long.\n");
            }
            if (!Regex.IsMatch(password, @"^(?=.*[A-Z]).+$"))
            {
                message.Append("The password must contain at least one uppercase letter.\n");
            }
            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                message.Append("The password must contain at least one lowercase letter.\n");
            }
            if (!Regex.IsMatch(password, @"\d"))
            {
                message.Append("The password must contain at least one number.\n");
            }
            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
            {
                message.Append("The password must contain at least one special character.\n");
            }

            // If there are any error messages, return the message StringBuilder
            if (message.Length > 0)
            {
                return message;
            }
            else
            {
                string path = "C:\\Users\\Administrator\\source\\repos\\C-Sharp\\C-Sharp\\database.txt"; 
                using (StreamWriter writer = new StreamWriter(path, true))
                {
                     writer.WriteLine($"{username};{password}");
                }

            }
            return null;
        }

        public bool CheckCredentials(string loginUsername, string loginPassword)
        {
            string path = "C:\\Users\\Administrator\\source\\repos\\C-Sharp\\C-Sharp\\database.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] credentials = line.Split(';');
                    if (credentials[0] == loginUsername && credentials[1] == loginPassword)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
