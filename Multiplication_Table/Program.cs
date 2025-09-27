using System;

class MultiplicationTable
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nMultiplication Table for {num}:\n");

        for (int i = 1; i <= 10; i++)
        {
            int result = num * i;
            Console.WriteLine($"{num} x {i} = {result}");
        }
    }
}

