using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    class NhanVienDAO
    {
        
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        private NhanVienDAO()
        {

        }
        public List<NhanVien> GetNhanViens()
        {
            List<NhanVien> NhanVienList = new List<NhanVien>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from nhanvien");
            foreach (DataRow item in data.Rows)
            {
            NhanVien nhanVien = new NhanVien(item);
            NhanVienList.Add(nhanVien);
            }
            return NhanVienList;
        }
        public bool Delete_NV(string id)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("delete from nhanvien where idnhanvien = " + "'" + id + "'");
            if (i!=0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert_NV(string SoDT,string DiaChi,string NamSinh,string Ho,string Ten, string IDChucVu)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec Auto_Insert_NV @SoDT = '"+SoDT+"',"+"@DiaChi = N'"+DiaChi+"',"+"@NamSinh = '"+NamSinh+"',@Ho = N'"+Ho+"',@Ten = N'"+Ten+"', @IDChucVu = '"+IDChucVu+"'");

            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Edit_NV(string IDNhanVien, string SoDT, string DiaChi, string NamSinh, string Ho, string Ten, string IDChucVu)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec Edit_NV @IDNhanVien ='"+IDNhanVien+"'"+", @SoDT = '" + SoDT + "'," + "@DiaChi = N'" + DiaChi + "'," + "@NamSinh = '" + NamSinh + "',@Ho = N'" + Ho + "',@Ten = N'" + Ten + "', @IDChucVu = '" + IDChucVu + "'");

            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public DataTable  TinhLuong()
        {
            DataTable data= DataProvider.Instance.ExecuteQuery("exec TinhLuong");
            return data;
        }
       
    }
}
