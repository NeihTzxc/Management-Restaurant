using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class KetQuaTinhHoaDon
    { 
       public KetQuaTinhHoaDon(string IDBan, string IDHoaDon, string NgayLapHD,string TenNhanVien, decimal TongTien,string GioRa)
        {
            this.IDBan1 = IDBan;
            this.IDHoaDon1 = IDHoaDon;
            this.TenNhanVien1 = TenNhanVien;
            this.NgayLapHD1 = NgayLapHD;
            this.TongTien1 = TongTien;
            this.GioRa1 = GioRa;
        }
        public KetQuaTinhHoaDon(DataRow data)
        {
            this.IDBan1 = data["IDBan"].ToString();
            this.IDHoaDon1 = data["IDHoaDon"].ToString();
            this.TenNhanVien1 = data["TenNhanVien"].ToString();
            this.NgayLapHD1 = data["NgayLapHoaDon"].ToString();
            this.TongTien1 = (decimal)data["TongTien"];
            this.GioRa1 = data["GioRa"].ToString();
        }
        private string IDBan;
        private string IDHoaDon;
        private string NgayLapHD;
        private string TenNhanVien;
        private decimal TongTien;
        string GioRa;

        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public string IDHoaDon1 { get => IDHoaDon; set => IDHoaDon = value; }
        public string NgayLapHD1 { get => NgayLapHD; set => NgayLapHD = value; }
        public string TenNhanVien1 { get => TenNhanVien; set => TenNhanVien = value; }
        public decimal TongTien1 { get => TongTien; set => TongTien = value; }
        public string GioRa1 { get => GioRa; set => GioRa = value; }
    }
}
