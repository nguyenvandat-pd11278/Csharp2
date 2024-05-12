using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class BAI2a
{
    public void Bai2a()
    {
        var userInfp = new
        {
            id = "2024",
            name = "faker",
            isplaying = false,
            bag = new
            {
                skins = 0,
                cups = 20,
            }
        };
        Console.WriteLine("id :" +  userInfp.id);
        Console.WriteLine("name :" + userInfp.name);
        Console.WriteLine("isplaying :" + userInfp.isplaying);
        Console.WriteLine("bag skins :" + userInfp.bag.skins);
        Console.WriteLine("bag cups :" + userInfp.bag.cups);
    }
}
