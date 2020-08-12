using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class TaiKhoanQT
    {
        public TaiKhoanQT(string TenTaiKhoan,string IDTaiKhoan, string MatKhau = null)
        {
            this.TenTaiKhoan1 = TenTaiKhoan;
            this.IDTaiKhoan1 = IDTaiKhoan;
            this.MatKhau1 = MatKhau;
        }

        public TaiKhoanQT(DataRow row)
        {
            this.IDTaiKhoan1 = row["IDTaiKhoan"].ToString();
            this.TenTaiKhoan1 = row["TenTaiKhoan"].ToString();
            this.MatKhau1 = row["MatKhau"].ToString();
        }
        private  string IDTaiKhoan;
        private string TenTaiKhoan;
        private string MatKhau;

        public string IDTaiKhoan1 { get => IDTaiKhoan; set => IDTaiKhoan = value; }
        public string TenTaiKhoan1 { get => TenTaiKhoan; set => TenTaiKhoan = value; }
        public string MatKhau1 { get => MatKhau; set => MatKhau = value; }
    }
}

