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
    public partial class DanhMuc_ChucVu : Form
    {
        public DanhMuc_ChucVu()
        {
            InitializeComponent();
        }

    
        public void loadLuong()
        {
            List<Luong> luongs = LuongDAO.Instance.GetLuongs();
            int i = 0;
            foreach (Luong luong in luongs)
            {
                listView_luong.Items.Add(luong.IDLuong1);
                listView_luong.Items[i].SubItems.Add(luong.LuongNgayCong1.ToString());
                i++;
            }
        }
        public void load_items_luong()
        {
            listView_luong.Items.Clear();

            listView_luong.View = View.Details;
            listView_luong.Columns.Add("ID Lương", 80);
            listView_luong.Columns.Add("Lương ngày công", 100);

            listView_luong.GridLines = true;
            listView_luong.FullRowSelect = true;
        }
        public void loadChucVu()
        {
            List<ChucVu> chucVus = ChucVuDAO.Instance.GetChucVus();
            int i = 0;
            foreach (ChucVu data in chucVus)
            {
                listView_cv.Items.Add(data.IDChucVu1);
                listView_cv.Items[i].SubItems.Add(data.TenChucVu1);
                listView_cv.Items[i].SubItems.Add(data.IDLuong1);
                listView_cv.Items[i].SubItems.Add(data.HeSoLuong1.ToString());
                i++;
            }
        }
        public void load_item_CV()
        {
            listView_cv.Items.Clear();

            listView_cv.View = View.Details;
            listView_cv.Columns.Add("ID Chức vụ", 80);
            listView_cv.Columns.Add("Tên chức vụ", 80);

            listView_cv.Columns.Add("ID Lương", 80);
            listView_cv.Columns.Add("Hệ số lương", 80);
            listView_cv.GridLines = true;
            listView_cv.FullRowSelect = true;
        }
        public void Delete_luong()
        {
            bool t = false;
            List<Luong> luongs = LuongDAO.Instance.GetLuongs();
            foreach (Luong data in luongs)
            {
                for (int i = 0; i < listView_luong.SelectedItems.Count; i++)
                {
                    if (data.IDLuong1 == listView_luong.SelectedItems[i].SubItems[0].Text)
                    {
                        try
                        {
                            t = LuongDAO.Instance.Delete_Luong(data.IDLuong1);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa" + "\n" + "Dữ liệu này đã tồn tại trong bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            if (!t)
            {
                MessageBox.Show("Xóa không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          
            listView_luong.Items.Clear();
            loadLuong();
        }
        
        void load_cb_chucvu()
        {
            List<ChucVu> chucVucs = ChucVuDAO.Instance.GetChucVus();
            foreach(ChucVu data in chucVucs)
            {
                cb_CV.Items.Add(data.TenChucVu1);
            }
        }
        public void Insert_ChucVu()
        {
            bool t = false;
            if (tb_TenCV != null && tb_HSL.Text != null && idluong != null)
            {
                try
                {
                    t = ChucVuDAO.Instance.Insert_ChucVu(tb_TenCV.Text, tb_HSL.Text.ToString(), idluong);
                    if(t)
                       MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   


                    listView_cv.Items.Clear();
                    loadChucVu();
                }
                catch (Exception)
                {

                }
            }


        }
        public void load_item_NhanVien()
        {
            listView_nv.View = View.Details;
            listView_nv.Columns.Add("ID Nhân Viên",0);
            listView_nv.Columns.Add("Tên Nhân Viên", 110);
            listView_nv.Columns.Add(" Số điện thoại", 80);
            listView_nv.Columns.Add("Địa chỉ", 150);
            listView_nv.Columns.Add("Chức vụ", 80);
            listView_nv.GridLines = true;
            listView_nv.FullRowSelect = true;
        }
        public void loadNhanVien()
        {
            List<ThongTinNhanVien> thongTins = ThongTinNhanVienDAO.Instance.getsTT();
            int i = 0;
            foreach(ThongTinNhanVien data in thongTins)
            {
                listView_nv.Items.Add(data.IDNhanVien1);
              
                listView_nv.Items[i].SubItems.Add(data.HoVaTen1);
                listView_nv.Items[i].SubItems.Add(data.SoDT1);
                listView_nv.Items[i].SubItems.Add(data.DiaChi1);
                listView_nv.Items[i].SubItems.Add(data.ChucVu1);
                i++;
            }        
        }
        private void DanhMuc_ChucVu_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            load_items_luong();
            loadLuong();
            Load_IDLuong();
            load_item_CV();
            loadChucVu();
            load_item_NhanVien();
            loadNhanVien();
            load_cb_chucvu();

        }
        string idchuvu = null;
        public bool Insert_NhanVien()
        {
            bool t = false;
                t = NhanVienDAO.Instance.Insert_NV(tb_SDT.Text, tb_DiaChi.Text, tb_NSinh.Text, tb_Ho.Text, tb_Ten.Text, idchuvu);
                if (!t)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
                }
                else
                {
                    listView_nv.Items.Clear();
                    loadNhanVien();
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
                }

            
          
        }

        public void Load_IDLuong()
        {
            List<Luong> luongs = LuongDAO.Instance.GetLuongs();
            foreach (Luong luong in luongs)
            {
                comboBox_IDL.Items.Add(luong.IDLuong1);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView_cv_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_luong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
        string idluong = null;
        private void comboBox_IDL_SelectedIndexChanged(object sender, EventArgs e)
        {
            idluong = comboBox_IDL.SelectedItem.ToString();
        }

        private void Them_Click_1(object sender, EventArgs e)
        {
            if (Them.Text == "Thêm")
            {
                Insert_ChucVu();
               
            }
            if (Them.Text == "Sửa")
            {
                Sua_CV();
                listView_nv.Items.Clear();
                loadNhanVien();
            }
            
        }
        public void Them_Luong()
        {
            bool t = false;
            try
            {
                t = LuongDAO.Instance.Insert_Luong(textBox_luong.Text);
                if (!t)
                {
                    MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                listView_luong.Items.Clear();
                loadLuong();

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        void Sua()
        {
            bool t = false;
            try
            {
                t = LuongDAO.Instance.Update_Luong(Lv_IDLuong, textBox_luong.Text);            
                listView_luong.Items.Clear();
                loadLuong();
            }
            catch (Exception)
            {
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "Thêm")
            {
                Them_Luong();
            }
            if (button2.Text == "Sửa")
            {
                Sua();
                listView_nv.Items.Clear();
                loadNhanVien();
            }
        }

        private void comboBox_IDL_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            idluong = comboBox_IDL.SelectedItem.ToString();
        }
        string IDChucVu = null;
        private void listView_cv_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            List<ChucVu> list = ChucVuDAO.Instance.GetChucVus();
            foreach(ChucVu data in list)
            {
                for(int i = 0; i < listView_cv.SelectedItems.Count; i++)
                {
                    if (data.IDChucVu1== listView_cv.SelectedItems[i].SubItems[0].Text)
                    {
                        IDChucVu = data.IDChucVu1;
                        tb_TenCV.Text = listView_cv.SelectedItems[i].SubItems[1].Text;
                        tb_HSL.Text = listView_cv.SelectedItems[i].SubItems[3].Text;
                        comboBox_IDL.Text = listView_cv.SelectedItems[i].SubItems[2].Text;
                    }
                }
            }
        }
        void XoaChuVu()
        {
            bool t = false;
            List<ChucVu> chucVus = ChucVuDAO.Instance.GetChucVus();
            foreach (ChucVu data in chucVus)
            {
                for (int i = 0; i < listView_cv.SelectedItems.Count; i++)
                {
                    if (data.IDChucVu1 == listView_cv.SelectedItems[i].SubItems[0].Text)
                    {
                        try
                        {
                            t = ChucVuDAO.Instance.Delete_ChucVu(data.IDChucVu1);
                            if (!t)
                            {
                                MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                listView_cv.Items.Clear();
                                loadChucVu();
                                cb_CV.Items.Clear();
                                load_cb_chucvu();
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa" + "\n" + "Dữ liệu này đã tồn tại trong bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
        }
        private void listView_cv_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    XoaChuVu();
                    
                }
                else
                {

                }
            }
        }


        private void listView_luong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                DialogResult dialog = MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Nguy hiểm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialog == DialogResult.Yes)
                {
                    Delete_luong();

                }
                else
                {

                }
            }
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void listView_nv_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();
            foreach (NhanVien data in nhanViens)
            {
                for (int i = 0; i < listView_nv.SelectedItems.Count; i++)
                {
                    if (data.IDNhanVien1 == listView_nv.SelectedItems[i].SubItems[0].Text)
                    {
                        tb_Ho.Text = data.Ho1;
                        tb_Ten.Text = data.Ten1;
                        tb_NSinh.Text = data.NamSinh1.ToString("dd/MM/yyyy");
                        List<ChucVu> chucVus = ChucVuDAO.Instance.GetChucVus();
                        foreach(ChucVu chucvu in chucVus)
                        {
                            if (chucvu.IDChucVu1 == data.IDChucVu1)
                            {
                                cb_CV.Text = chucvu.TenChucVu1;
                            }
                        }
                        tb_DiaChi.Text = data.DiaChi1;
                        tb_SDT.Text = data.SoDT1;
                    }
                }
            }
        }
        public void Delete_NV()
        {
            List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();
            bool t = false;
            foreach(NhanVien data in nhanViens)
            {
                for (int i = 0; i < listView_nv.SelectedItems.Count; i++)
                {
                    if (data.IDNhanVien1 == listView_nv.SelectedItems[i].SubItems[0].Text)
                    {
                        try
                        {

                            t = NhanVienDAO.Instance.Delete_NV(data.IDNhanVien1);
                            if (!t)
                            {
                                MessageBox.Show("Không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Không thể xóa"+"\n"+"Dữ liệu này đã tồn tại trong bảng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

        }
        private void button_Xuat_Click(object sender, EventArgs e)
        {
            DialogResult dialog= MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Delete_NV();
                listView_nv.Items.Clear();
                loadNhanVien();
            }
            else
            {

            }
        }

        private void cb_CV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ten;
            ten = cb_CV.SelectedItem.ToString();
            List<ChucVu> chucVus = ChucVuDAO.Instance.GetChucVus();
            foreach(ChucVu data in chucVus)
            {
                if (data.TenChucVu1 == ten)
                {
                    idchuvu = data.IDChucVu1;
                }
            }
       
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            bool t = false;
            if (btn_Them.Text == "Thêm")
            {
                try
                {
                    t = Insert_NhanVien();
                }
                catch (Exception) { }
                if (t)
                {
                    tb_DiaChi.Text = null;
                    tb_Ho.Text = null;
                    tb_Ten.Text = null;
                    tb_NSinh.Text = null;
                    tb_SDT.Text = null;


                }
            }
            if (btn_Them.Text == "Sửa")
            {
                Edit_NV();
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            btn_Them.Text = "Thêm";
        }

        private void button_XoaMon_Click(object sender, EventArgs e)
        {
            btn_Them.Text = "Sửa";
            label_nv.Text = "Sửa nhân viên";
        }
        public  void Edit_NV()
        {
            bool t = false;
            List<NhanVien> nhanViens = NhanVienDAO.Instance.GetNhanViens();
            foreach(NhanVien data in nhanViens)
            {
                for(int i = 0; i < listView_nv.SelectedItems.Count; i++)
                {
                    if (data.IDNhanVien1 == listView_nv.SelectedItems[i].SubItems[0].Text)
                    {
                        try
                        {
                            t = NhanVienDAO.Instance.Edit_NV(data.IDNhanVien1, tb_SDT.Text, tb_DiaChi.Text, tb_NSinh.Text, tb_Ho.Text, tb_Ten.Text, idchuvu);
                            if (t)
                            {

                                listView_nv.Items.Clear();
                                loadNhanVien();
                                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                            else
                            {
                                MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
                            }
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sửa không thành công", "Thông báo", MessageBoxButtons.OK);
                        }
                       
                    }
                }
            }
            
        }

        private void btn_Xoa_CV_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                XoaChuVu();
                listView_nv.Items.Clear();
                loadNhanVien();
            }
            else
            {

            }
        }

        private void btn_Them_CV_Click(object sender, EventArgs e)
        {
            Them.Text = "Thêm";
           
        }
        public void Sua_CV()
        {
            try
            {
                ChucVuDAO.Instance.Update_CV(tb_TenCV.Text, tb_HSL.Text, idluong, IDChucVu);
                listView_cv.Items.Clear();
                loadChucVu();
            }
            catch (Exception)
            {

            }
           
        }
        private void btn_Sua_CV_Click(object sender, EventArgs e)
        {
            Them.Text = "Sửa";
        }
        string Lv_IDLuong = null;
        private void listView_luong_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<Luong> luongs = LuongDAO.Instance.GetLuongs();
            foreach(Luong data in luongs)
            {
                for(int i=0; i < listView_luong.SelectedItems.Count; i++)
                {
                    if (data.IDLuong1 == listView_luong.SelectedItems[i].SubItems[0].Text)
                    {
                        Lv_IDLuong = data.IDLuong1;
                        textBox_luong.Text = data.LuongNgayCong1.ToString();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button2.Text = "Thêm";

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button2.Text = "Sửa";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Nếu xóa bản này các thông tin liên quan trong bản khác cũng sẽ mất theo" + "\n" + "Bạn có chắc muốn xóa", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialog == DialogResult.Yes)
            {
                Delete_luong();
                listView_nv.Items.Clear();
                loadNhanVien();
            }
            else
            {

            }
        }
    }
}
