using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    internal class SalaryEmployee : Employee        //Derived : Base
    {

        public double YearlySalary { get; set; }        //Property
        public double WeeksWorked { get; set; }

        public override void PayEmployee()      //Implemented inheriated (From Base) abstract method
        {
            var weeklySalary = YearlySalary / 52;
            var paymentAmount = weeklySalary * WeeksWorked;
            Console.WriteLine($"{Name} is owed {paymentAmount.ToString("C0")}");
        }
    }




}
