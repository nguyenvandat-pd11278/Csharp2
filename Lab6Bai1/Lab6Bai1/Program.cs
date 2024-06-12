using System;

class Program
{
    static void Main()
    {
        List<int> listInt = new List<int>() { 2, 4, 5, 6, 7, 8, 9 };
        List<string> str = new List<string>() { null, "T1", "T2", "T3", null };
        List<string> listNull = new List<string>();

        int firstthanfive = listInt.FirstOrDefault(x => x > 5 && x % 2 == 0);
        int lastmorethan = listInt.FirstOrDefault(x => x > 200);
        string firtstarwithT = str.FirstOrDefault(x => x != null && x.StartsWith("T", StringComparison.Ordinal));
        var firstValue = listInt.Where((value,index) => index % 2 != 0 && value % 2 == 0);
        int sum = firstValue.Sum();
        if (firstthanfive != 0)
        {
            Console.WriteLine($"So dau tien va lon hon 5 trong listInt : {firstthanfive}");
        }
        else
        {
            Console.WriteLine("khong tim thay so chan nao lon hon 5 ");
        }
        if (lastmorethan != 0)
        {
            Console.WriteLine($"Phan tu cuoi cung trong listInt co gia tri > 200 :{lastmorethan}");
        }
        else
        {
            Console.WriteLine("khong tim thay gia tri trong listInt > 200");
        }
        if(firtstarwithT != null)
        {
            Console.WriteLine($"Phan tu dau tien trong listStr co gia tri bat dau bang ky tu T :{firtstarwithT}");
        }
        else
        {
            Console.WriteLine("khong tim thay");
        }
        Console.WriteLine($"tong gia tri cac vi tri le va so do chia het cho 2 :{sum}");

    }
}
