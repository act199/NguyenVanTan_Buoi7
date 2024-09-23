using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanTan_Buoi7
{
    internal class Sinhvien : Nguoi
    {
        string Mssv;
        string Nganhhoc;
        double Dtb;

        public string Mssv1 { get => Mssv; set => Mssv = value; }
        public string Nganhhoc1 { get => Nganhhoc; set => Nganhhoc = value; }
        public double Dtb1 { get => Dtb; set => Dtb = value; }

        public Sinhvien() : base() { }
        public Sinhvien(string hoten,string ngaysinh, string gioitinh, string Mssv, string Nganhhoc, double Dtb) : base(hoten, ngaysinh, gioitinh)
        {
            Mssv = Mssv1;
            Nganhhoc = Nganhhoc1;
            Dtb = Dtb1;
        }
    }
}

