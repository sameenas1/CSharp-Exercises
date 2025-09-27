using System;

class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator(); 

        Console.Write("Enter first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Choose operation (+, -, *, /): ");
        string op = Console.ReadLine();

        int result = 0;

        switch (op)
        {
            case "+":
                result = calc.Add(num1, num2);
                break;
            case "-":
                result = calc.Subtract(num1, num2);
                break;
            case "*":
                result = calc.Multiply(num1, num2);
                break;
            case "/":
                result = calc.Divide(num1, num2);
                break;
            default:
                Console.WriteLine("Invalid operation.");
                return;
        }

        Console.WriteLine("Result: " + result);
    }
}
