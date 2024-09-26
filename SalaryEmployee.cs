using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    internal class SalaryEmployee : Employee       //Derived : Base (Abstract Class)
    {

        public double YearlySalary { get; set; }        //Property
        public double WeeksWorked { get; set; }

        public override void PayEmployee()      //Implemented Inheriated Abstract Methods from Base Class
        {
            var weeklySalary = YearlySalary / 52;
            
            Console.WriteLine($"{Name} will have a gross pay of {weeklySalary.ToString("C")} for work performed starting" +
                $" {StartWeek} till {EndWeek}");
        }

        public override void TaxEmployee()
        {
            var grossPay = YearlySalary / 52;
            var netPay = grossPay - (grossPay * TaxRate);
            Console.WriteLine($"{Name} will have a net pay of {netPay.ToString("C")} after 6% taxes are deducted from weekly gross pay");
        }

        public override string VacationEarned()
        {
            string output = $"Salary Employee {Name} has been awarded 21 Days of Vacation";
            Console.WriteLine(output);
            return output;
        }

        public override string VacationUsed()
        {
            string output = $"Salary Employee {Name} has used {VacayUsed} Days of Vacation this year";
            Console.WriteLine(output);
            return output;
        }
    }
}





