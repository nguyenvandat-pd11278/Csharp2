using System;
using System.Security.Cryptography.X509Certificates;

public class UserAccountLab5
{
    public string Name;
    public int Rank;
    public float WinRate;
    public string Type;
    public int Skin;
    public UserAccountLab5(string name, int rank, float winRate, string type, int skin)
    {
        Name = name;
        Rank = rank;
        WinRate = winRate;
        Type = type;
        Skin = skin;
        
    }
    public override string ToString()
    {
        return $"Name: {Name}, Rank: {Rank}, Winrate: {WinRate}, Type: {Type}, Skin: {Skin}";
    }
}
    
class Program
{
    static void Main()
    {
        List<UserAccountLab5> list = new List<UserAccountLab5>();
        {
            list.Add(new UserAccountLab5("Son tung", 10, 55.5f, "Ca nhac", 50));
            list.Add(new UserAccountLab5("Den Vau", 5, 70, "Ca nhac", 10));
            list.Add(new UserAccountLab5("thuy linh", 15, 45.5f, "Ca nhac", 25));
            list.Add(new UserAccountLab5("do mixi", 1, 90, "All", 2));
            list.Add(new UserAccountLab5("ba tuyet diamond", 3, 60.5f, "am thuc", 10));
            list.Add(new UserAccountLab5("pew pew", 4, 55.5f, "live", 50));
            list.Add(new UserAccountLab5("lien minh", 2, 85.5f, "Game", 255));
            list.Add(new UserAccountLab5("lien quan", 11, 55.5f, "Game", 200));
            list.Add(new UserAccountLab5("fifa 4", 7, 55.5f, "Game", 150));
            list.Add(new UserAccountLab5("CSO", 8, 55.5f, "Game", 1000));
            list.Add(new UserAccountLab5("CSGO", 6, 85.5f, "Game", 500));
        };
        Console.WriteLine("Cau 1");
        foreach ( var user in list)
        {
            Console.WriteLine(user);
        }
        var shorRank = list.OrderByDescending(user => user.Rank).ToList();
        Console.WriteLine("-------------");
        Console.WriteLine("Cau 2");  
        foreach ( var user in shorRank)
        {
            Console.WriteLine(user);

        }
        Console.WriteLine("--------------");
        Console.WriteLine("Cau 3");
        var shorNameandSkin = list.OrderByDescending(user => user.Name).ThenBy(user => user.Skin).ToList();
        foreach ( var user in shorNameandSkin) 
        { 
            Console.WriteLine(user); 
        }
        Console.WriteLine("---------");
        Console.WriteLine("Cau 4");
        var shortNamewhithB = list.Where(user=> user.Name.StartsWith("b")).ToList();
        foreach ( var user in shortNamewhithB) { Console.WriteLine(user); }

    }
}

