using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-NE0DFVV;Initial Catalog=QuanLiNhaHang;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            DanhMuc_MonAn danhMuc_MonAn = new DanhMuc_MonAn();
            this.Hide();
            danhMuc_MonAn.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Danhmuc_Ban danhmuc_Ban = new Danhmuc_Ban();
            this.Hide();
            danhmuc_Ban.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DanhMuc_MatHang danhMuc_MatHang =new DanhMuc_MatHang();
            this.Hide();
            danhMuc_MatHang.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            DanhMuc_NhanVien danhMuc_NhanVien = new DanhMuc_NhanVien();
            this.Hide();
            danhMuc_NhanVien.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DanhMuc_ChucVu danhMuc_ChucVu = new DanhMuc_ChucVu();
            this.Hide();
            danhMuc_ChucVu.Show();
        }

   

        private void button12_Click_1(object sender, EventArgs e)
        {
            DanhMuc_ChucVu danhMuc_ChucVu = new DanhMuc_ChucVu();
            this.Hide();
            danhMuc_ChucVu.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            DanhMuc_NhanVien danhMuc_NhanVien = new DanhMuc_NhanVien();
            this.Hide();
            danhMuc_NhanVien.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BanHang banHang = new BanHang();
            this.Hide();
            banHang.Show();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = new TaiKhoan();
            this.Hide();
            taiKhoan.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ThongKe thongKe = new ThongKe();
            this.Hide();
            thongKe.Show();
        }
    }
}
