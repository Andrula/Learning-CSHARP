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
            Employee employeeOne = new Employee();
            employeeOne.firstName = "Bethany";
            employeeOne.lastName = "Adams";
            employeeOne.email = "Bethany@adams.com";
            employeeOne.DoWork(13);
            employeeOne.CalculateSalary(13);


            Console.ReadLine();

        }
    }
}
