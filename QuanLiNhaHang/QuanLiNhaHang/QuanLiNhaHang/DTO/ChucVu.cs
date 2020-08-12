using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class ChucVu
    {
        public ChucVu(string IDChucvu, string TenChucVu, string IDLuong,float HeSoLuong)
        {
            this.IDChucVu1 = IDChucVu;
            this.TenChucVu = TenChucVu;
            this.IDLuong1 = this.IDLuong;
            this.HeSoLuong1 = HeSoLuong;
        }
        public ChucVu(DataRow data)
        {
            this.IDChucVu1 = data["IDChucVu"].ToString();
            this.TenChucVu = data["TenChucVu"].ToString();
            this.IDLuong1 = data["IDLuong"].ToString();
            this.HeSoLuong1 = (float)Convert.ToDouble(data["HeSoLuong"].ToString());
        }
        private string IDChucVu;
        private string TenChucVu;
        private string IDLuong;
        private float HeSoLuong;

        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
        public string TenChucVu1 { get => TenChucVu; set => TenChucVu = value; }
        public string IDLuong1 { get => IDLuong; set => IDLuong = value; }
        public float HeSoLuong1 { get => HeSoLuong; set => HeSoLuong = value; }
    }
}
