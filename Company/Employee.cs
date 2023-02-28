using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Company
{
    public class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }   
        public string email { get; set; }   
        public int hoursWorked { get; set; }
        public DateTime birthday { get; set; }  

        public void DoWork()
        {
            hoursWorked++;
            Console.WriteLine($"{firstName} {lastName} has worked {hoursWorked} hours this month.");
        }

        public void DoWork(int numbersOfHoursWorked)
        {
            hoursWorked += numbersOfHoursWorked;
            Console.WriteLine($"{firstName} {lastName} has worked {hoursWorked} hour(s).");
        }

        public void CalculateSalary (int numbersOfHoursWorked, int hourlySalary = 160)
        {
            double monthlySalary = (numbersOfHoursWorked * hourlySalary);
            Console.WriteLine($"{firstName}'s salary this month is {monthlySalary} because she worked {numbersOfHoursWorked}");
        }

        public void Bonus(int numbersOfHoursWorked,int monthlySalary,int bonus = 500)
        {
            if (numbersOfHoursWorked > 10)
            {
                int addedBonus = (monthlySalary + bonus);
                Console.WriteLine($"Because {firstName} worked more than 10 hours, she gets a bonus of {bonus}");
            }
        }
    }
}
