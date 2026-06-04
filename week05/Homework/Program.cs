using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello World! This is the Homework Project.");
        
        MathAssignment math = new MathAssignment("John", "Fraction", "section 7.3", "Problemas 8-12");
        WritingAssignment writing = new WritingAssignment("Jane", "History", "The Hunter");
        
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetMathInfo());
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInfo());
        
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    }

}