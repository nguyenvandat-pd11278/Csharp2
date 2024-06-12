using Microsoft.VisualBasic;
using System;
using System.Reflection.Metadata;
using System.Xml.Linq;
using static UserData;

public static class UserData
{
    public static string ID;
    public static string Name;
    public static float Health;
    public static int Point;

    static UserData()
    {
        ID = "11329112004";
        Name = "datcute1222";
        Health = 100.5f;
        Point = 10;
    }
}

public class Program
{
    //bai 1 
    public static void Main(string[] args)
    {
        
        Console.WriteLine("ID :" + UserData.ID);
        Console.WriteLine("Name :" + UserData.Name);
        Console.WriteLine("Health :" + UserData.Health);
        Console.WriteLine("Point :" + UserData.Point);
    }
}



