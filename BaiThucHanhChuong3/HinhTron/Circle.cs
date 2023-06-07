using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HinhTron
{
    internal class Circle
    {
        private Diem center;
        private double radius;

        public Circle() { }

        public Circle(Diem center, double radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public Circle(double dx, double dy, double radius)
        {
            center.X = dx;
            center.Y = dy;
            this.radius = radius;
        }

        public Diem Center { get { return center; } set { center = value; } }
        public double Radius { get { return radius; } set { radius = value; } }

        public double DienTich()
        {
            return Math.PI * radius * radius;
        }

        public double ChuVi()
        {
            return 2 * Math.PI * radius;
        }

        public bool Check(Diem other)
        {
            double distance = Math.Sqrt(Math.Pow(other.X - center.X, 2) + Math.Pow(other.Y - center.Y, 2));
            return distance <= radius;
        }
    }
}

