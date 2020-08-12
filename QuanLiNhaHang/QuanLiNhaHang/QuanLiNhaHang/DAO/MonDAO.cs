using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class MonDAO
    {
        private static MonDAO instance;

        public static MonDAO Instance
        {
            get { if (instance == null) instance = new MonDAO(); return instance; }
            private set { instance = value; }
        }
        private MonDAO()
        {

        }
        public List<Mon> GetMon()
        {
            List<Mon> MonList = new List<Mon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from mon");
            foreach (DataRow item in data.Rows)
            {
                Mon mon = new Mon(item);
                MonList.Add(mon);

            }
            return MonList;
        }
        public bool xoa(string idmon)
        {
            int i =0;
            try
            {
                i = DataProvider.Instance.ExecuteNonQuery("delete from mon where idmonan = " + "'" + idmon + "'");
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
        public bool Insert_Mon(string tenmon,string dongia)
        {

            int i = DataProvider.Instance.ExecuteNonQuery("exec Auto_insetMon N'"+tenmon+"','"+dongia+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool update_mon(string idmon,string tenmon, string dongia)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec Update_mon "+"'"+idmon+"',"+"N'"+tenmon+"', "+"'"+dongia+"'");
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
