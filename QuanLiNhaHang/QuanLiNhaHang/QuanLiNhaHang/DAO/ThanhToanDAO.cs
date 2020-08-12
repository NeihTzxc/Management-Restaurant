using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class ThanhToanDAO
    {
        private static ThanhToanDAO instance;

        public static ThanhToanDAO Instance
        {
            get { if (instance == null) instance = new ThanhToanDAO(); return instance; }
            private set { instance = value; }
        }
        private ThanhToanDAO()
        {

        }
        public int thanhtoan(string idhd)
        {
             int t= DataProvider.Instance.ExecuteNonQuery("exec thanhtoan @idhd = " + idhd);
            return t;
        }
    }
}
