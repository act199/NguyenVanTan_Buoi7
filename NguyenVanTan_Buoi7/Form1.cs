namespace NguyenVanTan_Buoi7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Nguoi> Li_Nguoi = new List<Nguoi>();
        List<Sinhvien> Li_Sinhvien = new List<Sinhvien>();
        List<Nhanvien> Li_Nhanvien = new List<Nhanvien>();
        private void button1_Click(object sender, EventArgs e)
        {
            Nguoi nguoi = new Nguoi(txthoten.Text, txtgioitinh.Text, dtpngaysinh.Text);
            Li_Nguoi.Add(nguoi);
            dataGridViewnguoi.DataSource = null;
            dataGridViewnguoi.DataSource = Li_Nguoi;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sinhvien sinhvien = new Sinhvien(txthoten.Text, dtpngaysinh.Text, txtgioitinh.Text, txtmssv.Text, txtnganhhoc.Text, Convert.ToInt32(txtdiemtb.Text));
            Li_Sinhvien.Add(sinhvien);
            dataGridViewSinhvien.DataSource = null;
            dataGridViewSinhvien.DataSource = Li_Sinhvien;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien(txthoten.Text, dtpngaysinh.Text, txtgioitinh.Text, txtmsnv.Text, txtluong.Text, txtchucvu.Text);
            Li_Nhanvien.Add(nhanvien);
            dataGridViewNhanvien.DataSource = null;
            dataGridViewNhanvien.DataSource = (Li_Nhanvien);
        }

        private void btn_xoanguoi_Click(object sender, EventArgs e)
        {
            foreach (Nguoi i in Li_Nguoi)
            {
                if (i.Hoten == txthoten.Text)
                {
                    Li_Nguoi.Remove(i);
                    break;
                }
            }
            dataGridViewnguoi.DataSource = null;
            dataGridViewnguoi.DataSource = (Li_Nguoi);
        }
    }
}
