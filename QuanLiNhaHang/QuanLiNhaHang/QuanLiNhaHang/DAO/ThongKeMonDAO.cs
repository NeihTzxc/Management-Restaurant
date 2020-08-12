using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class ThongKeMonDAO
    {
        private static ThongKeMonDAO instance;

        public static ThongKeMonDAO Instance
        {
            get { if (instance == null) instance = new ThongKeMonDAO(); return instance; }
            private set { instance = value; }
        }
        private ThongKeMonDAO()
        {

        }
        public List<ThongKeMon> GetThongKeMons()
        {
            List<ThongKeMon> ThongKeMonList = new List<ThongKeMon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec thongkemon");
            foreach (DataRow item in data.Rows)
            {
                ThongKeMon thongKeMon = new ThongKeMon(item);
                ThongKeMonList.Add(thongKeMon);
            }
            return ThongKeMonList;
        }
    }
}
