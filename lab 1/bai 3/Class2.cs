using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public partial class Calculator
{
    public int cong(int a, int b)
    {
        return a + b;
    }
    public int tru(int a, int b)
    {
        return a - b;
    }
    public int nhan(int a, int b)
    {
        return a * b;
    }
    public int chia(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            return int.MinValue;
        }
    }
}
