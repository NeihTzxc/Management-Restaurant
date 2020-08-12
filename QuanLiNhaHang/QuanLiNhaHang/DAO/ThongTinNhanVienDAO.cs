using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class ThongTinNhanVienDAO
    {
        private static ThongTinNhanVienDAO instance;

        public static ThongTinNhanVienDAO Instance
        {
            get { if (instance == null) instance = new ThongTinNhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private ThongTinNhanVienDAO() { }
        public List<ThongTinNhanVien> getsTT()
        {
            List<ThongTinNhanVien> thongTins = new List<ThongTinNhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select IDNhanVien,HO+' '+TEN as HoVaTen,SODT,DiaChi,CHUCVU.TenchucVu " 
                    +" from NHANVIEN, CHUCVU where NHANVIEN.IDChucvu = CHUCVU.IDChucVu");
            foreach(DataRow item in data.Rows)
            {
                ThongTinNhanVien thongTinNhanVien = new ThongTinNhanVien(item);
                thongTins.Add(thongTinNhanVien);
            }
            return thongTins;
        }
    }
}
