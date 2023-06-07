using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    internal class SharedClass
    {
        public static int ucln(int a, int b)
        {
            a=Math.Abs(a);
            b=Math.Abs(b);
            if (b == 0)
                return a;
            else
            {
                while (a != b)
                {
                    if (a > b)
                        a -= b;
                    else b -= a;
                }
                return a;
            }
        }
    }
}
