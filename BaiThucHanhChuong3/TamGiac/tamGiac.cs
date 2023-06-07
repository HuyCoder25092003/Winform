using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamGiac
{
    internal class tamGiac
    {
        double a, b, c;

        public bool isTamGiac ()
        {
            if(a+b<=c || b+c<=a || a+c<=b)
                return false;
            return true;
        }

        public double chuVi()
        {
            return a + b + c;
        }

        public double dienTich()
        {
            double p = chuVi()/2;
            return Math.Sqrt(p*(p-a)*(p-b)*(p-c));
        }

        public double A
        {
            get { return a; }
            set
            {
                if (value > 0)
                    a = value;
                else a = 0;
            }
        }

        public  double B
        {
            get { return b; }
            set
            {
                if (value > 0)
                    b = value;
                else b = 0;
            }
        }

        public double C
        {
            get { return c; }
            set
            {
                if (value > 0)
                   c = value;
                else c= 0;
            }
        }

    }
}
