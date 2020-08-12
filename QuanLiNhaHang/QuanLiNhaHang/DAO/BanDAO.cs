using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return instance; }
            private set { instance = value; }
        }
        private BanDAO()
        {

        }
        public List<Ban> GetBans()
        {
            List<Ban> BanList = new List<Ban>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from ban");
            foreach(DataRow item in data.Rows)
            {
                Ban ban = new Ban(item);
                BanList.Add(ban);
            }
            return BanList;
        }
        public bool xoa(string idban)
        {
            int i = 0;
            try
            {
                i = DataProvider.Instance.ExecuteNonQuery("delete from ban where idban = " + "'" + idban + "'");
            }
            catch (Exception)
            {
                return false;
            }
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Insert_Ban(string idban, string idkhuvuc)
        {

            int i = DataProvider.Instance.ExecuteNonQuery("insert into ban(idban, idkhuvuc) values(" + "'"+idban+"'"+",'"+idkhuvuc+"'"+")");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Update_ban(string idban, string idkhuvuc)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec update_ban @idban  = "+idban+", @idkhuvuc = "+idkhuvuc);
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
