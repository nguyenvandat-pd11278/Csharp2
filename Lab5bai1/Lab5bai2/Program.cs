using System;
public class UserAccount
{
    public string UserName;
    public float WinRate;
    public UserAccount(string userName, float winRate)
    {
        UserName = userName;
        WinRate = winRate;
    }
}

class Program
{
    static void Main()
    {
        List<UserAccount> useraccount = new List<UserAccount>
        {
            new UserAccount(userName: "user 1", winRate: 60.5f),
            new UserAccount(userName: "user 2", winRate: 50.5f),
            new UserAccount(userName: "user 3", winRate: 40.5f),
            new UserAccount(userName: "user 4", winRate: 30.5f),
            new UserAccount(userName: "user 5", winRate: 70.5f),
        };
        var winratemorethan50 = useraccount.Where(user => user.WinRate > 50);
        Console.WriteLine("Danh sach cac nguoi co winrate > 50:");
        foreach (var user in winratemorethan50)
        {
            Console.WriteLine($"username:{user.UserName},winrate:{user.WinRate}");
        }
        Console.WriteLine("-------------------------");
        var winratebiger = useraccount.OrderByDescending(user => user.WinRate).FirstOrDefault();
        if(winratebiger != null)
        {
            Console.WriteLine($"Ten nguoi choi cao nhat:{winratebiger.UserName},ti le chien thang cao nhat:{winratebiger.WinRate}");
        }
        else
        {
            Console.WriteLine("Khong co nguoi choi nao co ti le thang cao nhat");
        }
        Console.WriteLine("-----------------------------");
        int totalaccount = useraccount.Count();
        Console.WriteLine($"So luong trong UserAccount:{totalaccount}");
    }
}