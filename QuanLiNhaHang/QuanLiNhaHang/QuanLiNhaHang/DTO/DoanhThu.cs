using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class DoanhThu
    {
        public DoanhThu(string Thang, decimal TongTien)
        {

        }
        public DoanhThu(DataRow data)
        {
            this.Thang1 = data["Thang"].ToString();
            this.TongTien1 = (decimal)data["DoanhThu"];
        }
        string Thang;
        private decimal TongTien;

        public string Thang1 { get => Thang; set => Thang = value; }
        
        public decimal TongTien1 { get => TongTien; set => TongTien = value; }
    }
}
