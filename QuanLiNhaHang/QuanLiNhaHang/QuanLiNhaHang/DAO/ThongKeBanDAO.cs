using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class ThongKeBanDAO
    {
        private static ThongKeBanDAO instance;

        public static ThongKeBanDAO Instance
        {
            get { if (instance == null) instance = new ThongKeBanDAO(); return instance; }
            private set { instance = value; }
        }
        private ThongKeBanDAO()
        {

        }
        public List<ThongKeBan> Get_ThongKeBan()
        {
            List<ThongKeBan> ThongKeBanList = new List<ThongKeBan>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec thongkeban");
            foreach (DataRow item in data.Rows)
            {
                ThongKeBan thongKeBan = new ThongKeBan(item);
                ThongKeBanList.Add(thongKeBan);
            }
            return ThongKeBanList;
        }
    }
}
