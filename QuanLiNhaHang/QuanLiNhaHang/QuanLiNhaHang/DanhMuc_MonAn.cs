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
    public partial class DanhMuc_MonAn : Form
    {
        public DanhMuc_MonAn()
        {
            InitializeComponent();
        }
        public void load_mon()
        {
            List<Mon> mons = MonDAO.Instance.GetMon();
            int i=0;
            foreach(Mon mon in mons)
            {
                listView_mon.Items.Add(mon.IDMon1.ToString());
                listView_mon.Items[i].SubItems.Add(mon.TenMon1.ToString());
                listView_mon.Items[i].SubItems.Add(mon.DonGia1.ToString());
                i++;
            }
        }
        public void load_item_mon()
        {
            listView_mon.Items.Clear();

            listView_mon.View = View.Details;
            listView_mon.Columns.Add("ID món ăn",80);
            listView_mon.Columns.Add("Tên món ăn", 120);
            listView_mon.Columns.Add("Đơn giá");
            listView_mon.GridLines = true;

            listView_mon.FullRowSelect = true;
        }
        public void thongKe()
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
        private void button15_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void DanhMuc_MonAn_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_item_mon();
            load_mon();
            thongKe();


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label_temon_Click(object sender, EventArgs e)
        {

        }
        void XoaMon()
        {
            bool t = false;
            List<Mon> mons = MonDAO.Instance.GetMon();

            foreach (Mon mon in mons)
            {
                for (int i = 0; i < listView_mon.SelectedItems.Count; i++)
                {
                    if (mon.IDMon1 == (listView_mon.SelectedItems[i].SubItems[0].Text))
                    {
                        try
                        {                                      
                            t = MonDAO.Instance.xoa(listView_mon.SelectedItems[i].SubItems[0].Text);
                            listView_mon.Items.Clear();
                            load_mon();                       
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }


                }
            }
        }
        private void button_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                XoaMon();
                listView_mon.Items.Clear();
                load_mon();
            }
            else
            {

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            bool t = false;
            if(tb_TenMon.Text==""|| tb_DonGia.Text == ""|| tb_TenMon.Text ==null || tb_DonGia.Text ==null)
            {
                MessageBox.Show("Không thể thêm");
            }
            else
            {
                try
                {
                    t = MonDAO.Instance.Insert_Mon(tb_TenMon.Text, tb_DonGia.Text);
                    if (!t)
                    {
                        MessageBox.Show("Lỗi");
                    }
                    else
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    listView_mon.Items.Clear();
                    load_mon();

                }
                catch (Exception)
                {

                }
            }
           
        }

        private void listView_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Mon> mons = MonDAO.Instance.GetMon();
            foreach (Mon mon in mons)
            {
                for (int i = 0; i < listView_mon.SelectedItems.Count; i++)
                {
                    label_idmon.Text = listView_mon.SelectedItems[i].SubItems[0].Text;
                    tb_suaTen.Text = listView_mon.SelectedItems[i].SubItems[1].Text;
                    tb_suaDonGia.Text = listView_mon.SelectedItems[i].SubItems[2].Text;
                }
            }
           
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool t = false;
          
            List<Mon> mons = MonDAO.Instance.GetMon();

            foreach (Mon mon in mons)
            {
                for (int i = 0; i < listView_mon.SelectedItems.Count; i++)
                {
                   
                    t = MonDAO.Instance.update_mon(listView_mon.SelectedItems[i].SubItems[0].Text, tb_suaTen.Text, tb_suaDonGia.Text);
                    if (t)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    listView_mon.Items.Clear();
                    load_mon();
                }
            }
           
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
