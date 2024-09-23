using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanTan_Buoi7
{
    internal class Nhanvien : Nguoi
    {
        string Msnv;
        string luong;
        string Chucvu;

        public string Msnv1 { get => Msnv; set => Msnv = value; }
        public string Luong { get => luong; set => luong = value; }
        public string Chucvu1 { get => Chucvu; set => Chucvu = value; }
        public Nhanvien():base() { }
        public Nhanvien(string hoten, string ngaysinh, string gioitinh, string Msnv, string luong, string Chucvu) : base(hoten, ngaysinh, gioitinh)
        {
            Msnv1=Msnv;
            Luong=luong;
            Chucvu1=Chucvu;
        }
    }
}
