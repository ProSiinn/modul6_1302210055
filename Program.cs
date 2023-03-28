using System;

class SayaTubeUser
{
    private int id;
    private List<SayaTubeVideo> uploadedVideos;
    public string username;

    public SayaTubeUser(string username)
    {
        id = 0;
        uploadedVideos = new List<SayaTubeVideo>();
        this.username = username;
    }

    public int GetTotalVideoPlayCount()
    {
        int total = 0;
        foreach (SayaTubeVideo video in uploadedVideos)
        {
            total += video.getPlayCount();
        }
        return total;
    }

    public void AddVideo(SayaTubeVideo video)
    {
        uploadedVideos.Add(video);
    }

    public void PrintAllVideoPlayCount()
    {
        Console.WriteLine("User : ", this.username);
        for (int i = 0; i < uploadedVideos.Count; i++)
        {
            Console.WriteLine("Video " + (i + 1) + " Judul " + uploadedVideos[i].getTile());
        }
    }
}

class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public int getPlayCount()
    {
        return this.playCount;
    }

    public string getTile()
    {
        return this.title;
    }

    public SayaTubeVideo(string tit)
    {
        Random random = new Random();
        title = tit;
        this.id = random.Next(10000, 99999);
        playCount = 0;

    }

    public void IncreasePlayCount(int count)
    {
        this.playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("Video ID : {0}", this.id);
        Console.WriteLine("Title : {0}", this.title);
        Console.WriteLine("Play Count : {0}", this.playCount);
    }
}

class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Class SayaTubeVideo");
        string judul = "Tutorial Design By Contract - Muhammad Yaasin Rafi";
        SayaTubeVideo video = null;
        video = new SayaTubeVideo(judul);
        video.IncreasePlayCount(1);
        video.PrintVideoDetails();

        SayaTubeUser bebas = new SayaTubeUser("Rafi");
        SayaTubeVideo myr;
        myr = new SayaTubeVideo("Raden Kian Santang");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Cars");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Cars 2");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Cars 3");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Naruto");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Titanic");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Upin Ipin");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Spongebob");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Avatar");
        bebas.AddVideo(myr);
        myr = new SayaTubeVideo("Fast & Furious");
        bebas.AddVideo(myr);


        bebas.PrintAllVideoPlayCount();
    }
}






