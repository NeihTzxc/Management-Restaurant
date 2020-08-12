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
    public partial class CTBanHang : Form
    {
       
        public string idban,idhd,idcthd;
        public CTBanHang()
        {
            InitializeComponent();
        }
        public CTBanHang(string idban)
        {

            this.idban = idban;
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public  void loadMon()
        {
            List<Mon> mons = MonDAO.Instance.GetMon();
            int i = 0;
            foreach (Mon data in mons)
            {
                //   listView_mon.Items.Add(data["IDMonan"].ToString());
                listView_mon.Items.Add(data.TenMon1);
                listView_mon.Items[i].SubItems.Add(data.DonGia1.ToString());
                i++;
            }
        }
        public void loadXemCTHoaDon()
        {
            idhd = HoaDonDAO.Instance.GET_IDHD(idban);
           
            List<XemCTHoaDon> xemCThoaDons =XemCTHoaDonDAO.Instance.Get_XemCTHoaDons(idhd);
            if (xemCThoaDons != null)
            {
                int i = 0;

                foreach (XemCTHoaDon data in xemCThoaDons)
                {

                    listView_HoaDon.Items.Add(data.IDCTHoaDon1.ToString());
                    listView_HoaDon.Items[i].SubItems.Add(data.TenMonAn1.ToString());
                    listView_HoaDon.Items[i].SubItems.Add(data.SoLuong1.ToString());
                    listView_HoaDon.Items[i].SubItems.Add(data.DonGia1.ToString());
                    listView_HoaDon.Items[i].SubItems.Add(data.Thanhtien1.ToString());


                    i++;

                }
                List<KetQuaTinhHoaDon> ketQuaTinhHoaDons = KetQuaTinhHoaDonDAO.Instance.GetKetQuaTinhHoaDons(idhd);
                foreach (KetQuaTinhHoaDon kq in ketQuaTinhHoaDons)
                {
                    label_TongTien.Text = kq.TongTien1.ToString() + " Đồng";
                }
            }
            
        }
        public DateTime dateTime = DateTime.Now;
        public void LoadKetQuaTinhHoaDon()
        {
            try
            {
                List<KetQuaTinhHoaDon> ketQuaTinhHoaDons = KetQuaTinhHoaDonDAO.Instance.GetKetQuaTinhHoaDons(idhd);
                foreach (KetQuaTinhHoaDon data in ketQuaTinhHoaDons)
                {
                    label_NV.Text = data.TenNhanVien1.ToString();
                    //    label_Ngay.Text = data.NgayLapHD1.ToString();
                    label_Gio.Text = data.NgayLapHD1.ToString();
                    label_GiamGia.Text = "Không";
                    label_TongTien.Text = data.TongTien1.ToString() + " Đồng";
                    label_IDHD.Text = data.IDHoaDon1;
                  
                    //   idhd = data.IDHoaDon1;
                }
            }

            catch (Exception) { }
           
        }
        public void load_NhanVien()
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();
            int i = 0;
            foreach(NhanVien data in nhanViens)
            {
                listView_NhanVien.Items.Add(data.IDNhanVien1.ToString());
                listView_NhanVien.Items[i].SubItems.Add(data.Ho1 + " " + data.Ten1);
                i++;
            }
        }
        private void CTBanHang_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            label_idban.Text= this.idban;
            listView_mon.Items.Clear();

            listView_mon.View = View.Details;
     //       listView_mon.Columns.Add("ID món ăn");
            listView_mon.Columns.Add("Tên món ăn",120);
            listView_mon.Columns.Add("Đơn giá");
            listView_mon.GridLines = true;

            listView_mon.FullRowSelect = true;
            loadMon();
            // hiển thị hóa đơn
            listView_HoaDon.Items.Clear();
            listView_HoaDon.View = View.Details;
            listView_HoaDon.Columns.Add("IDCTHD",80);
            listView_HoaDon.Columns.Add("Tên món ăn", 150);
            listView_HoaDon.Columns.Add("Số lượng");
            listView_HoaDon.Columns.Add("Đơn giá",80);
            listView_HoaDon.Columns.Add("Thành tiền",80);
            listView_HoaDon.GridLines = true;

            listView_HoaDon.FullRowSelect = true;
            loadXemCTHoaDon();

            LoadKetQuaTinhHoaDon();//tính hóa đơn
            //hiển thị nhân viên
            listView_NhanVien.Items.Clear();
            listView_NhanVien.View = View.Details;
            listView_NhanVien.Columns.Add("ID Nhân viên", 0);
            listView_NhanVien.Columns.Add("Tên Nhân viên", 150);
            listView_NhanVien.GridLines = true;
            listView_NhanVien.FullRowSelect = true;
            load_NhanVien();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BanHang form1 = new BanHang();
            this.Hide();
            form1.Show();
        }

        private void listView_mon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
          
            
        }

        private void listView_HoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button_XoaMon_Click(object sender, EventArgs e)
        {
            bool t = false;
            List<CTHoaDon> cthd = CTHoaDonDAO.Instance.GetCTHoaDons(idhd);
           
                foreach (CTHoaDon cTHoaDon in cthd)
                {
                    for (int i = 0; i < listView_HoaDon.SelectedItems.Count; i++)
                    {

                        t = CTHoaDonDAO.Instance.Delete_Mon_Trong_CTHD(listView_HoaDon.SelectedItems[i].SubItems[0].Text);
                        listView_HoaDon.Items.Clear();
                        loadXemCTHoaDon();
                    }
                }
            
        }

        private void listView_HoaDon_KeyDown(object sender, KeyEventArgs e)
        {

            bool t = false;
            List<CTHoaDon> cthd = CTHoaDonDAO.Instance.GetCTHoaDons(idhd);
            if (e.KeyCode == Keys.Delete)
            {
                foreach (CTHoaDon cTHoaDon in cthd)
                {
                    for (int i = 0; i < listView_HoaDon.SelectedItems.Count; i++)
                    {                       
                          
                        t = CTHoaDonDAO.Instance.Delete_CTHoaDon(listView_HoaDon.SelectedItems[i].SubItems[0].Text);
                            listView_HoaDon.Items.Clear();
                            loadXemCTHoaDon();                      
                    }
                }
            }
        }
        private void label_Ngay_Click(object sender, EventArgs e)
        {

        }
        public void ThemMonVaoHD()
        {
           
            bool t = false;
            List<Mon> mons = MonDAO.Instance.GetMon();
            if(idhd!=null)
            foreach (Mon data in mons)
            {
                for (int i = 0; i < listView_mon.SelectedItems.Count; i++)
                {
             
                    if (data.TenMon1.ToString() ==listView_mon.SelectedItems[i].SubItems[0].Text)
                    {
                        
                        t = CTHoaDonDAO.Instance.Insert_CTHoaDon(data.IDMon1.ToString(), "1", idhd);
                        if (t == false) MessageBox.Show("Không thể thêm món");
                        listView_HoaDon.Items.Clear();
                        loadXemCTHoaDon();
                        LoadKetQuaTinhHoaDon();
                      
                    }
                }
            }
            else
            {
                bool tt = true;
                try
                {
                    tt = HoaDonDAO.Instance.Insert_HoaDon(idban, "NV001");

                    idhd = HoaDonDAO.Instance.GET_IDHD(idban);

                    foreach (Mon data in mons)
                    {
                        for (int i = 0; i < listView_mon.SelectedItems.Count; i++)
                        {

                            if (data.TenMon1.ToString() == listView_mon.SelectedItems[i].SubItems[0].Text)
                            {

                                t = CTHoaDonDAO.Instance.Insert_CTHoaDon(data.IDMon1, "1", idhd);
                                if (t == false) MessageBox.Show("Không thể thêm món");
                                listView_HoaDon.Items.Clear();

                                loadXemCTHoaDon();
                                LoadKetQuaTinhHoaDon();

                            }
                        }
                    }
                }
                catch (Exception) { }
              

            }
          
          
        }
        public void UPDATENhanVienVao_HD()
        {
           
            if (idhd != null)
            {
               
                List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();

                foreach (NhanVien data in nhanViens)
                {
                    for (int i = 0; i < listView_NhanVien.SelectedItems.Count; i++)
                    {

                        if (data.IDNhanVien1 == listView_NhanVien.SelectedItems[i].SubItems[0].Text)
                        {
                           
                            HoaDonDAO.Instance.Updata_NV_HD(data.IDNhanVien1, idhd);

                            LoadKetQuaTinhHoaDon();
                        }
                    }
                }
            }
               
            else
            {
              
                try
                {
                    List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();
                    foreach(NhanVien data_NVien in nhanViens)
                    {
                        for(int i = 0; i < listView_NhanVien.SelectedItems.Count; i++)
                        {
                            if (data_NVien.IDNhanVien1 == listView_NhanVien.SelectedItems[i].SubItems[0].Text)
                            {
                                HoaDonDAO.Instance.Insert_HoaDon(idban, data_NVien.IDNhanVien1);
                                label_NV.Text = data_NVien.Ho1 + " " + data_NVien.Ten1;

                            }
                        }
                    }
                
                    idhd = HoaDonDAO.Instance.GET_IDHD(idban);                                     
                    label_IDHD.Text = idhd;
                }
                catch (Exception) { }


            }
            
        }
        
        private void listView_mon_KeyDown(object sender, KeyEventArgs e)
        {
           
            
            
        }

        private void listView_mon_Click(object sender, EventArgs e)
        {
            
        }

        private void listView_NhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            UPDATENhanVienVao_HD();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TachBan tachBan = new TachBan(idban);
            this.Hide();
            tachBan.Show();

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_mon_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ThemMonVaoHD();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (ThanhToanDAO.Instance.thanhtoan(idhd) != 0)
                {

                    XuaHD xuaHD = new XuaHD(idhd);
                    xuaHD.Show();

                    listView_HoaDon.Items.Clear();
                    label_NV.Text = "";
                    label_Gio.Text = "";
                    label_TongTien.Text = "";
                    label_GiamGia.Text = "";
                    label_IDHD.Text = "";
                    idhd = null;
                    MessageBox.Show("Đã thanh toán:", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Bàn trông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
         



        }
    }
}
