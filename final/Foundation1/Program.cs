using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // create 3-4 videos and add comments to them
        Video video1 = new Video("Title 1", "Author 1", 120);
        video1.AddComment("Commenter 1", "This is the first comment.");
        video1.AddComment("Commenter 2", "This is the second comment.");
        videos.Add(video1);

        Video video2 = new Video("Title 2", "Author 2", 180);
        video2.AddComment("Commenter 1", "This is the first comment.");
        video2.AddComment("Commenter 3", "This is the third comment.");
        video2.AddComment("Commenter 4", "This is the fourth comment.");
        videos.Add(video2);

        Video video3 = new Video("Title 3", "Author 3", 300);
        video3.AddComment("Commenter 1", "This is the first comment.");
        video3.AddComment("Commenter 2", "This is the second comment.");
        video3.AddComment("Commenter 3", "This is the third comment.");
        video3.AddComment("Commenter 4", "This is the fourth comment.");
        videos.Add(video3);

        // iterate through the list of videos and display information about each one
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video.Title);
            Console.WriteLine("Author: " + video.Author);
            Console.WriteLine("Length: " + video.Length + " seconds");
            Console.WriteLine("Number of comments: " + video.GetNumberOfComments());
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("- " + comment.Name + ": " + comment.Text);
            }
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}