class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        this.username = username;
        uploadedVideos = new List<SayaTubeVideo>();
        Random rand = new Random();
        int minRand = 100000;
        int maxRand = 999999;
        this.id = rand.Next(minRand, maxRand + 1);
    }

    public int GetTotalVideoPlayCount()
    {
        return uploadedVideos.Count;
    }

    public void AddVideo(SayaTubeVideo uploadedVideos)
    {
        this.uploadedVideos.Add(uploadedVideos);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine($"User            : {username}");
        for (int i = 0; i <= uploadedVideos.Count; i++)
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
    }

    public void IncreasePlayCount(int playCount)
    {
        this.playCount += playCount;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"id              : {id}");
        Console.WriteLine($"judul           : {title}");
        Console.WriteLine($"jumlah tayang   : {playCount}");
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
        SayaTubeVideo sayaTubeVideo2 = new SayaTubeVideo($"Review Film {film2} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo3 = new SayaTubeVideo($"Review Film {film3} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo4 = new SayaTubeVideo($"Review Film {film4} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo5 = new SayaTubeVideo($"Review Film {film5} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo6 = new SayaTubeVideo($"Review Film {film6} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo7 = new SayaTubeVideo($"Review Film {film7} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo8 = new SayaTubeVideo($"Review Film {film8} oleh {sayaTubeUser.getUsername()}");
        SayaTubeVideo sayaTubeVideo9 = new SayaTubeVideo($"Review Film {film9} oleh {sayaTubeUser.getUsername()}");

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