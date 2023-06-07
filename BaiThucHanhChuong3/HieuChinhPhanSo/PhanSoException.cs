using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HieuChinhPhanSo
{
    public class PhanSoException : Exception
    {
        public PhanSoException() { }
        public PhanSoException(string msg) : base(msg) { }
    }

}
