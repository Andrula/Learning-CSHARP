using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Mikkel = new Employee("Mikkel","Jensen","Mikkel@politi.dk",new DateTime (1998,07,31),104.4);
            Mikkel.DisplayEmployeeDetails();

            Mikkel.PerformWork();
            Mikkel.PerformWork();
            Mikkel.PerformWork(7);
            Mikkel.PerformWork();

            Mikkel.ReceiveWage(true);

            Mikkel.CalculateMonthlySalary(10, 104.4);

            int monthsWorked = 12;
            int salary = 1044;

            int result = Mikkel.CalculateYearlySalary(monthsWorked, salary);

            Console.WriteLine($"\nThe yearly salary for the employee is {result} DKK kr,-");
      
            Console.ReadLine();

        }
    }
}
