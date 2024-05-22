using System;

class Program
{
    static void Main()
    {
        int choice;
        double operand1, operand2;

        do
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice (1-5): ");

            // Read user's choice
            choice = Convert.ToInt32(Console.ReadLine());

            // Perform the selected operation based on user's choice
            switch (choice)
            {
                case 1:
                    Console.Write("Enter first operand: ");
                    operand1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second operand: ");
                    operand2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Result: " + (operand1 + operand2));
                    break;

                case 2:
                    Console.Write("Enter first operand: ");
                    operand1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second operand: ");
                    operand2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Result: " + (operand1 - operand2));
                    break;

                case 3:
                    Console.Write("Enter first operand: ");
                    operand1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second operand: ");
                    operand2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Result: " + (operand1 * operand2));
                    break;

                case 4:
                    Console.Write("Enter first operand: ");
                    operand1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Enter second operand: ");
                    operand2 = Convert.ToDouble(Console.ReadLine());

                    // Check for division by zero
                    if (operand2 != 0)
                    {
                        Console.WriteLine("Result: " + (operand1 / operand2));
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed!");
                    }
                    break;

                case 5:
                    Console.WriteLine("Exiting the program.");
                    break;

                default:
                    Console.WriteLine("Invalid choice! Please enter a valid choice (1-5).");
                    break;
            }

            Console.WriteLine();
        }
        while (choice != 5);
    }
}
