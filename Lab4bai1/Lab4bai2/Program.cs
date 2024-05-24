using System;
using System.Security.Cryptography.X509Certificates;
 class userData
{
    public string Name;
    public int Level;
    public userData(string name, int level)
    {
        Name = name;
        Level = level;
    }
}
class Program
{
    static void Main()
    {
        List<userData> list = new List<userData>();
        list.Add(new userData("Dat", 10));
        list.Add(new userData("Dung", 20));
        list.Add(new userData("Khanh",5));
        list.Add(new userData("Hau", 1));
        var selectedData = list.Select(u => new {u.Name, u.Level});
        Console.WriteLine("Name va Level cua danh sach userData :");
        foreach (var item in selectedData)
        {
            Console.WriteLine("Name :" + item.Name + "|level : " + item.Level);
        }

        var sortedUsers = list.OrderByDescending(u => u.Level);
        Console.WriteLine("Danh sach user data theo thu tu giam dan level :");
        foreach(var item in sortedUsers)
        {
            Console.WriteLine("Name :" + item.Name + "|level : " + item.Level );
        }
    }
}
