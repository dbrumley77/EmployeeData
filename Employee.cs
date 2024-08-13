using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    abstract class Employee : ITaxable, IBenefits  //Base Class : Interface
    {

        public string? Name { get; set; }        //Property
        public DateTime StartWeek { get; set; }
        public DateTime EndWeek { get; set; }
        public double TaxRate { get; set; }
        public int NetPay { get; set;  }
        public string VacationTime { get; set; } 

        public abstract void PayEmployee();     //Abstract Method (Implementation in Derived Classes)

        public abstract void TaxEmployee();

        public abstract string VacationEarned();
        
    }




}
