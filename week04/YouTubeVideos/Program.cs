using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Video video1 = new Video("Serve the Lord"," Kenedi Anderson",0,3,45);
        video1.comentList(new Comment("Jackson","we all need tto Jesus."));
        video1.comentList(new Comment("Richard", "I search for him."));

        Video video2 = new Video("Small Things", "Leah Campbell", 0,3,38);
        video2.comentList(new Comment("Kita", " By small and simple things are great things brought to pass."));
        video2.comentList(new Comment("Joy", "Love this song."));
        video2.comentList(new Comment("Andre", "That's what leads to Great things."));

        Video video3 = new Video("I can do all Things", "Jarica Jamison", 0,3,45);
        video3.comentList(new Comment("Joanna", "This song gives me strength in my Savior Jesus Christ."));
        video3.comentList(new Comment("David", "I have listened to it about 100 times now."));
        video3.comentList(new Comment("Me", "For with God, nothing shall be impossible."));
        video3.comentList(new Comment("Coral", "I can do all things through Christ."));

        Video video4 = new Video("Saints and Soldiers Airborne Creed","Ryan Litle",1,12,39);
        video4.comentList(new Comment("Carlos","Good movie."));

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.GetDisplayText();
        
        }

        
    }
}