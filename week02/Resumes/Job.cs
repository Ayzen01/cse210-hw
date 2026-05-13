using System;

public class Job
{
    public string _company { get; set; }
    public string _position { get; set; }
    public int _startYear { get; set; }

    public int _endYear { get; set; }

    public void Display()
    {
        Console.WriteLine($"{_position} at {_company} from {_startYear} to {_endYear}");
    }
}
