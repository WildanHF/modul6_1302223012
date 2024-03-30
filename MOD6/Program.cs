﻿using System.Diagnostics.Contracts;

class SayaTubeUser
﻿using System.Diagnostics.Contracts;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        int max = 100;
        Contract.Requires(username.Length <= max);
        this.username = username;
        uploadedVideos = new List<SayaTubeVideo>();
        Random rand = new Random();
        int minRand = 100000;
        int maxRand = 999999;
        this.id = rand.Next(minRand, maxRand + 1);
        Contract.Ensures(this.username.Length <= max);
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo uploadedVideos)
    {
        Contract.Requires(uploadedVideos != null);
        this.uploadedVideos.Add(uploadedVideos);
        Contract.Ensures(uploadedVideos != null);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User            : {username}");
        for (int i = 0; i <= uploadedVideos.Count; i++)
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine($"Video {i + 1}   : {uploadedVideos[i]}");
            }
    }
    public string getUsername()
    {
        return username;
    }
    public void setUsername(string username)
    {
        this.username = username;
    }
}
class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        this.title = title;
        Random rand = new Random();
        int minRand = 100000;
        int maxRand = 999999;
        this.id = rand.Next(minRand, maxRand + 1);
        this.playCount = 0;
        int max = 200;
        Contract.Requires(title.Length <= max && title != null);
        try
        {
            checked
            {
                if ((title == null))
                {
                    throw new ArgumentException("Judul tidak bisa kosong");
                }
                else if (title.Length > max)
                {
                    throw new ArgumentException("Judul tidak bisa melebihi 200 karakter");
                }
                this.title = title;
                Random rand = new Random();
                int minRand = 100000;
                int maxRand = 999999;
                this.id = rand.Next(minRand, maxRand + 1);
                this.playCount = 0;
            }
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error : {ex.Message}");
        }

        Contract.Ensures(this.title.Length <= max && title != null);
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
        if (this.title != null)
        {
            int max = 25000000;
            Contract.Requires(playCount <= max && playCount > 0 && playCount < int.MaxValue);
            try
            {
                checked
                {
                    if (this.playCount + playCount > max)
                    {
                        throw new OverflowException("Jumlah Play Count melebihi maximum value");
                    }
                    else if (playCount < 0)
                    {
                        throw new OverflowException("Jumlah Play Count tidak bisa negatif");
                    }
                    this.playCount += playCount;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            Contract.Ensures(this.playCount <= max && this.playCount > 0 && this.playCount < int.MaxValue);
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"id              : {id}");
        Console.WriteLine($"judul           : {title}");
        Console.WriteLine($"jumlah tayang   : {playCount}");
        if (this.title != null && this.playCount < 25000000 && this.playCount > 0)
        {
            Console.WriteLine($"id              : {id}");
            Console.WriteLine($"judul           : {title}");
            Console.WriteLine($"jumlah tayang   : {playCount}");
        }
    }

    public string getTitle()
    {
        return title;
    }
    public void setTitle(string title)
    {
        this.title = title;
    }
}
class program
{
    static void Main(string[] args)
    {
        SayaTubeUser sayaTubeUser = new SayaTubeUser("Wildan Hadi");
        string film0 = "film 1";
        string film1 = "film 2";
        string film2 = "film 3";
        string film3 = "film 4";
        string film4 = "film 5";
        string film5 = "film 6";
        string film6 = "film 7";
        string film7 = "film 8";
        string film8 = "film 9";
        string film9 = "film 10";

        SayaTubeVideo sayaTubeVideo = new SayaTubeVideo($"Review Film {film0} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo1 = new SayaTubeVideo($"Review Film {film1} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo1 = new SayaTubeVideo(null);
        SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo($"Review Film {film2} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo($"Review Film {film3} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo($"Review Film {film4} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo("oapihdposancaiucnbaspouanbcposaduhsapoduhadpoiusabciusacbasubcaucsbasucsabcbapoucbuwbiuabcasbcalkhcbalkbcsalkcbalkcbaliywgbclkahbcliysacblksahcbaslkicbalkcbaslkhcbaslkcbsalkcjbalkjcbsakjcabckjasbckchbawkcubsaucbasckubsaclkausbckjsabckjsacbkjsacbakjscbakjcbakjcbakjcbkjacbakjcbakjcbakjbcakjcbakjcbaskjcbaclkjblkjabcwlkablkjsabcalcbalkjcbalkcjsbc");
        SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo($"Review Film {film5} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo($"Review Film {film6} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo($"Review Film {film7} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo($"Review Film {film8} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo($"Review Film {film9} oleh {sayaTubeUser.getUsername()}");

        Random rand = new Random();
        int min = 1;
        int max = 25000000;
        sayaTubeVideo.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo1.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo2.IncreasePlayCount(30000000);
        sayaTubeVideo3.IncreasePlayCount(-1);
        sayaTubeVideo4.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo5.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo6.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo7.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo8.IncreasePlayCount(rand.Next(min, max + 1));
        sayaTubeVideo9.IncreasePlayCount(rand.Next(min, max + 1));

        sayaTubeVideo.PrintVideoDetails();
        sayaTubeVideo1.PrintVideoDetails();
        sayaTubeVideo2.PrintVideoDetails();
        sayaTubeVideo3.PrintVideoDetails();
        sayaTubeVideo4.PrintVideoDetails();
        sayaTubeVideo5.PrintVideoDetails();
        sayaTubeVideo6.PrintVideoDetails();
        sayaTubeVideo7.PrintVideoDetails();
        sayaTubeVideo8.PrintVideoDetails();
        sayaTubeVideo9.PrintVideoDetails();
    }
}