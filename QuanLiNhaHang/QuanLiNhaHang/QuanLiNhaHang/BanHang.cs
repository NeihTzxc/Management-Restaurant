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
    public partial class BanHang : Form
    {
        public List<string> id;
        public BanHang()
        {
            InitializeComponent();
        }
        string IDHoaDon = null;
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        void LoadKhuVuc()
        {
            
            List<KhuVuc> KhuVucList = KhuVucDAO.Instance.GetKhuVuc();
            List<Ban> BanList = BanDAO.Instance.GetBans();
            foreach (KhuVuc khuvuc in KhuVucList)
            {
                flowLayoutPanel1.AutoScroll = true;
                FlowLayoutPanel mang = new FlowLayoutPanel();
                mang.Width = 245;
                mang.Height = 150;

                mang.Name = "KV" + (khuvuc.IDKhuvuc1).ToString();
                mang.BackColor = Color.Yellow;
                flowLayoutPanel1.Controls.Add(mang);

                mang.AutoScroll = true;
                Panel panel = new Panel();
                panel.Width = 230;
                panel.Height = 20;
                panel.BackColor = Color.White;
                mang.Controls.Add(panel);

                Label label = new Label();
                label.Text = "Khu Vực " + khuvuc.IDKhuvuc1.ToString();
                panel.Controls.Add(label);            
               foreach(Ban ban in BanList)
                {
                    if (ban.IDKhuvuc1 == khuvuc.IDKhuvuc1)
                    {

                        
                        Button mangbtn = new Button();
                        mangbtn.Width = 50;
                        mangbtn.Height = 30;
                        mangbtn.Text = ban.IDBan1.ToString();
                        mangbtn.Name = ban.IDBan1.ToString();
                        mangbtn.BackColor = Color.White;
                        mang.Controls.Add(mangbtn);
                        mangbtn.ForeColor = Color.White;
                        if (ban.TinhTrang1 != "0")
                        {
                            mangbtn.BackColor = Color.Red;
                        }
                        else
                        {
                            mangbtn.BackColor = Color.Green;
                        }
                        mangbtn.Click  += mangbtn_Click;
                        mangbtn.Tag = ban;
                    }
                }           
            }
        }
        private void BanHang_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            LoadKhuVuc();
            load_Lich_Su_TT_HoaDon();
            load_itemLSHD();
        }
        void load_Lich_Su_TT_HoaDon()
        {
            lv_LSHD.Items.Clear();
            lv_LSHD.View = View.Details;
            lv_LSHD.Columns.Add("Mã bàn", 50);
            lv_LSHD.Columns.Add("ID Hóa đơn", 80);
            lv_LSHD.Columns.Add("Thời gian",140);
            lv_LSHD.Columns.Add("Nhân viên", 120);
            lv_LSHD.Columns.Add("Tổng tiền", 80);
            lv_LSHD.GridLines = true;

            lv_LSHD.FullRowSelect = true;
        }
        void load_itemLSHD()
        {

            List<KetQuaTinhHoaDon> ketQuaTinhHoaDons = KetQuaTinhHoaDonDAO.Instance.XemTTHoaDon_DaThanhToan();
            int i = 0;
                foreach (KetQuaTinhHoaDon data in ketQuaTinhHoaDons)
                {
                lv_LSHD.Items.Add(data.IDBan1);
                lv_LSHD.Items[i].SubItems.Add(data.IDHoaDon1);
                lv_LSHD.Items[i].SubItems.Add(data.NgayLapHD1);
                lv_LSHD.Items[i].SubItems.Add(data.TenNhanVien1);
                lv_LSHD.Items[i].SubItems.Add(data.TongTien1.ToString());
                i++;
                }
           
        }
        private void mangbtn_Click(object sender, EventArgs e)
        {
            string IDBan = ((sender as Button).Tag as Ban).IDBan1;
           
            CTBanHang cTBanHang = new CTBanHang(IDBan);
            this.Hide();
            cTBanHang.Show();
                
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lv_LSHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<KetQuaTinhHoaDon> list = KetQuaTinhHoaDonDAO.Instance.XemTTHoaDon_DaThanhToan();
            foreach (KetQuaTinhHoaDon data in list)
            {
                for (int i = 0; i < lv_LSHD.SelectedItems.Count; i++)
                {
                    if(data.IDHoaDon1== lv_LSHD.SelectedItems[i].SubItems[1].Text)
                    {
                        IDHoaDon = data.IDHoaDon1;
                    }
                    
                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (IDHoaDon == null)
            {
                MessageBox.Show("Không thể xóa");
            }
            else
            {
                try
                {
                    HoaDonDAO.Instance.Xoa(IDHoaDon);
                    lv_LSHD.Items.Clear();
                    load_itemLSHD();
                }
                catch (Exception)
                {

                }
            }
           
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            XuaHD xuaHD = new XuaHD(IDHoaDon);
            xuaHD.Show();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
