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

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private  List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }



//add the comment

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
        {
          return _comments.Count;
       }

    public void DisplayVideoInfo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Comment Count: {GetCommentCount()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in _comments)
           {
            comment.Displaycomment();
            }    
        }
}
