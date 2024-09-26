using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    internal class HourlyEmployee : Employee        //Derived : Base (Abstract Class)
    {
        public double HourlyRate { get; set; }      //Property    
        public double HoursWorked { get; set; }

        public override void PayEmployee()      //Implemented Inheriated Abstract Methods from Base Class
        {
            var paymentAmount = HourlyRate * HoursWorked;
            Console.WriteLine($"{Name} earned a gross pay of {paymentAmount.ToString("C")} for the week " +
                $"starting date of {StartWeek} and ending {EndWeek}");
        }

        public override void TaxEmployee()
        {
            var grossPay = (HourlyRate * HoursWorked);
            var netPay = grossPay - (grossPay * TaxRate);
            Console.WriteLine($"{Name} will have a net pay of {netPay.ToString("C")} after 6% taxes are deducted from weekly gross pay");
        }

        public override string VacationEarned()
        {
            string output = $"Hourly Employee {Name} has been awarded 14 Days of Vacation";
            Console.WriteLine(output);
            return output;
        }

        public override string VacationUsed()
        {
            string output = $"Hourly Employee {Name} has used {VacayUsed} Days of Vacation this year"; 
            Console.WriteLine(output);
            return output;
        }
    }



}
