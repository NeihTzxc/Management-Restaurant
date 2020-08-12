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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_LV_DT();
            load_DT();
            thongKe_mon();
        }
        public void thongKe_mon()
        {
            List<ThongKeMon> thongKeMons = ThongKeMonDAO.Instance.GetThongKeMons();
            int i = 0;
            foreach (ThongKeMon data in thongKeMons)
            {
                panel_group.Hide();
                Panel mang = new Panel();
                mang.Size = panel_group.Size;
                flowLayoutPanel_thongke.Controls.Add(mang);

                Panel panel_mon = new Panel();
                panel_mon.Width = panel_Tenmon.Width;
                panel_mon.Height = panel_Tenmon.Height;
                panel_mon.Location = panel_Tenmon.Location;
                panel_mon.BackColor = panel_Tenmon.BackColor;
                mang.Controls.Add(panel_mon);

                Panel panel_soLuong = new Panel();
                panel_soLuong.Width = panel_solxh.Width;
                panel_soLuong.Height = panel_solxh.Height;
                panel_soLuong.Location = panel_solxh.Location;
                panel_soLuong.BackColor = panel_solxh.BackColor;
                mang.Controls.Add(panel_soLuong);

                Label label_TenMon = new Label();
                label_TenMon.Location = label_temon1.Location;
                label_TenMon.Text = data.TenMon1;
                label_TenMon.ForeColor = label_temon1.ForeColor;
                panel_mon.Controls.Add(label_TenMon);

                Label label_SoLuong = new Label();
                label_SoLuong.Location = label_soluong1.Location;
                label_SoLuong.Text = data.SoLuong1.ToString();
                panel_soLuong.Controls.Add(label_SoLuong);
                label_SoLuong.ForeColor = label_soluong1.ForeColor;

                Label title_mon = new Label();
                title_mon.Location = label_temon.Location;
                title_mon.ForeColor = label_temon.ForeColor;
                panel_mon.Controls.Add(title_mon);
                title_mon.Text = label_temon.Text;

                Label title_soluong = new Label();
                title_soluong.Location = label_soluong.Location;
                title_soluong.ForeColor = label_soluong.ForeColor;
                panel_soLuong.Controls.Add(title_soluong);
                title_soluong.Text = label_soluong.Text;

                if (i < 5)
                {
                    Panel panel_NSao = new Panel();
                    panel_NSao.Location = panel_ngoisao.Location;
                    panel_NSao.BackgroundImage = panel_ngoisao.BackgroundImage;
                    panel_NSao.BackgroundImageLayout = panel_ngoisao.BackgroundImageLayout;
                    panel_NSao.Size = panel_ngoisao.Size;
                    panel_mon.Controls.Add(panel_NSao);
                }
                i++;
            }
        }
        void load_LV_DT()
        {
            lv_DT.View = View.Details;
            lv_DT.Columns.Add("Tháng", 80);
            lv_DT.Columns.Add("Doanh thu", 80);

            lv_DT.GridLines = true;
            lv_DT.FullRowSelect = true;
        }
        void load_DT()
        {
            List<DoanhThu> list_DT = DoanhThuDAO.Instance.ThongKe();
            int i = 0;
            foreach(DoanhThu data in list_DT)
            {
                lv_DT.Items.Add(data.Thang1);
                lv_DT.Items[i].SubItems.Add(data.TongTien1.ToString());
                i++;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
