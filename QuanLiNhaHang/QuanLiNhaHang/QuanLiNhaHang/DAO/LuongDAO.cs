using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class LuongDAO
    {
        private static LuongDAO instance;

        public static LuongDAO Instance
        {
            get { if (instance == null) instance = new LuongDAO(); return instance; }
            private set { instance = value; }
        }
        private LuongDAO()
        {

        }
        public List<Luong> GetLuongs()
        {
            List<Luong> luongs = new List<Luong>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Luong");
            foreach(DataRow item in data.Rows)
            {
                Luong luong=new Luong(item);
                luongs.Add(luong);
            }
            return luongs;
        }
        public bool Insert_Luong(string Luong)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec Auto_insert_luong @LuongNgayCong = " + Luong);
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Delete_Luong(string id)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("delete from luong where idluong="+"'"+id+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update_Luong(string IDLuong,string LuongNgayCong)
        {
            string Query = "exec Update_Luong @IDLuong , @LuongNgayCong";
            int i = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { IDLuong, LuongNgayCong });
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
