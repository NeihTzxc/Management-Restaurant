using QuanLiNhaHang.DAO;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            textBox_TTK.Text = "";
            textBox_MK.Text = "";
            button1.Focus();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        bool login(string TenTaiKhoan, string MatKhau)
        {
            return AccountDAO.Instance.Login(TenTaiKhoan, MatKhau);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox_TTK.Text;
            string passWord = textBox_MK.Text;
            if (login(userName, passWord))
            {
                
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!");
            }

        }

    }
}
