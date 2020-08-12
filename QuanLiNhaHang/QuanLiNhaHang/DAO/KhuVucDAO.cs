using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    class KhuVucDAO
    {
        private static KhuVucDAO instance;

        public static KhuVucDAO Instance
        {
            get { if (instance == null) instance = new KhuVucDAO(); return instance; }
            private set { instance = value; }
        }
        private KhuVucDAO()
        {

        }
        public List<KhuVuc> GetKhuVuc()
        {
            List<KhuVuc> KhuVucList = new List<KhuVuc>();
            DataTable data = DataProvider.Instance.ExecuteQuery("getIDKhuVuc");
            foreach (DataRow item in data.Rows)
            {
                KhuVuc khu = new KhuVuc(item);
                KhuVucList.Add(khu);
                
            }
            return KhuVucList;
        }
    }
}
