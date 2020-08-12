using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class HoaDon
    {
        public HoaDon()
        {

        }
        public HoaDon(string IDHoaDon, string IDNhanVien, string IDBan, string NgayLapHD, string TinhTrangHD)
        {
            this.IDHoaDon1 = IDHoaDon;
            this.IDNhanVien1 = IDNhanVien;
            this.IDBan1 = IDBan;
            this.NgayLapHD1 = NgayLapHD;
            this.TinhTrangHD1 = TinhTrangHD;
        }
        public HoaDon(DataRow data)
        {
            this.IDHoaDon1 = data["IDHoaDon"].ToString();
            this.IDNhanVien1 = data["IDNhanVien"].ToString();
            this.IDBan1 = data["IDBan"].ToString();
            this.NgayLapHD1 = data["NgayLapHD"].ToString();
            this.TinhTrangHD1 = data["TinhTrangHD"].ToString();
        }
        private string IDHoaDon;
        private string IDNhanVien;
        private string IDBan;
        private string NgayLapHD;
        private string TinhTrangHD;

        public string IDHoaDon1 { get => IDHoaDon; set => IDHoaDon = value; }
        public string IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public string NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public string TinhTrangHD1 { get => TinhTrangHD; set => TinhTrangHD = value; }
    }
}
