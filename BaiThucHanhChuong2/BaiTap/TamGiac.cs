using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class TamGiac
    {
        private double a, b, c;

        public TamGiac()
        {
        }

        public double A { get => a; set => a = value; }
        public double B { get => b; set => b = value; }
        public double C { get => c; set => c = value; }

        public TamGiac(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public String layTen()
        {
            return "Tam giac thuong";
        }
        public double tinhChuVi()
        {
            return this.a + this.b + this.c;
        }
        public double tinhDienTich()
        {
            double p = this.tinhChuVi() / 2;
            return Math.Sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
        }
    }
}

