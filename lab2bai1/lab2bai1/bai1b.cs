using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bai1b
{
    public Bai1b()
    {
        getDetail(10);
        getDetail("games");
        getDetail(true);
        getDetail(9.5);
    }
    public void getDetail(dynamic value)
    {
        Console.WriteLine("value : " + value);
    }
}
