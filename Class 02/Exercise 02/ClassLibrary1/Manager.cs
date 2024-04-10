namespace ClassLibrary1;

public class Manager : Employee
{
    private double Bonus;

    public Manager(string name, double baseSalary, double bonus) : base(name, baseSalary)
    {
        Bonus = bonus;
    }

    public override double CalculateSalary()
    {
        return BaseSalary + Bonus;
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Manager: {Name}, Base Salary: {BaseSalary}, Bonus: {Bonus}, Total Salary: {CalculateSalary()}");
    }
}
