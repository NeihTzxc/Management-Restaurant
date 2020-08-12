using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class NhanVien
    {
        public NhanVien(string IDNhanVien, string SoDT, string DiaChi, DateTime NamSinh, string Ho, string Ten, string IDChucVu)
        {
            this.IDNhanVien1 = IDNhanVien;
            this.SoDT1 = SoDT;
            this.DiaChi1 = DiaChi;
            this.NamSinh1 = NamSinh;
            this.Ho1 = Ho;
            this.Ten1 = Ten;
            this.IDChucVu1 = IDChucVu;
      
        }
        public NhanVien() { }
        public NhanVien(DataRow data)
        {
            this.IDNhanVien1 = data["IDNhanVien"].ToString();
            this.SoDT1 = data["soDT"].ToString();
            this.DiaChi1 = data["DiaChi"].ToString();
            this.NamSinh1 = (DateTime)data["NamSinh"];
            this.Ho1 = data["Ho"].ToString();
            this.Ten1 = data["Ten"].ToString();
            this.IDChucVu1 = data["IDChucVu"].ToString();
        }
        private string IDNhanVien;
        private string SoDT;
        private string DiaChi;
        private DateTime NamSinh;
        private string Ho;
        private string Ten;
        private string IDChucVu;
  

        public string IDNhanVien1 { get => IDNhanVien; set => IDNhanVien = value; }
        public string SoDT1 { get => SoDT; set => SoDT = value; }
        public string DiaChi1 { get => DiaChi; set => DiaChi = value; }
        public DateTime NamSinh1 { get => NamSinh; set => NamSinh = value; }
        public string Ho1 { get => Ho; set => Ho = value; }
        public string Ten1 { get => Ten; set => Ten = value; }
        public string IDChucVu1 { get => IDChucVu; set => IDChucVu = value; }
    
    }
}
