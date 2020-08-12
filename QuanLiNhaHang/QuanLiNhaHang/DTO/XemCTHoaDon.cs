using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class XemCTHoaDon
    {
        public XemCTHoaDon(string IDCTHoaDon,string IDMonAn,string TenMonAn,int SoLuong, decimal DonGia, decimal ThanhTien,string IDHoaDon)
        {
            this.IDCTHoaDon1 = IDCTHoaDon;
            this.IDMonAn1 = IDMonAn;
            this.TenMonAn1 = TenMonAn;
            this.SoLuong1 = SoLuong;
            this.DonGia1 = DonGia;
            this.Thanhtien1 = Thanhtien;
            this.IDHoaDon1 = IDHoaDon;

        }
        public XemCTHoaDon(DataRow data)
        {
            this.IDHoaDon1 = data["IDHoaDon"].ToString();
            this.IDCTHoaDon1 = data["IDCTHoaDon"].ToString();
            this.IDMonAn1 = data["IDMonAn"].ToString();
            this.TenMonAn1 = data["TenMonAn"].ToString();
            this.SoLuong1 = (int)data["SoLuong"];
            this.DonGia1 = (decimal)data["DonGia"];
            this.Thanhtien1 =(decimal)data["Tien"];
        }
        private string IDHoaDon;
        private string IDCTHoaDon;
        private string IDMonAn;
        private string TenMonAn;
        private int SoLuong;
        private decimal DonGia;
        private decimal Thanhtien;

        public string IDCTHoaDon1 { get => IDCTHoaDon; set => IDCTHoaDon = value; }
        public string IDMonAn1 { get => IDMonAn; set => IDMonAn = value; }
        public string TenMonAn1 { get => TenMonAn; set => TenMonAn = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public decimal DonGia1 { get => DonGia; set => DonGia = value; }
        public decimal Thanhtien1 { get => Thanhtien; set => Thanhtien = value; }
        public string IDHoaDon1 { get => IDHoaDon; set => IDHoaDon= value; }
    }
}
