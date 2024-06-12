using System;
class Program
{
    static void Main()
    {
        List<int> nums = new List<int>() { 1, 3, 4, 5, 7, 8, 9 };
        var squareNumber = from n in nums
                           where n > 4
                           select n * n;
        foreach (var num in squareNumber)
        {
            Console.WriteLine(num + " ");
        }
        Console.WriteLine("------------");
        string strb = "chao mung den voi binh nguyen vo tan";
        var resultb = strb.Where(char.IsLetter).GroupBy(str => str).Select(group => new {Key = group.Key, count = group.Count()});
        foreach(var item in resultb)
        {
            Console.WriteLine($"{item.Key}:{item.count}");
        }
        Console.WriteLine("-------------");
        string str = "CHAO mung DEN Voi binh nguyen vo tan";
        var words = str.Split(' ');
        var result = from word in words
                     where word.Equals(word.ToUpper())
                     select word;
        foreach(var word in result)
        {
            Console.WriteLine(word);
        }
    }
}