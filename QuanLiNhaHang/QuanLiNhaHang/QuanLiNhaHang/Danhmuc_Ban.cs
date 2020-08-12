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
    public partial class Danhmuc_Ban : Form
    {
        public Danhmuc_Ban()
        {
            InitializeComponent();
        }
        public string idban = null, idkhuvuc = null;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
        public void loadban()
        {
            List<Ban> bans = BanDAO.Instance.GetBans();
            int i = 0;
            foreach(Ban data in bans)
            {
                listView_ban.Items.Add(data.IDBan1);
                listView_ban.Items[i].SubItems.Add(data.IDKhuvuc1);
                listView_ban.Items[i].SubItems.Add(data.TinhTrang1);
                i++;
            }
        }
        public void load_item_ban()
        {
            listView_ban.Items.Clear();

            listView_ban.View = View.Details;
            listView_ban.Columns.Add("Số bàn", 80);
            listView_ban.Columns.Add("Mã khu vực", 80);
            listView_ban.Columns.Add("Tình trạng",80);
            listView_ban.GridLines = true;
            listView_ban.FullRowSelect = true;
        }
        public void load_khuvuc()
        {
            List<KhuVuc> khuVucs = KhuVucDAO.Instance.GetKhuVuc();
            foreach(KhuVuc khuVuc in khuVucs)
            {
                comboBox_khuvuc.Items.Add(khuVuc.IDKhuvuc1);
                comboBox_suakv.Items.Add(khuVuc.IDKhuvuc1);
            }
            
        }
        public bool Insert_ban()
        {
            idban = tb_soban.Text;
           
            
            List<Ban> bans = BanDAO.Instance.GetBans();
            int i = 0;
            foreach (Ban data in bans)
            {
                if (data.IDBan1 == idban)
                    return false;
            }
            bool t = false;
            if (idban!=null&&idkhuvuc!=null)
            {
                t = BanDAO.Instance.Insert_Ban(tb_soban.Text, idkhuvuc);
                if (!t)
                {
                    MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            listView_ban.Items.Clear();
            loadban();
            return true;
        }
        public void thongKe()
        {
            List<ThongKeBan> thongKeBans = ThongKeBanDAO.Instance.Get_ThongKeBan();
            int i = 0;
            foreach (ThongKeBan data in thongKeBans)
            {
                panel_group.Hide();
                Panel mang = new Panel();
                mang.Size = panel_group.Size;
                flowLayoutPanel_thongke.Controls.Add(mang);

                Panel panel_ban = new Panel();
                panel_ban.Width = panel_Tenmon.Width;
                panel_ban.Height = panel_Tenmon.Height;
                panel_ban.Location = panel_Tenmon.Location;
                panel_ban.BackColor = panel_Tenmon.BackColor;
                mang.Controls.Add(panel_ban);

                Panel panel_soLuong = new Panel();
                panel_soLuong.Width = panel_solxh.Width;
                panel_soLuong.Height = panel_solxh.Height;
                panel_soLuong.Location = panel_solxh.Location;
                panel_soLuong.BackColor = panel_solxh.BackColor;
                mang.Controls.Add(panel_soLuong);

                Label label_TenBan = new Label();
                label_TenBan.Location = label_tenban1.Location;
                label_TenBan.Text = data.IDBan1;
                label_TenBan.ForeColor = label_tenban1.ForeColor;
                panel_ban.Controls.Add(label_TenBan);

                Label label_SoLuong = new Label();
                label_SoLuong.Location = label_soluong1.Location;
                label_SoLuong.Text = data.SoLuong1.ToString();
                panel_soLuong.Controls.Add(label_SoLuong);
                label_SoLuong.ForeColor = label_soluong1.ForeColor;

                Label title_tenban = new Label();
                title_tenban.Location = label_tenban.Location;
                title_tenban.ForeColor = label_tenban.ForeColor;
                panel_ban.Controls.Add(title_tenban);
                title_tenban.Text = label_tenban.Text;

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
                    panel_ban.Controls.Add(panel_NSao);
                }
                i++;
            }
        }
        private void Danhmuc_Ban_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_item_ban();
            loadban();
            load_khuvuc();
            thongKe();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            List<Ban> bans = BanDAO.Instance.GetBans();
            bool t = false;
            foreach (Ban data in bans)
            {
                for (int i = 0; i < listView_ban.SelectedItems.Count; i++)
                {
                    try
                    {
                        t = BanDAO.Instance.xoa(listView_ban.SelectedItems[i].SubItems[0].Text);
                        listView_ban.Items.Clear();
                        loadban();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }
            }

           
        }

        private void comboBox_khuvuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            idkhuvuc = comboBox_khuvuc.SelectedItem.ToString();
        }
        public string idskv;
        private void btn_sua_Click(object sender, EventArgs e)
        {
            bool t = false;
            t = BanDAO.Instance.Update_ban(tb_suaTen.Text, idskv);
            if (!t)
            {
                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            listView_ban.Items.Clear();
            loadban();
        }

        private void listView_ban_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Ban> bans = BanDAO.Instance.GetBans();
            foreach (Ban data in bans)
            {
                for (int i = 0; i < listView_ban.SelectedItems.Count; i++)
                {

                    if (data.IDBan1.ToString() == listView_ban.SelectedItems[i].SubItems[0].Text)
                    {

                        label_idban.Text = data.IDBan1.ToString();
                        tb_suaTen.Text= data.IDBan1.ToString();

                    }
                }
            }
        }

        private void comboBox_suakv_SelectedIndexChanged(object sender, EventArgs e)
        {
            idskv = comboBox_suakv.SelectedItem.ToString();
        }

        private void label_tenban_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Insert_ban();
        }
    }
}
