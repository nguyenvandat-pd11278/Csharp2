using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserData
{
    public int ID;
    public string Name;
    public int Level;
    public UserData(int iD, string name, int level)
    {
        this.ID = iD;
        this.Name = name;
        this.Level = level;
    }
    public void ShowData()
    {
        Console.WriteLine("ID :" +  ID);
        Console.WriteLine("Name :" +  Name);
        Console.WriteLine("Level :" +  Level);
    }
    public void ShowData(string atrributename , dynamic atrributeValue)
    {
        Console.WriteLine(atrributename + " " + atrributeValue);
    }
}
