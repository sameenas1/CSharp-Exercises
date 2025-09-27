using System;                     
using System.Collections.Generic;

class StudentFinder
{
    static void Main(string[] args)
    {
        Dictionary<int, string> students = new Dictionary<int, string>();
        students.Add(1, "Rajesh");
        students.Add(2, "Rahul");
        students.Add(3, "Sruthi");

        Console.Write("Please enter a student ID: ");

        string userInput = Console.ReadLine();
        int inputId = Convert.ToInt32(userInput);

        if (students.ContainsKey(inputId))
        {
            string studentName = students[inputId];
            Console.WriteLine("Student name is: " + studentName);
        }
        else
        {
            Console.WriteLine("Sorry, student not found.");
        }
    }
}


