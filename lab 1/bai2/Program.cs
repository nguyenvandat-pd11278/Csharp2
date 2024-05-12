using System;
public class Maps
{
    public string ID {  get; set; }
    public string Name { get; set; }
    public string _inGame = "lien minh huyen thoai";
    public Maps(string id , string name)
    {
        ID = id;
        Name = name;
    }
    public string ShowData()
    {
        return "ID : " + ID + "|NAME :" + Name + "|inGame :" + _inGame;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        var map = new Maps("2020", "URF");
        Console.WriteLine(map.ShowData());
    }
}
