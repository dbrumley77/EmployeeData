using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    internal class SalaryEmployee : Employee       //Derived : Base
    {

        public double YearlySalary { get; set; }        //Property
        public double WeeksWorked { get; set; }

        public override void PayEmployee()      //Implemented inheriated abstract method from base
        {
            var weeklySalary = YearlySalary / 52;
            
            Console.WriteLine($"{Name} is to be owed {weeklySalary.ToString("C0")} for work performed starting" +
                $" {StartWeek} till {EndWeek}");
        }


    }




}
