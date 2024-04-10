namespace ClassLibrary1;

public class Programmer : Employee
{
    private int WorkHours;
    private double HourlyRate;

    public Programmer(string name, double baseSalary, int workHours, double hourlyRate) : base(name, baseSalary)
    {
        WorkHours = workHours;
        HourlyRate = hourlyRate;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + (WorkHours * HourlyRate);
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Programmer: {Name}, Base Salary: {BaseSalary}, Work Hours: {WorkHours}, Hourly Rate: {HourlyRate}, Total Salary: {CalculateSalary()}");
    }
}
