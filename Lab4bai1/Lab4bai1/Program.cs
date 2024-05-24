using System;

class Program
{
    static void Main()
    {
        List<int> number = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9};
        List<int> evennumber = number.Where(n => n % 2 == 0).ToList();
        Console.WriteLine("Cac so chan trong danh sach la :");
        evennumber.ForEach(n => Console.WriteLine(n));
    }
}
