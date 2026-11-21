using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine("");

        List<Video> videos = new List<Video>();

        Video video1 = new Video();
        video1._title = "Compilation of Cute Dogs";
        video1._author = "DogLover78!";
        video1._seconds = 985;
        video1._comments.Add(new Comment("SamuelGoesFishing", "Loved this compilation, keep up the good work!"));
        video1._comments.Add(new Comment("Tabanfin", "Loved the dog at 2:16"));
        video1._comments.Add(new Comment("Ilovesocks", "Love!!!"));

        Video video2 = new Video();
        video2._title = "How to show acts of love, Podcast #56";
        video2._author = "Dane Johnson";
        video2._seconds = 10987;
        video2._comments.Add(new Comment("FliptheSausage", "Loved this podcast!"));
        video2._comments.Add(new Comment("Samuel Weber", "I always like buying gifts for the people I love or asking if they need anything at that moment"));
        video2._comments.Add(new Comment("tacocatpickle", "Love all that you do"));
        video2._comments.Add(new Comment("FlannelLover", ":D"));

        Video video3 = new Video();
        video3._title = "Short_of_the_Day_#1032";
        video3._author = "Hicupp Stophenson Stream Highlights";
        video3._seconds = 122;
        video3._comments.Add(new Comment("WatchesEverything", "Oh my goodness, I can't believe this happen on stream and I missed it!!!"));
        video3._comments.Add(new Comment("tiphanyShip", "LOL"));
        video3._comments.Add(new Comment("ahhhh2087", "What?!?!"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("");
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._seconds}");
            Console.WriteLine($"# of Comments: {video.CommentCount()}");
            foreach (Comment comment in video._comments)
            {
                Console.WriteLine($"{comment._name}: {comment._text}");
            }
        }
    }
}