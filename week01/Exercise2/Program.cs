using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is the Exercise2 Project.");
            Console.Write("Enter your grade percentage (0-100): ");
            string input = Console.ReadLine();
            double gradePercentage = double.Parse(input);

            string letterGrade = "";
            string sign = "";

            if (gradePercentage >= 90)
            {
                letterGrade = "A";
            }
            else if (gradePercentage >= 80)
            {
            letterGrade = "B";
            }
            else if (gradePercentage >= 70)
            {
            letterGrade = "C";
            }
            else if (gradePercentage >= 60)
            {
            letterGrade = "D";
            }
            else
            {
            letterGrade = "F";
            }

            if (letterGrade == "F" )
               {
                sign = ""; // F has no sign
                }
            else if (letterGrade == "A" )
                {
                   int remainder = (int) (gradePercentage % 10);
                   if (remainder < 3)
                {
                    sign = "-";
                }
                else
                {
                    sign ="";
                }
                }
            else
            { 
                int remainder = (int) (gradePercentage % 10);
                if (remainder >= 7)
                {
                    sign = "+";
                }
                else if (remainder < 3)
                {
                    sign = "-";
                }
                else
                {
                    sign = "";
                 }
            }

            Console.WriteLine($"Your grade is: {letterGrade}{sign}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("You have passed the course.");
            }
            else
            {
            Console.WriteLine("Sorry, you have not passed the course try again next time.");
            }
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();

        }
   }
}