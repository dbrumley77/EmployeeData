namespace EmployeeWeeklyPay

{
    internal class Program
    {
        static void Main(string[] args)
        {


            var frank = new HourlyEmployee();       //Instances of HourlyEmployee Class
            frank.Name = "Frank";                   //Instance.Properties = Value 
            frank.HourlyRate = 22.50;
            frank.HoursWorked = 40;
            frank.StartWeek = DateTime.Today;
            frank.EndWeek = DateTime.Today.AddDays(7);
            frank.TaxRate = 0.06;
            frank.VacationTime = "";

            var bill = new HourlyEmployee();
            bill.Name = "Bill";
            bill.HourlyRate = 16.00;
            bill.HoursWorked = 32;
            bill.StartWeek = DateTime.Today;
            bill.EndWeek = DateTime.Today.AddDays(7);
            bill.TaxRate = 0.06;
            bill.VacationTime = "";

            var nancy = new HourlyEmployee();
            nancy.Name = "Nancy";
            nancy.HourlyRate = 31.00;
            nancy.HoursWorked = 32;
            nancy.StartWeek = DateTime.Today;
            nancy.EndWeek = DateTime.Today.AddDays(7);
            nancy.TaxRate = 0.06;
            nancy.VacationTime = "";


            var jeff = new SalaryEmployee();        //Instances of SalaryEmployee Class
            jeff.Name = "Jeff";                     //Instance.Properites = Value
            jeff.YearlySalary = 45000;
            jeff.WeeksWorked = 52;
            jeff.StartWeek = DateTime.Today;
            jeff.EndWeek = DateTime.Today.AddDays(7);
            jeff.TaxRate = 0.06;
            jeff.VacationTime = "";

            var alex = new SalaryEmployee();
            alex.Name = "Alex";
            alex.YearlySalary = 23500;
            alex.WeeksWorked = 50;
            alex.StartWeek = DateTime.Today;
            alex.EndWeek = DateTime.Today.AddDays(7);
            alex.TaxRate = 0.06;
            alex.VacationTime = "";

            var mindy = new SalaryEmployee();
            mindy.Name = "Mindy";
            mindy.YearlySalary = 51000;
            mindy.WeeksWorked = 52;
            mindy.StartWeek = DateTime.Today;
            mindy.EndWeek = DateTime.Today.AddDays(7);
            mindy.TaxRate = 0.06;
            mindy.VacationTime = "";

            var employees = new List<Employee>();       //Instance of List of Employees
            employees.Add(frank);                       //Added Instances to List of Employees
            employees.Add(bill);
            employees.Add(nancy);
            employees.Add(jeff);
            employees.Add(alex);
            employees.Add(mindy);


            static void PayEmployee(List<Employee> employees)       //Methods Results to Print Info to Console
            {                                                       
                foreach (var item in employees)
                {
                    item.PayEmployee();
                    item.TaxEmployee();
                    item.VacationEarned();
                    Console.WriteLine();
                }
            }

            PayEmployee(employees);     //Method Call




        }



    }



}
