using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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
                Console.Clear();
                Console.WriteLine("1. Create a new account.");
                Console.WriteLine("2. Login to existing an account");
                Console.WriteLine("4. Stop program");
                Console.WriteLine("");
                Console.Write("Enter a command: ");
                
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter a username: ");
                        string username = Console.ReadLine();
                        Console.Write("Enter a password: ");
                        string password = Console.ReadLine();

                        // Instantiate an object of the AccounCreation class
                        BankAccount account = new BankAccount();

                        // Call the CreateAccount method and store the result in a StringBuilder object
                        StringBuilder errorMessage = account.createAccount(username, password);

                        if (errorMessage != null)
                        {
                            Console.WriteLine("Error creating account:");
                            Console.WriteLine(errorMessage.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Account created successfully.");
                        }
                        break;

                    case "2":
                        Console.Write("Enter your username: ");
                        string loginUsername = Console.ReadLine();
                        Console.Write("Enter your password: ");
                        string loginPassword = Console.ReadLine();

                        BankAccount loggedIn = new BankAccount();
                        if (loggedIn.CheckCredentials(loginUsername, loginPassword))
                        {
                            UserLoggedIn();
                        }
                        else
                        {
                            Console.WriteLine("Your credentials are wrong, try again!");
                        }
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
        }

        public static void UserLoggedIn()
        {
            bool loggedIn = true;

            while (loggedIn)
            {
                Console.Clear();
                Console.WriteLine(@"Welcome to your account """);
                Console.WriteLine("1. Make a deposit.");
                Console.WriteLine("2. Transfer money.");
                Console.WriteLine("");
                Console.Write("Pick an option: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("");
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
