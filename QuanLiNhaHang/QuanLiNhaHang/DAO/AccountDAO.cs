using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QuanLiNhaHang.DTO;

namespace QuanLiNhaHang.DAO
{
    class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO()
        {

        }

        public bool Login(string TenTaiKhoan,string MatKhau)
        {
           

            string query = "USP_Login @TenTaiKhoan , @MatKhau";

            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { TenTaiKhoan,MatKhau /*list*/});

            return result.Rows.Count > 0;
        }
        public List<TaiKhoanQT> GetTaiKhoans()
        {
            List<TaiKhoanQT> taiKhoans = new List<TaiKhoanQT>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from TaiKhoan");
            foreach(DataRow item in data.Rows)
            {
                TaiKhoanQT taiKhoan = new TaiKhoanQT(item);
                taiKhoans.Add(taiKhoan);
            }
            return taiKhoans;
        }
        public  void Them(string TenTaiKhoan,string MatKhau)
        {
            string Query = "exec Auto_insert_TaiKhoan @TenTaiKhoan , @MatKhau";
            DataProvider.Instance.ExecuteNonQuery(Query, new object[] { TenTaiKhoan, MatKhau });
        }
        public void Sua_TK(string IDTaiKhoan,string TenTaiKhoan,string MatKhau)
        {
            string Query = "exec Update_TK @IDTaiKhoan , @TenTaiKhoan , @MatKhau";
            DataProvider.Instance.ExecuteNonQuery(Query, new object[] { IDTaiKhoan, TenTaiKhoan, MatKhau });
        }
        public void Xoa_TK(string IDTaiKhoan)
        {
            string Query = "delete from TaiKhoan where IDTaiKhoan = @IDTaiKhoan";
            DataProvider.Instance.ExecuteNonQuery(Query, new object[] { IDTaiKhoan });
        }
    }
}

