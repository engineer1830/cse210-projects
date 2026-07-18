using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Falling Down", "JimmyG", 33);
        Video video2 = new Video("Cajun Cookin", "Justin Wilson", 231);
        Video video3 = new Video("Drone Launches", "Drone Master Z", 111);
        Video video4 = new Video("Cool Coding", "The Coder", 443);


        video1.AddComment(new Comment("Joe", "Funny video!"));
        video1.AddComment(new Comment("Bob", "Still laughing"));
        video1.AddComment(new Comment("Charlie", "Do more like this!"));

        video2.AddComment(new Comment("Derek", "I love Cajun food."));
        video2.AddComment(new Comment("Eva", "I enjoy the stories . . . share more"));
        video2.AddComment(new Comment("Frank", "I need hush puppies!"));
        video2.AddComment(new Comment("Ben", "I want to go to Louisiana now!"));

        video3.AddComment(new Comment("Gina", "Great videos that show what a drone can do."));
        video3.AddComment(new Comment("Henry", "Don't be a jerk drone pilot and annoy people."));
        video3.AddComment(new Comment("Jim", "I am getting a drone next week.  This is helpful."));

        video4.AddComment(new Comment("Grandpa Bob", "At my age, I never thought I'd be able to learn this."));
        video4.AddComment(new Comment("Slippy", "Great explanations . . . the syntax always trips me up!"));
        video4.AddComment(new Comment("Ginx", "I am getting more confident because of your videos!"));

        List<Video> videos = new List<Video>() { video1, video2, video3, video4 };

        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}