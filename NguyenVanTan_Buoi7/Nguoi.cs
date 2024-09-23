using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenVanTan_Buoi7
{
    internal class Nguoi
    {
        string hoten;
        string gioitinh;
        string ngaysinh;

        public string Hoten { get => hoten; set => hoten = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public Nguoi() { }
        public Nguoi(string hoten, string gioitinh, string ngaysinh)
        {
            Hoten = hoten;
            Gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
        }
    }
}
