namespace EmployeeWeeklyPay

{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            var frank = new HourlyEmployee();       //Instances of HourlyEmployee Class
            frank.Name = "Frank";                   //Properties of HourlyEmployee Class
            frank.HourlyRate = 27.50;
            frank.HoursWorked = 40;
            frank.StartWeek = DateTime.Today;
            frank.EndWeek = DateTime.Today.AddDays(7);
            

            var bill = new HourlyEmployee();
            bill.Name = "Bill";
            bill.HourlyRate = 16.00;
            bill.HoursWorked = 32;
            bill.StartWeek = DateTime.Today;
            bill.EndWeek = DateTime.Today.AddDays(7);

            var nancy = new HourlyEmployee();
            nancy.Name = "Nancy";
            nancy.HourlyRate = 31.00;
            nancy.HoursWorked = 32;
            nancy.StartWeek = DateTime.Today;
            nancy.EndWeek = DateTime.Today.AddDays(7);


            var jeff = new SalaryEmployee();        //Instances of SalaryEmployee Class
            jeff.Name = "Jeff";                     //Properites of SalaryEmployee Class
            jeff.YearlySalary = 45000;
            jeff.WeeksWorked = 52;
            jeff.StartWeek = DateTime.Today;
            jeff.EndWeek = DateTime.Today.AddDays(7);

            var alex = new SalaryEmployee();
            alex.Name = "Alex";
            alex.YearlySalary = 23500;
            alex.WeeksWorked = 50;
            alex.StartWeek = DateTime.Today;
            alex.EndWeek = DateTime.Today.AddDays(7);

            var mindy = new SalaryEmployee();
            mindy.Name = "Mindy";
            mindy.YearlySalary = 51000;
            mindy.WeeksWorked = 52;
            mindy.StartWeek = DateTime.Today;
            mindy.EndWeek = DateTime.Today.AddDays(7);

            var employees = new List<Employee>();       //Instance of List of employees
            employees.Add(frank);
            employees.Add(bill);
            employees.Add(nancy);
            employees.Add(jeff);
            employees.Add(alex);
            employees.Add(mindy);

            static void PayEmployee(List<Employee> employees)
            {
                foreach (var item in employees)
                {
                    item.PayEmployee();
                    Console.WriteLine();
                }
            }

            PayEmployee(employees);




        }



    }



}
