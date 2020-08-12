using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    class HoaDonDAO
    {
        private static HoaDonDAO instance;

        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private HoaDonDAO()
        {

        }
        public List<HoaDon> GetHoaDons()
        {
            List<HoaDon> HoaDonList = new List<HoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from hoadon");
            foreach (DataRow item in data.Rows)
            {
                HoaDon  hoaDon = new HoaDon(item);
                HoaDonList.Add(hoaDon);
            }
            return HoaDonList;
        }
        public string Get_TenNhanVien(string idhd)
        {
            object ten = DataProvider.Instance.ExecuteScalar("select HO+Ten from NhanVien, HoaDon where NhanVien.IDNhanVien=HoaDon.IDNhanVien and HoaDon.IDHoaDon = '"+idhd+"'");
            if (ten != null)
            {
                return ten.ToString();
            }
            else
            {
                return null;
            }
        }
        public bool Insert_HoaDon(string IDBan, string IDNhanVien)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec usp_AUTO_INSERT_HD '"+IDBan+"' , "+"'"+IDNhanVien+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Updata_NV_HD(string IDNV, string IDHD)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("update HoaDon set IDNhanVien = "+"'"+IDNV+"'"+" where IDHoaDon = "+"'"+IDHD+"'");
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string GET_IDHD(string idban)
        {
            object idhd = DataProvider.Instance.ExecuteScalar("exec GET_IDHD @IDBan = " + idban);
            if (idhd != null)
                return idhd.ToString();
            else return null;
        }
        public bool Xoa(string idhd)
        {
            string Query = "exec XoaHD_the0_IDHD @IDHD";
            int i = DataProvider.Instance.ExecuteNonQuery(Query, new object[] { idhd });
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
