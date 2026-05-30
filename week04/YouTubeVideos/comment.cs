using System;
using System.Collections.Generic;

class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        
        _name = name;
        _text = text;

    }
    // showing the comments
    public void Displaycomment()
    {
        Console.WriteLine($"{_name}: {_text}");
    }


}    
