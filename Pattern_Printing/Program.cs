using System;

class TrianglePattern
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    }
}

