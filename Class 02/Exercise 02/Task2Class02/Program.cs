using ClassLibrary1;

namespace Task2Class02;
public class Program
{
    static void Main(string[] args)
    {
        Employee manager = new Manager("John Doe", 50000, 10000);
        manager.DisplayInfo();

        Employee programmer = new Programmer("Moak Koam", 40000, 160, 25);
        programmer.DisplayInfo();
    }
}

