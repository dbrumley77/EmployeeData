using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    abstract class Employee     //Base Class
    {

        public string Name { get; set; }        //Property
        public DateTime StartWeek { get; set; }
        public DateTime EndWeek { get; set; }



        public abstract void PayEmployee();     //Abstract Method (Implementation in Derived Class)








    }




}
