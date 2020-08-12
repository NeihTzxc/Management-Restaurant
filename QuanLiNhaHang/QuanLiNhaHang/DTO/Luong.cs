using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class Luong
    {
        public Luong(string IDLuong, decimal LuongNgayCong)
        {
            this.IDLuong1 = IDLuong;
            this.LuongNgayCong1 = LuongNgayCong;
        }
        public Luong(DataRow data)
        {
            this.IDLuong1 = data["IDLuong"].ToString();
            this.LuongNgayCong1 = (decimal)data["LuongNgayCong"];
        }
        private string IDLuong;
        private decimal LuongNgayCong;

        public string IDLuong1 { get => IDLuong; set => IDLuong = value; }
        public decimal LuongNgayCong1 { get => LuongNgayCong; set => LuongNgayCong = value; }
    }
}
