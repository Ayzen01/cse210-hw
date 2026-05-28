using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        // Lista de vídeos
        List<Video> videosList = new List<Video>();

    
        


        Video video = new Video("Learning C#", "John Davis", 300);

        Comment c1 = new Comment("Mary", "It's a nice video! I learned a lot.");
        Comment c2 = new Comment("David S" , "Great explanation! Thanks for sharing.");
        Comment c3 = new Comment("Sarah", "Very helpful tutorial. Keep up the good work!");
        
        

        Video video2 = new Video("How to Configure VS Code", "TechTips", 450);
        video2.AddComment(new Comment("Mariana Costa", "I was stuck at this part, thanks."));
        video2.AddComment(new Comment("Diego Oliveira", "Short and precise video. Awesome!"));
        video2.AddComment(new Comment("Julia Reis", "You forgot to explain the C# extension, but I got it."));
        videosList.Add(video2);

    // 4. Creating Video 3 and adding its comments
         Video video3 = new Video("What is Encapsulation? - OOP", "Prof. Alan", 900);
        video3.AddComment(new Comment("Lucas Pinheiro", "That capsule analogy was amazing."));
        video3.AddComment(new Comment("Fernanda Santos", "I finally understood the difference between private and public."));
        video3.AddComment(new Comment("Gabriel M.", "Great content!"));
        videosList.Add(video3);


        video.AddComment(c1);
        video.AddComment(c2);
        video.AddComment(c3);
        video.DisplayVideoInfo();


    // Reporting videos
        Console.WriteLine("====== YOUTUBE VIDEOS REPORT ======\n");
        foreach (Video v in videosList)
        {
            v.DisplayVideoInfo();
            Console.WriteLine("------------------------------------------");
        }
    }
}
