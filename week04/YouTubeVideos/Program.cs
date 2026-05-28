using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");


        Video video = new Video("Learning C#", "John Davis", 300);

        Comment c1 = new Comment("Mary", "It's a nice video! I learned a lot.");
        Comment c2 = new Comment("David S" , "Great explanation! Thanks for sharing.");
        Comment c3 = new Comment("Sarah", "Very helpful tutorial. Keep up the good work!");
        
        video.AddComment(c1);
        video.AddComment(c2);
        video.AddComment(c3);
        video.DisplayVideoINFo();
    }
}