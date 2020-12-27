namespace BridgeDesignPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            SalaryCalculator salaryCalculator = new SalaryCalculator(new XMLWriter());

            Employee employee = new Employee { Id = 1001, Name = "John Doe", Basic = 3000, Incentive = 2000 };
            salaryCalculator.ProcessEmployeeSalary(employee);

            employee.Incentive = 2500;
            salaryCalculator = new SalaryCalculator(new JSONWriter());
            salaryCalculator.ProcessEmployeeSalary(employee);

        }
    } 
}
