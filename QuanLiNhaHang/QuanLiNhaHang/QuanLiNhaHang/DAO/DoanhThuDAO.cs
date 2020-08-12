using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class DoanhThuDAO
    {
        private static DoanhThuDAO instance;

        public static DoanhThuDAO Instance
        {
            get { if (instance == null) instance = new DoanhThuDAO(); return instance; }
            private set { instance = value; }
        }
        private DoanhThuDAO()
        {

        }
        public List<DoanhThu> ThongKe()
        {
            List<DoanhThu> list_DT = new List<DoanhThu>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec usp_TONG_THU_TU_HOA_DON");
            foreach(DataRow item in data.Rows)
            {
                DoanhThu doanhThu = new DoanhThu(item);
                list_DT.Add(doanhThu);
            }
            return list_DT;
        }
    }
}
