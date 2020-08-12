using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class LuongNVDAO
    {

        private static LuongNVDAO instance;

        public static LuongNVDAO Instance
        {
            get { if (instance == null) instance = new LuongNVDAO(); return instance; }
            private set { instance = value; }
        }
        private LuongNVDAO()
        {

        }
        public List<LuongNV> GetLuongs()
        {
            List<LuongNV> luongs = new List<LuongNV>();
            DataTable data = DataProvider.Instance.ExecuteQuery("TinhLuong");
            foreach (DataRow item in data.Rows)
            {
                LuongNV luong = new LuongNV(item);
                luongs.Add(luong);
            }
            return luongs;
        }
        public bool Update(string IDChamCong,string SoCong)
        {
            int i=DataProvider.Instance.ExecuteNonQuery("update chamcong set socong = "+"'"+SoCong+"'"+" where idchamcong="+"'"+IDChamCong+"'");
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
