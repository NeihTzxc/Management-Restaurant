using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class Mon
    {
        public Mon(string IDMon, string TenMon, decimal DonGia)
        {
            this.IDMon1 = IDMon;
            this.TenMon1 = TenMon;
            this.DonGia1 = DonGia;
        }
        public Mon(DataRow data)
        {
            this.IDMon1 = data["IDMonAn"].ToString();
            this.TenMon1 = data["TenMonAn"].ToString();
            this.DonGia1 = (decimal)data["DonGia"];
        }
        private string IDMon;
        private string TenMon;
        private decimal DonGia;

        public string IDMon1 { get => IDMon; set => IDMon = value; }
        public string TenMon1 { get => TenMon; set => TenMon = value; }
        public decimal DonGia1 { get => DonGia; set => DonGia = value; }
    }
}
