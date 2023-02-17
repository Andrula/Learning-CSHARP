using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Deployment.Internal;

namespace C_Sharp
{
    public class AccountCreation
    {
        public StringBuilder createAccount(string username, string password)
        {
            // Instantiate an object of the StringBuilder class
            StringBuilder errorMessage = new StringBuilder();

            //
            bool hasLowerCase = Regex.IsMatch(password, @"[a-z]");
            bool hasNumber = Regex.IsMatch(password, @"\d");
            bool hasSpecialCharacter = Regex.IsMatch(password, @"[^a-zA-Z0-9]");
            bool hasUpperCase = Regex.IsMatch(password, @"^(?=.*[A-Z]).+$");

            if (password.Length < 8)
            {
                errorMessage.Append("The password must be at least 8 characters long.\n");
            }
            if (!hasUpperCase)
            {
                errorMessage.Append("The password must contain at least one uppercase letter.\n");
            }
            if (!hasLowerCase)
            {
                errorMessage.Append("The password must contain at least one lowercase letter.\n");
            }
            if (!hasNumber)
            {
                errorMessage.Append("The password must contain at least one number.\n");
            }
            if (!hasSpecialCharacter)
            {
                errorMessage.Append("The password must contain at least one special character.\n");
            }
            if (errorMessage.Length == 0)
            {
                errorMessage.Append("The password meets all requirements.");
                // create the user in here
            }
            else
            {
                score++;
            }
            return errorMessage;
        }
    }
}
