using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class ChucVuDAO
    {
        private static ChucVuDAO instance;

        public static ChucVuDAO Instance
        {
            get { if (instance == null) instance = new ChucVuDAO(); return instance; }
            private set { instance = value; }
        }
        private ChucVuDAO()
        {

        }
        public List<ChucVu> GetChucVus()
        {
            List<ChucVu> chucvuList = new List<ChucVu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from chucvu");
            foreach (DataRow item in data.Rows)
            {
                ChucVu chucVu = new ChucVu(item);
                chucvuList.Add(chucVu);
            }
            return chucvuList;
        }
        public bool Insert_ChucVu(string Ten,string HeSo,string idluong)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec Auto_insert_ChucVu N'"+Ten+"'"+","+"'"+HeSo+"'"+","+"'"+idluong+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete_ChucVu(string id)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("delete from chucvu where idchucvu = "+"'"+id+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update_CV(string TenChucVu,string HeSoLuong, string IDLuong, string IDChucVu)
        {
            string Query = "exec Update_CV @TenChucVu , @HeSoLuong , @IDLuong , @IDChucVu";
            int i = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { TenChucVu, HeSoLuong, IDLuong, IDChucVu });
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
