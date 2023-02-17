using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Enter a command:");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter a password: ");
                        string password = Console.ReadLine();

                        // Instantiate an object of the AccounCreation class
                        AccountCreation account = new AccountCreation();

                        // Call the CreateAccount method and store the result in a StringBuilder object
                        StringBuilder errorMessage = account.createAccount(username, password);

                        if (errorMessage.Length >= 1)
                        {
                            Console.WriteLine("Error creating account:");
                            Console.WriteLine(errorMessage.ToString());
                        }
                        else if (errorMessage.Length == 0)
                        {
                            Console.WriteLine("Account created successfully!");
                        }
                        break;
                    case "2":
                        break;
                    case "exit":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }
    }
}
