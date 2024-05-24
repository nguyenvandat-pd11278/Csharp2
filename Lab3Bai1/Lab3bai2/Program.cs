using System;
class Program
{
    static void Main()
    {
        using (StringWriter sw = new StringWriter())
        {
            sw.WriteLine("username : nguyen van dat");
            sw.WriteLine("password : 09042004");
            sw.WriteLine("time :" + DateTime.Now.ToString());
            string data = sw.ToString();
            using (StringReader sr = new StringReader(data))
            {
                string line;
                while ((line = sr.ReadLine())!= null)
                {
                    Console.WriteLine(line);    
                }
            }
        }
    }
}
