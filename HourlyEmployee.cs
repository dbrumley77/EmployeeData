using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    internal class HourlyEmployee : Employee        //Derived : Base
    {
        public double HourlyRate { get; set; }      //Property    
        public double HoursWorked { get; set; }

        public override void PayEmployee()      //Implemented inheriated abstract method from base
        {
            var paymentAmount = HourlyRate * HoursWorked;
            Console.WriteLine($"{Name} is owed {paymentAmount.ToString("C0")} for the week starting date of {StartWeek} and ending {EndWeek}");
        }
    }



}
