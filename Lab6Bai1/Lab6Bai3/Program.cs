using System;

class Program
{
    static void Main()
    {
        List<int> list1 = new List<int>() { 1, 2, 3, 4, 5 };
        List<int> list2 = new List<int>() { 5, 6, 7, 8, 1 };
        var Unionlist = list1.Union(list2);
        var sortedlist = Unionlist.OrderByDescending(x => x);
        foreach(var x in sortedlist)
        {
            Console.WriteLine(x);
        }

        Console.WriteLine("-------------");
        var intersect = list1.Intersect(list2);
        foreach(var x in intersect)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("---------------");
        var concat = list1.Concat(list2);
        var concatlist = concat.OrderBy(x => x);
        foreach( var x in concatlist)
        {
            Console.WriteLine(x);
        }
        Console.WriteLine("-------------------");
        var Except = list1.Except(list2);
        foreach(var x in Except)
        {
            Console.WriteLine(x);
        }
    }
}
