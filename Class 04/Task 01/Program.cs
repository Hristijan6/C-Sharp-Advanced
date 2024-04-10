using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintInConsole printer = new PrintInConsole();
            printer.Print("Hello, world!");

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            printer.PrintCollection(numbers);
        }
    }
}
