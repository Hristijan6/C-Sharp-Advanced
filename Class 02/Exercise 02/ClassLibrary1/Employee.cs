namespace ClassLibrary1;

public abstract class Employee
{
    public string Name;
    public double BaseSalary;

    public Employee(string name, double baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public abstract double CalculateSalary();

    public abstract void DisplayInfo();
}

