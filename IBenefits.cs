using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWeeklyPay
{
    internal interface IBenefits
    {
        public string VacationTime { get; set; }

        public string VacationEarned();

    }



}
