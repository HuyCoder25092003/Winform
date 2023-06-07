using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class Diem
    {
        private double x;
        private double y;

        public Diem()
        {
        }

        public Diem(double a, double b)
        {
            this.x = a;
            this.y = b;
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
    }
}
