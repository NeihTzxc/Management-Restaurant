using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class ThongTinNhanVien:NhanVien
    {
        private string HoVaTen;
        private string ChucVu;

        public string HoVaTen1 { get => HoVaTen; set => HoVaTen = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public ThongTinNhanVien(string HoVaTen, string ChucVu)
        {
            this.HoVaTen1 = HoVaTen;
            this.ChucVu1 = ChucVu;
        }
        public ThongTinNhanVien(DataRow data)
        {
            IDNhanVien1 = data["IDNhanVien"].ToString();
            this.HoVaTen1 = data["HoVaTen"].ToString();
            SoDT1 = data["SoDT"].ToString();
            DiaChi1 = data["DiaChi"].ToString();
            this.ChucVu = data["TenChucVu"].ToString();
            
        }
    }
}
