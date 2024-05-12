namespace bai_3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int a = 40;
            int b = 20;
            Calculator calculator = new Calculator(a, b);
            int kpCong = calculator.cong(a, b);
            System.Console.WriteLine("cong =" + kpCong);
            int kpTru = calculator.tru(a, b);
            System.Console.WriteLine("tru =" + kpTru);
            int kpNhan = calculator.nhan(a, b);
            System.Console.WriteLine("nhan =" + kpNhan);
            int kpchia = calculator.chia(a, b);
            System.Console.WriteLine("chia =" + kpchia);
        }
    }
}
