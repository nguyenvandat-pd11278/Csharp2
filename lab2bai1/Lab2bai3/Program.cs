using System;

public class UserData
{
    public int ID;
    public string userName;
    public List<float> Scores;
    public UserData(int id, string username, List<float> scores)
    {
        ID = id;
        userName = username;
        Scores = scores;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<float> Idata = new List<float>() { 10,9,8,7.5f,2,1.4f};
        int studentID = 11378;
        string fullName = "Nguyen Van Dat";
        UserData userData = new UserData(studentID, fullName,Idata);
        Console.WriteLine("UserData");
        Console.WriteLine("ID :" + userData.ID);
        Console.WriteLine("userName :" + userData.userName);
        Console.WriteLine("Scores :");
        foreach (var scores in userData.Scores)
        {
            Console.WriteLine(scores);
        }
    }
}

