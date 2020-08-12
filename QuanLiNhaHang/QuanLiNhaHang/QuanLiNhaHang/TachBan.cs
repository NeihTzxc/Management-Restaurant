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
    public partial class TachBan : Form
    {
        public TachBan()
        {
            InitializeComponent();
        }
        public string idban,idhd=null,idhd_moi=null;
        public TachBan(string idban)
        {
            this.idban = idban;
            InitializeComponent();
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
                foreach (Ban ban in BanList)
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
                        mangbtn.Click += mangbtn_Click;
                        mangbtn.Tag = ban;
                    }
                }
            }
        }
        private void mangbtn_Click(object sender, EventArgs e)
        {
            
            string IDBan = ((sender as Button).Tag as Ban).IDBan1;
            idhd_moi = HoaDonDAO.Instance.GET_IDHD(IDBan);
            if (IDBan == idban)
            {
                MessageBox.Show("Không thể chọn bàn này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                label_idban_moi.Text = IDBan;
                listView_XemCTHD_Moi.Items.Clear();
                load_XemCTHD_Moi(IDBan);
                label_IDHD_Moi.Text = HoaDonDAO.Instance.GET_IDHD(IDBan);

            }

        }
        public void load_XemCTHD_Cu()
        {
            idhd = HoaDonDAO.Instance.GET_IDHD(idban);

            List<XemCTHoaDon> xemCThoaDons = XemCTHoaDonDAO.Instance.Get_XemCTHoaDons(idhd);
            if (xemCThoaDons != null)
            {
                int i = 0;

                foreach (XemCTHoaDon data in xemCThoaDons)
                {

                    listView_XemCTHD_Cu.Items.Add(data.IDCTHoaDon1.ToString());
                    listView_XemCTHD_Cu.Items[i].SubItems.Add(data.TenMonAn1.ToString());
                    listView_XemCTHD_Cu.Items[i].SubItems.Add(data.SoLuong1.ToString());
                    listView_XemCTHD_Cu.Items[i].SubItems.Add(data.DonGia1.ToString());
                    listView_XemCTHD_Cu.Items[i].SubItems.Add(data.Thanhtien1.ToString());


                    i++;

                }
            }
        }
        public void load_XemCTHD_Moi(string IDBan)
        {
            idhd_moi = HoaDonDAO.Instance.GET_IDHD(IDBan);
            label_IDHD_Moi.Text = idhd_moi;
            List<XemCTHoaDon> xemCThoaDons = XemCTHoaDonDAO.Instance.Get_XemCTHoaDons(idhd_moi);
            if (xemCThoaDons != null)
            {
                int i = 0;

                foreach (XemCTHoaDon data in xemCThoaDons)
                {

                    listView_XemCTHD_Moi.Items.Add(data.IDCTHoaDon1.ToString());
                    listView_XemCTHD_Moi.Items[i].SubItems.Add(data.TenMonAn1.ToString());
                    listView_XemCTHD_Moi.Items[i].SubItems.Add(data.SoLuong1.ToString());
                    listView_XemCTHD_Moi.Items[i].SubItems.Add(data.DonGia1.ToString());
                    listView_XemCTHD_Moi.Items[i].SubItems.Add(data.Thanhtien1.ToString());


                    i++;

                }
            }
        }
        public void Load_Item_HD_Moi()
        {
            listView_XemCTHD_Moi.Items.Clear();
            listView_XemCTHD_Moi.View = View.Details;
            listView_XemCTHD_Moi.Columns.Add("IDCTHD", 80);
            listView_XemCTHD_Moi.Columns.Add("Tên món ăn", 150);
            listView_XemCTHD_Moi.Columns.Add("Số lượng");
            listView_XemCTHD_Moi.Columns.Add("Đơn giá", 80);
            listView_XemCTHD_Moi.Columns.Add("Thành tiền", 80);
            listView_XemCTHD_Moi.GridLines = true;
            listView_XemCTHD_Moi.FullRowSelect = true;

        }
        private void TachBan_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            LoadKhuVuc();
            label_idban_cu.Text = idban;
            ///hien thị hóa đơn cũ
            listView_XemCTHD_Cu.Items.Clear();
            listView_XemCTHD_Cu.View = View.Details;
            listView_XemCTHD_Cu.Columns.Add("IDCTHD", 80);
            listView_XemCTHD_Cu.Columns.Add("Tên món ăn", 150);
            listView_XemCTHD_Cu.Columns.Add("Số lượng");
            listView_XemCTHD_Cu.Columns.Add("Đơn giá", 80);
            listView_XemCTHD_Cu.Columns.Add("Thành tiền", 80);
            listView_XemCTHD_Cu.GridLines = true;

            listView_XemCTHD_Cu.FullRowSelect = true;
            load_XemCTHD_Cu();
            Load_Item_HD_Moi();
            //hiển thị idhd cũ:
            label_IDHD_Cu.Text = idhd;

        }

        private void listView_XemCTHD_Cu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (label_IDHD_Moi.Text == "...") { MessageBox.Show("Bạn chưa chọn bàn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            else
            {
                TachMon();
            }
           
        }
        public void TachMon()
        {
            bool delete = false,insert=false;
            List<XemCTHoaDon> xemCTHoaDons = XemCTHoaDonDAO.Instance.Get_XemCTHoaDons(idhd);
            if (idhd_moi != null)
                foreach (XemCTHoaDon data in xemCTHoaDons)
                {
                    for (int i = 0; i < listView_XemCTHD_Cu.SelectedItems.Count; i++)
                    {

                        if (data.IDCTHoaDon1 == listView_XemCTHD_Cu.SelectedItems[i].SubItems[0].Text)
                        {
                            string idmon = CTHoaDonDAO.Instance.Get_ID_Mon(data.IDCTHoaDon1).ToString();
                            delete = CTHoaDonDAO.Instance.Delete_Mon_Trong_CTHD(data.IDCTHoaDon1.ToString());
                            if (!delete) MessageBox.Show("Không thể tách!");
                            insert = CTHoaDonDAO.Instance.Insert_CTHoaDon(idmon,"1", idhd_moi);
                            if (!insert) MessageBox.Show("Không thể tách!");
                            listView_XemCTHD_Moi.Items.Clear();
                            load_XemCTHD_Moi(label_idban_moi.Text);
                            listView_XemCTHD_Cu.Items.Clear();
                            load_XemCTHD_Cu();
                         
                        }
                    }
                }
            else
            {
                bool tt = true;
                try
                {
                    tt = HoaDonDAO.Instance.Insert_HoaDon(label_idban_moi.Text, "NV001");
                    idhd_moi = HoaDonDAO.Instance.GET_IDHD(label_idban_moi.Text);

                    foreach (XemCTHoaDon data in xemCTHoaDons)
                    {
                        for (int i = 0; i < listView_XemCTHD_Cu.SelectedItems.Count; i++)
                        {

                            if (data.IDCTHoaDon1 == listView_XemCTHD_Cu.SelectedItems[i].SubItems[0].Text)
                            {
                                string idmon = CTHoaDonDAO.Instance.Get_ID_Mon(data.IDCTHoaDon1).ToString();
                                delete = CTHoaDonDAO.Instance.Delete_Mon_Trong_CTHD(data.IDCTHoaDon1.ToString());
                                if (!delete) MessageBox.Show("Không thể tách!");
                                insert = CTHoaDonDAO.Instance.Insert_CTHoaDon(idmon, "1", idhd_moi);
                                if (!insert) MessageBox.Show("Không thể tách!");
                                listView_XemCTHD_Moi.Items.Clear();
                                load_XemCTHD_Moi(label_idban_moi.Text);
                                listView_XemCTHD_Cu.Items.Clear();
                                load_XemCTHD_Cu();
                            }
                        }
                    }

                }
                catch (Exception) { }


            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool t = false;
            if (label_idban_moi.Text != "...")
            {
                if (idhd_moi != null)
                {
                   
                    t = CTHoaDonDAO.Instance.ChuyenBan(idhd_moi, idhd);
                    listView_XemCTHD_Moi.Items.Clear();
                    load_XemCTHD_Moi(label_idban_moi.Text);
                    listView_XemCTHD_Cu.Items.Clear();
                    load_XemCTHD_Cu();
                    label_IDHD_Cu.Text = "...";
                }
                else
                {
                    bool tt = true;
                    tt = HoaDonDAO.Instance.Insert_HoaDon(label_idban_moi.Text, "NV01");
                    idhd_moi = HoaDonDAO.Instance.GET_IDHD(label_idban_moi.Text);
                    t = CTHoaDonDAO.Instance.ChuyenBan(idhd_moi, idhd);
                    label_IDHD_Cu.Text = "...";
                    listView_XemCTHD_Moi.Items.Clear();
                    load_XemCTHD_Moi(label_idban_moi.Text);
                    listView_XemCTHD_Cu.Items.Clear();
                    load_XemCTHD_Cu();
                }
            }
            else
            {
                MessageBox.Show("Chọn bàn trước khi chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            CTBanHang cTBanHang = new CTBanHang(idban);
            this.Hide();
            cTBanHang.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
