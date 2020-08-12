using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class ThongKeMon
    {
        public ThongKeMon(string TenMon, int SoLuong)
        {
            this.TenMon1 = TenMon;
            this.SoLuong1 = SoLuong;
        }
        public ThongKeMon(DataRow data)
        {
            this.TenMon1 = data["TenMonAn"].ToString();
            this.SoLuong1 = (int)data["SoLuong"];
        }
        private string TenMon;
        private int SoLuong;

        public string TenMon1 { get => TenMon; set => TenMon = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
