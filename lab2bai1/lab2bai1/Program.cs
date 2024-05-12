using System;
using System.Diagnostics;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Bai 1a :");
        Bai1a obj1 = new Bai1a();
        Console.WriteLine("\nBai 1b :");
        Bai1b obj2 = new Bai1b();
        Console.WriteLine("\nbai 1c :");
        UserData user = new UserData(1,"nguyen van dat",5);
        user.ShowData();
    }
}

