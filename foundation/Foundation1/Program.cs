using System;

class Program
{
    static void Main(string[] args)
    {
        Comments comments1 = new Comments();
        comments1._name = "Jordan";
        comments1._commentText = "Wonderful video!";

        Comments comments2 = new Comments();
        comments2._name = "Ashley";
        comments2._commentText = "Great watch!";

        Comments comments3 = new Comments();
        comments3._name = "Hazel";
        comments3._commentText = "A must see.";

        Comments comments4 = new Comments();
        comments4._name = "Brian";
        comments4._commentText = "Would watch again.";

        Comments comments5 = new Comments();
        comments5._name = "Killian";
        comments5._commentText = "Favorite video.";

        Comments comments6 = new Comments();
        comments6._name = "Mary";
        comments6._commentText = "Enjoyed every second.";

        Comments comments7 = new Comments();
        comments7._name = "Raul";
        comments7._commentText = "They are amazing!";

        Comments comments8 = new Comments();
        comments8._name = "James";
        comments8._commentText = "Learned many new things.";

        Comments comments9 = new Comments();
        comments9._name = "Alice";
        comments9._commentText = "Laughed the entire time.";

        Comments comments10 = new Comments();
        comments10._name = "Roger";
        comments10._commentText = "First comment.";

        Comments comments11 = new Comments();
        comments11._name = "Tyler";
        comments11._commentText = "Loved that part.";

        Comments comments12 = new Comments();
        comments12._name = "Pricilla";
        comments12._commentText = "Found it thoroughly enjoyable.";

        Comments comments13 = new Comments();
        comments13._name = "Logan";
        comments13._commentText = "Very informative.";

        Comments comments14 = new Comments();
        comments14._name = "Samuel";
        comments14._commentText = "Learned what not to do!";

        Comments comments15 = new Comments();
        comments15._name = "Oliver";
        comments15._commentText = "Made it look easy.";

        Comments comments16 = new Comments();
        comments16._name = "Anna";
        comments16._commentText = "Going to do this in the future.";

        Video video1 = new Video();
        video1._author = "Jason";
        video1._lengthOfVideo = 300;
        video1._title = "Magical Butterflies";

        Video video2 = new Video();
        video2._author = "Ronald";
        video2._lengthOfVideo = 1500;
        video2._title = "Documentary of Sloths";

        Video video3 = new Video();
        video3._author = "Aria";
        video3._lengthOfVideo = 200;
        video3._title = "Funniest dogs around";

        Video video4 = new Video();
        video4._author = "Kevin";
        video4._lengthOfVideo = 12439;
        video4._title = "How to fix a car";

        video1._comment.Add(comments1);
        video1._comment.Add(comments2);
        video1._comment.Add(comments3);
        video1._comment.Add(comments4);

        video2._comment.Add(comments5);
        video2._comment.Add(comments6);
        video2._comment.Add(comments7);
        video2._comment.Add(comments8);

        video3._comment.Add(comments9);
        video3._comment.Add(comments10);
        video3._comment.Add(comments11);
        video3._comment.Add(comments12);

        video4._comment.Add(comments13);
        video4._comment.Add(comments14);
        video4._comment.Add(comments15);
        video4._comment.Add(comments16);

        video1.DisplayInformation();
        video2.DisplayInformation();
        video3.DisplayInformation();
        video4.DisplayInformation();
    }
}