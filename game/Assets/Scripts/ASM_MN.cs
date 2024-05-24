using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;
using System.Threading;

public class ASM_MN : Singleton<ASM_MN>
{
    public List<Region> listRegion = new List<Region>();
    public List<PlayerI> listPlayer;
    ScoreKeeper scoreKeeper;

    private void Start()
    {
        createRegion();
        scoreKeeper = ScoreKeeper.Instance;
        listPlayer = new List<PlayerI>() {
            new PlayerI(1, "tony", 10, listRegion[0]),
            new PlayerI(2, "abc", 50, listRegion[1]),
            new PlayerI(3, "dwadaw", 100, listRegion[0]),
            new PlayerI(4, "tdawwaony", 200, listRegion[2]),
        };
    }

    public void createRegion()
    {
        listRegion.Add(new Region(0, "VN"));
        listRegion.Add(new Region(1, "VN1"));
        listRegion.Add(new Region(2, "VN2"));
        listRegion.Add(new Region(3, "JS"));
        listRegion.Add(new Region(4, "VS"));
    }

    public string calculate_rank(int score)
    {
        if (score < 100)
            return "Hạng đồng";
        else if (score < 500)
            return "Hạng Bạc";
        else if (score < 1000)
            return "Hạng Vàng";
        else if (score < int.MaxValue)
            return "Kim cương";
        else
            return null;
    }

    public void YC1()
    {
        Region region = listRegion.Find(x => x.ID == scoreKeeper.IDregion);
        PlayerI player = new PlayerI(scoreKeeper.ID, scoreKeeper.userName, scoreKeeper.score, region);
        listPlayer.Add(player);
    }
    public void YC2()
    {
        Debug.Log("YC 2: ");
        foreach (PlayerI p in listPlayer)
        {
            Debug.Log($"ID: {p.ID}, Name: {p.name}, Score: {p.score}, Region: {p.region.Name}, Rank: {calculate_rank(p.score)}");
        }
    }
    public void YC3()
    {
        Debug.Log("YC 3: ");
        List<PlayerI> yc3 = listPlayer.Where(p => p.score < scoreKeeper.score).ToList();
        foreach (PlayerI p in yc3)
        {
            Debug.Log($"ID: {p.ID}, Name: {p.name}, Score: {p.score}, Region: {p.region.Name}, Rank: {calculate_rank(p.score)}");
        }
    }
    public void YC4()
    {
        Debug.Log("YC 4: ");
        List<PlayerI> yc4 = listPlayer.Where(p => p.ID == scoreKeeper.ID).ToList();
        foreach (PlayerI p in yc4)
        {
            Debug.Log($"ID: {p.ID}, Name: {p.name}, Score: {p.score}, Region: {p.region.Name}, Rank: {calculate_rank(p.score)}");
        }
    }
    public void YC5()
    {
        Debug.Log("YC 5: ");
        List<PlayerI> yc5 = listPlayer.OrderByDescending(p => p.score).ToList();
        foreach (PlayerI p in yc5)
        {
            Debug.Log($"ID: {p.ID}, Name: {p.name}, Score: {p.score}, Region: {p.region.Name}, Rank: {calculate_rank(p.score)}");
        }
    }
    public void YC6()
    {
        Debug.Log("YC 6: ");
        List<PlayerI> yc6 = listPlayer.OrderBy(p => p.score).Take(5).ToList();
        foreach (PlayerI p in yc6)
        {
Debug.Log($"ID: {p.ID}, Name: {p.name}, Score: {p.score}, Region: {p.region.Name}, Rank: {calculate_rank(p.score)}");
        }
    }
    public void YC7()
    {
        Debug.Log("YC 7: ");
        Thread bxhThread = new Thread(CalculateAndSaveAverageScoreByRegion)
        {
            Name = "BXH"
        };

        bxhThread.Start();
        bxhThread.Join();
        Debug.Log("completed and saved to bxhRegion.txt.");
    }
    void CalculateAndSaveAverageScoreByRegion()
    {
        // var regionScores = listPlayer
        //      .GroupBy(p => p.region.ID)
        //      .Select(g => new
        //      {
        //          Region = g.Key,
        //          AverageScore = g.Average(p => p.score)
        //      })
        //      .OrderBy(r => r.Region);

        var regionScores = listPlayer
             .GroupBy(p => p.region.ID)
             .Select(g => new
             {
                 Region = g.Where(p => p.region.ID == g.Key).Select(g => g.region.Name).FirstOrDefault(),
                 AverageScore = g.Average(p => p.score)
             })
             .OrderBy(r => r.Region);

        using (StreamWriter writer = new StreamWriter("bxhRegion.txt"))
        {
            foreach (var regionScore in regionScores)
            {
                Debug.Log($"Region: {regionScore.Region}, Average Score: {regionScore.AverageScore:F2}");
                writer.WriteLine($"Region: {regionScore.Region}, Average Score: {regionScore.AverageScore:F2}");
            }
        }
    }

}

[SerializeField]
public class Region
{
    public int ID;
    public string Name;
    public Region(int ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
    }
}

[SerializeField]
public class PlayerI
{
    public int ID;
    public string name;
    public int score;
    public Region region;

    public PlayerI(int ID, string name, int score, Region region)
    {
        this.ID = ID;
        this.name = name;
        this.score = score;
        this.region = region;
    }
}