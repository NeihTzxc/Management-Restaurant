using QuanLiNhaHang.DAO;
using QuanLiNhaHang.DTO;
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
    public partial class DanhMuc_NhanVien : Form
    {
        public DanhMuc_NhanVien()
        {
            InitializeComponent();
        }
       
        private void DanhMuc_NhanVien_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_item_NhanVien();
            loadNhanVien();
        }
        public void load_item_NhanVien()
        {
            lv_nv.View = View.Details;
            lv_nv.Columns.Add("ID Chấm công", 0);
            lv_nv.Columns.Add("ID Nhân Viên", 0);
            lv_nv.Columns.Add("Tên Nhân Viên", 110);
            lv_nv.Columns.Add("Chức vụ", 100);
            lv_nv.Columns.Add("Số công", 0);
            lv_nv.Columns.Add("Lương", 100);
            lv_nv.GridLines = true;
            lv_nv.FullRowSelect = true;
        }
        public void loadNhanVien()
        {
            List<LuongNV> luongNVs = LuongNVDAO.Instance.GetLuongs();
            int i = 0;
            foreach (LuongNV data in luongNVs)
            {
                lv_nv.Items.Add(data.IDChamCong1);
                lv_nv.Items[i].SubItems.Add(data.IDNhanVien1);
                lv_nv.Items[i].SubItems.Add(data.Ten1);
                lv_nv.Items[i].SubItems.Add(data.ChucVu1);
                lv_nv.Items[i].SubItems.Add(data.SoCong1.ToString());
                lv_nv.Items[i].SubItems.Add(data.Luong1.ToString());

                i++;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lv_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<LuongNV> luongNVs = LuongNVDAO.Instance.GetLuongs();
            foreach(LuongNV data in luongNVs)
            {
                for(int i = 0; i < lv_nv.SelectedItems.Count; i++)
                {
                    if (data.IDChamCong1 == lv_nv.SelectedItems[i].SubItems[0].Text)
                    {
                        lb_tnv.Text = data.Ten1;
                        lb_sc.Text = data.SoCong1.ToString();
                        lb_l.Text = data.Luong1.ToString();
                        tb_sc.Text = data.SoCong1.ToString();
                        lb_nv.Text = data.Ten1;
                    }
                }
            }
        }
        public void Edit_ChamCong()
        {
            bool t = false;
            List<LuongNV> luongNVs = LuongNVDAO.Instance.GetLuongs();
            foreach (LuongNV data in luongNVs)
            {
                for (int i = 0; i < lv_nv.SelectedItems.Count; i++)
                {
                    if (data.IDChamCong1 == lv_nv.SelectedItems[i].SubItems[0].Text)
                    {
                      
                        t = LuongNVDAO.Instance.Update(data.IDChamCong1, tb_sc.Text);                      
                      
                        if (t)
                        {
                            LuongNV luong = new LuongNV();
                            lv_nv.Items.Clear();
                            loadNhanVien();
                            lb_sc.Text = tb_sc.Text;
                            lb_l.Text = data.Luong1.ToString();
                          //  lb_l.Text = lv_nv.SelectedItems[i].SubItems[5].Text
;                            MessageBox.Show("Sửa thành công");
                        }
                    }
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            Edit_ChamCong();
        }
    }
}
