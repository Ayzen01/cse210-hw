using System;



namespace FractionApp
{
    class  Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();
            Fraction f2 = new Fraction(6);
            Fraction f3 = new Fraction(6 , 7);

            Fraction testGetSet = new Fraction();
            testGetSet.SetTop(3);
            testGetSet.SetBotton(4);

            Console.WriteLine(" --- Test Getters and Setters ---");
            Console.WriteLine($"Top modified: {testGetSet.GetTop()}");
            Console.WriteLine($"Bottom modified: {testGetSet.GetBotton()}");
            Console.WriteLine();


            Console.WriteLine("---Sample Output(Sample Output) ---");

            Fraction case1 = new Fraction();
            Console.WriteLine(case1.GetFractionString());
            Console.WriteLine(case1.GetDecimalValue());

            Fraction case2 = new Fraction(5);
            Console.WriteLine(case2.GetFractionString());
            Console.WriteLine(case2.GetDecimalValue());

            Fraction case3 = new Fraction(3, 4);
            Console.WriteLine(case3.GetFractionString());
            Console.WriteLine(case3.GetDecimalValue());

            Fraction case4 = new Fraction(1, 3);
            Console.WriteLine(case4.GetFractionString());
            Console.WriteLine(case4.GetDecimalValue());


    
        }
    }
}

