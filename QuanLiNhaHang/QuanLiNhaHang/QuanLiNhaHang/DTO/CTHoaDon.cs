using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class CTHoaDon
    {
        public CTHoaDon(string IDCTHoaDon, string IDMonAn, int SoLuong, string IDHoaDon)
        {
            this.IDCTHoaDon1 = IDCTHoaDon;
            this.IDMonAn1 = IDMonAn;
            this.SoLuong1 = SoLuong;
            this.IDHoaDon1 = IDHoaDon;
        }
        public CTHoaDon(DataRow data)
        {
            this.IDCTHoaDon1 = data["IDCTHoaDon"].ToString();
            this.IDMonAn1 = data["IDMonAn"].ToString();
            this.SoLuong1 = (int)data["SoLuong"];
            this.IDHoaDon1 = data["IDHoaDon"].ToString();
        }
        private string IDCTHoaDon;
        private string IDMonAn;
        private int SoLuong;
        private string IDHoaDon;

        public string IDCTHoaDon1 { get => IDCTHoaDon; set => IDCTHoaDon = value; }
        public string IDMonAn1 { get => IDMonAn; set => IDMonAn = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
        public string IDHoaDon1 { get => IDHoaDon; set => IDHoaDon = value; }
    }
}
