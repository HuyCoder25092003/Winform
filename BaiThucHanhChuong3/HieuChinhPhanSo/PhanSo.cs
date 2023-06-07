using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuChinhPhanSo
{
    internal class PhanSo
    {
        private int tu, mau;
        public PhanSo()
        {
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
                throw new PhanSoException("Không thể chia 0");
            if (mau < 0)
            {
                tu *= -1;
                mau *= -1;
            }

            this.tu = tu;
            this.mau = mau;
        }

        public static int UCLN(int a, int b)
        {
            if (b == 0)
                return a;
            if (a % b == 0)
                return b;

            return UCLN(b,a%b);
        }
        
        public static PhanSo RutGon(PhanSo f)
        {
            int ucln = UCLN(f.tu, f.mau);
            return new PhanSo(f.tu / ucln, f.mau / ucln);
        }

        public static PhanSo operator +(PhanSo f1, PhanSo f2)
        {
            PhanSo res = new PhanSo();
            res.tu = f1.tu * f2.mau + f2.tu * f1.mau;
            res.mau = f1.mau * f2.mau;
            return RutGon(res);
        }

        // Trừ 2 phân số
        public static PhanSo operator -(PhanSo f1, PhanSo f2)
        {
            PhanSo res = new PhanSo();
            res.tu = f1.tu * f2.mau - f2.tu * f1.mau;
            res.mau = f1.mau * f2.mau;
            return RutGon(res);
        }

        // Nhân 2 phân số
        public static PhanSo operator *(PhanSo f1, PhanSo f2)
        {
            PhanSo res = new PhanSo();
            res.tu = f1.tu * f2.tu;
            res.mau = f1.mau * f2.mau;
            return RutGon(res);
        }

        // Chia 2 phân số
        public static PhanSo operator /(PhanSo f1, PhanSo f2)
        {
            PhanSo res = new PhanSo();
            res.tu = f1.tu * f2.mau;
            res.mau = f1.mau * f2.tu;
            return RutGon(res);
        }

        public static bool operator ==(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu == 0) 
                return true;
            
            return false;
        }

        public static bool operator !=(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu != 0) 
                return true;
            return false;
        }

        public static bool operator >(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu > 0) return true;
            return false;
        }

        // So sánh phân số f1 có nhỏ hơn phân số f2 không
        // True nếu nhỏ hơn
        // False nếu không nhỏ hơn
        public static bool operator <(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu < 0) return true;
            return false;
        }

        // So sánh phân số f1 có lớn hơn hoặc bằng phân số f2 không
        // True nếu lớn hơn hoặc bằng
        // False nếu không lớn hơn hoặc bằng
        public static bool operator >=(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu >= 0) return true;
            return false;
        }

        // So sánh phân số f1 có nhỏ hơn hoặc bằng phân số f2 không
        // True nếu nhỏ hơn hoặc bằng
        // False nếu không nhỏ hơn hoặc bằng
        public static bool operator <=(PhanSo f1, PhanSo f2)
        {
            if ((f1 - f2).tu <= 0) return true;
            return false;
        }


        public int Tu
        {
            get { return tu; }
            set { tu = value; }
        }

        public int Mau
        {
            get { return mau; }
            set { mau = value; }
        }
    }
}
