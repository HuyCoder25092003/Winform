using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanSo
{
    internal class Phanso
    {
        private int tuSo, mauSo;

        public Phanso()
        {
            tuSo = 0;
            mauSo = 1;
        }
        public Phanso(int t, int m)
        {
            this.tuSo = t;
            this.mauSo = m == 0?1:m;
        }


        public Phanso rutGon()
        {
            int a = SharedClass.ucln(this.tuSo, this.mauSo);
            return new Phanso(this.tuSo / a, this.mauSo / a);
        }

        public Phanso cong(Phanso p)
        {
            return new Phanso(this.tuSo * p.mauSo + this.mauSo * p.tuSo, this.mauSo * p.mauSo).rutGon();
        }

        public Phanso tru(Phanso p)
        {
            return new Phanso(this.tuSo * p.mauSo - this.mauSo * p.tuSo, this.mauSo * p.mauSo).rutGon();
        }

        public Phanso nhan(Phanso p)
        {
            return new Phanso(this.tuSo * p.tuSo , this.mauSo * p.mauSo).rutGon();
        }

        public Phanso chia(Phanso p)
        {
            return new Phanso(this.tuSo * p.mauSo, this.mauSo * p.tuSo).rutGon();
        }

        public int TuSo
        {
            get{ return tuSo;}
            set { tuSo = value; }
        }
        public int MauSo
        {
            get { return mauSo; }
            set { mauSo = value; }
        }
    }
}
