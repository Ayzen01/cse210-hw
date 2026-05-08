using System;
// Exercise4 Project.
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers  = new List<int>();
        int userNumber = 1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber !=0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            
            userNumber = int.Parse(response);
            if (userNumber !=0)
            {
                numbers.Add(userNumber);
            }

        }

        int sum = numbers.Sum();
        double average = numbers.Average();
        int max = numbers.Max();

        int smallestPositive = numbers.Where(n => n > 0).Min();

        Console.WriteLine($"The sum of the numbers is: {sum}");
        Console.WriteLine($"The average of the numbers is: {average}");
        Console.WriteLine($"The maximum of the numbers is: {max}");
        Console.WriteLine($"The smallest of the numbers is: {smallestPositive}");
        

        numbers.Sort();
        Console.WriteLine("The numbers sorted list is :");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }


    }
}