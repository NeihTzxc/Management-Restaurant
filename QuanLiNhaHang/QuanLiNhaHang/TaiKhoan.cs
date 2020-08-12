using QuanLiNhaHang.DAO;
using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class TaiKhoan : Form
    {
        public TaiKhoan()
        {
            InitializeComponent();
        }
       
        private void TaiKhoan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_Lv_TaiKhoan();
            load_TaiKhoan();
        }
        void load_Lv_TaiKhoan()
        {
           
            lv_TaiKhoan.View = View.Details;
            lv_TaiKhoan.Columns.Add("IDTaiKhoan", 0);
            lv_TaiKhoan.Columns.Add("Tên tài khoản", 80);
            lv_TaiKhoan.Columns.Add("Mật khẩu", 80);
            lv_TaiKhoan.GridLines = true;
            lv_TaiKhoan.FullRowSelect = true;
        }
        void load_TaiKhoan()
        {
            lv_TaiKhoan.Items.Clear();
            List<TaiKhoanQT> list_TK = AccountDAO.Instance.GetTaiKhoans();
            int i = 0;
            foreach(TaiKhoanQT data in list_TK)
            {
                
                lv_TaiKhoan.Items.Add(data.IDTaiKhoan1);
                lv_TaiKhoan.Items[i].SubItems.Add(data.TenTaiKhoan1);
                lv_TaiKhoan.Items[i].SubItems.Add(data.MatKhau1);
                i++;
            }
        }

        private void lv_TaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<TaiKhoanQT> list_TK = AccountDAO.Instance.GetTaiKhoans();
            foreach(TaiKhoanQT data in list_TK)
            {
                for(int i = 0; i < lv_TaiKhoan.SelectedItems.Count; i++)
                {
                    if (data.IDTaiKhoan1 == lv_TaiKhoan.SelectedItems[i].SubItems[0].Text)
                    {
                        IDTaiKhoan = data.IDTaiKhoan1;
                        txt_Ten.Text = data.TenTaiKhoan1;
                        txt_MatKhau.Text = data.MatKhau1;
                    }
                }
            }
        }
        void Them_TK()
        {
            try
            {
                AccountDAO.Instance.Them(txt_Ten.Text, txt_MatKhau.Text);
                load_TaiKhoan();
            }
            catch (Exception)
            {

            }
        }
        string IDTaiKhoan;
        void Sua_TK()
        {
            try
            {
                AccountDAO.Instance.Sua_TK(IDTaiKhoan, txt_Ten.Text, txt_MatKhau.Text);
                load_TaiKhoan();
            }
            catch (Exception)
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn_Them_Sua.Text = "Thêm";
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            btn_Them_Sua.Text = "Sửa";
        }

        private void btn_Them_Sua_Click(object sender, EventArgs e)
        {
            if (btn_Them_Sua.Text == "Thêm")
            {
                Them_TK();
            }
            if (btn_Them_Sua.Text == "Sửa")
            {
                Sua_TK();
            }
        }

        private void button_Xuat_Click(object sender, EventArgs e)
        {
            try
            {
                AccountDAO.Instance.Xoa_TK(IDTaiKhoan);
                load_TaiKhoan();
            }
            catch (Exception) { } 
            
        }

        private void lv_TaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    AccountDAO.Instance.Xoa_TK(IDTaiKhoan);
                    load_TaiKhoan();
                }
                catch (Exception) { }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
