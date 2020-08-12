using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class LuongNV
    {
        public LuongNV(string IDChamCong,string IDNhanVien,  string Ten,string ChucVu, int SoCong, decimal Luong)
        {
            this.IDNhanVien1 = IDNhanVien;
            this.ChucVu1 = ChucVu;
            this.SoCong1 = SoCong;
            this.IDChamCong1 = IDChamCong;
            this.Ten1 = Ten;
            this.Luong1 = Luong;
            
        }
        public LuongNV() { }
        public LuongNV(DataRow data)
        {
            this.IDNhanVien1 = data["IDNhanVien"].ToString();
            this.ChucVu1 = data["TenChucvu"].ToString();
            this.IDChamCong1 = data["IDChamCong"].ToString();
            this.SoCong1 = (int)data["SoCong"];
            this.Ten1 = data["Ten"].ToString();
            this.Luong1 = (decimal)data["Luong"];
         
        }
        private string IDNhanVien;
    

        private string Ten;
        private decimal Luong;
        private string ChucVu;
        private string IDChamCong;
        private int SoCong;
        public string IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
       

        public string Ten1 { get => Ten; set => Ten = value; }
        public decimal Luong1 { get => Luong; set => Luong = value; }
        public string ChucVu1 { get => ChucVu; set => ChucVu = value; }
        public string IDChamCong1 { get => IDChamCong; set => IDChamCong = value; }
        public int SoCong1 { get => SoCong; set => SoCong = value; }
    }
}
