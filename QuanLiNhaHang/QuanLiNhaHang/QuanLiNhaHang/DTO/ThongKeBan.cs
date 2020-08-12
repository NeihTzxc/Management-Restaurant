using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class ThongKeBan
    {
        public ThongKeBan(string IDBan,int SoLuong)
        {
            this.IDBan1 = IDBan;
            this.SoLuong1 = SoLuong;
        }
        public ThongKeBan(DataRow data)
        {
            this.IDBan1 = data["IDBan"].ToString();
            this.SoLuong1 = (int)data["SoLuong"];
        }
        private string IDBan;
        private int SoLuong;

        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public int SoLuong1 { get => SoLuong; set => SoLuong = value; }
    }
}
