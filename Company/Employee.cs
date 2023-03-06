using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Company
{
    public class Employee
    {
        /*Employee details*/
        public string firstName { get; set; }
        public string lastName { get; set; }   
        public string email { get; set; }
        public DateTime birthDay { get; set; }

        /*Employee Financial Details*/
        public double wage;
        public double hourlyRate;
        public int hoursWorked;

        const int minimalWork = 1;

        public Employee(string fn, string ln, string em, DateTime bd, double rate)
        {
            firstName = fn;
            lastName = ln;
            email = em;
            birthDay = bd;
            hourlyRate = rate;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("         Employee Details");
            Console.WriteLine($"\nFirst name: \t{firstName}\nLast name: \t{lastName}\nEmail: \t\t{email}\nBirthday: \t{birthDay.ToShortDateString()}\nHourly rate: \t{hourlyRate}");
            Console.WriteLine("----------------------------------\n");
        }

        public void PerformWork()
        {
            PerformWork(minimalWork);
        }

        public void PerformWork(int numberOfHours)
        {
            hoursWorked += numberOfHours;

            Console.WriteLine($"{firstName} {lastName} has worked for {numberOfHours} hour(s)!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            wage = hoursWorked * hourlyRate;

            Console.WriteLine($"\n{firstName} {lastName} has received a wage of {wage} for {hoursWorked} hour(s) of work.");

            if (resetHours)
                hoursWorked = 0;

            return wage;
        }

        /*Methods for calculation monthly and yearly salary*/
        public void CalculateMonthlySalary (int numbersOfHoursWorked, double hourlySalary)
        {
            double monthlySalary = (numbersOfHoursWorked * hourlySalary);
            Console.WriteLine($"\n{firstName}'s salary this month is {monthlySalary} DKK kr,- because he/she worked {numbersOfHoursWorked}");
        }

        public int CalculateYearlySalary (int numbersOfMonthsWorked, int monthlyWage)
        {
            if (numbersOfMonthsWorked == 12)
            {
                return monthlyWage * (numbersOfMonthsWorked + 1);
            }
            else
            return monthlyWage * numbersOfMonthsWorked; 
        }
    }
}
