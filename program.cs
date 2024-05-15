using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        
        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        double sum = number1 + number2;
        Console.WriteLine("The sum of {0} and {1} is: {2}", number1, number2, sum);
        Console.ReadKey();
    }
}
