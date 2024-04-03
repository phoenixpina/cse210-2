abstract class Employee
{
    public string name;
    public Employee(string name)
    {
        this.name = name;
    }
    public abstract decimal CalculatePay(); 

}

class SalaryEmployee : Employee
{
    protected decimal annualSalary;

    public SalaryEmployee(string name, double annualSalary) : base(name)
    {
        this.annualSalary = (decimal) annualSalary;
    }
    public override decimal CalculatePay()
    {
        return annualSalary / 26 //bi-weekly pay
    }
}

class HourlyEmployee : Employee
{
    protected decimal hourlyRate;
    protected int hoursWorked;
    public HourlyEmployee(string name, double hourlyRate, int hoursWorked) : base(name)
    {
        this.hourlyRate = (decimal) hourlyRate;
        this.hoursWorked = hoursWorked;
    }
    public ovveride decimal CalculatePay()
    {
        return (hourlyRate * hoursWorked) * 2; //bi-weekly pay
    }
}

SalaryEmployee salaryEmployee = new SalaryEmployee("Dan", 96000.13);
HourlyEmployee hourlyEmployee = new HourlyEmployee("Phil", 13.50, 40);

Console.WriteLine($"{salaryEmployee.name} males ${salaryEmployee.CalculatePay():2N} bi-weekly.");
Console.WriteLine($"{hourlyEmployee.name} males ${hourlyEmployee.CalculatePay():2N} bi-weekly.");