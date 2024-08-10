namespace EmployeeData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
             
            var frank = new HourlyEmployee();       //Instances of HourlyEmployee Class
            frank.Name = "Frank";                   //Properties of HourlyEmployee Class
            frank.HourlyRate = 27.50;
            frank.HoursWorked = 40;

            var bill = new HourlyEmployee();
            bill.Name = "Bill";
            bill.HourlyRate = 16.00;
            bill.HoursWorked = 32;

            var nancy = new HourlyEmployee();
            nancy.Name = "Nancy";
            nancy.HourlyRate = 31.00;
            nancy.HoursWorked = 32;


            var jeff = new SalaryEmployee();        //Instances of SalaryEmployee Class
            jeff.Name = "Jeff";                     //Properites of SalaryEmployee Class
            jeff.YearlySalary = 45000;
            jeff.WeeksWorked = 52;

            var alex = new SalaryEmployee();
            alex.Name = "Alex";
            alex.YearlySalary = 23500;
            alex.WeeksWorked = 50;

            var mindy = new SalaryEmployee();
            mindy.Name = "Mindy";
            mindy.YearlySalary = 51000;
            mindy.WeeksWorked = 52;

            var employees = new List<Employee>();       //Instance of List of employees
            employees.Add(frank);
            employees.Add(bill);
            employees.Add(nancy);
            employees.Add(jeff);
            employees.Add(alex);
            employees.Add(mindy);

            static void PayEmployee(List<Employee> employees)
            {
                foreach (var employee in employees)
                {
                    employee.PayEmployee();
                }
            }

            PayEmployee(employees);




        }



    }



}
