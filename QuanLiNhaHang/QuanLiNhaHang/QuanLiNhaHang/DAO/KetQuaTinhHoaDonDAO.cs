using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class KetQuaTinhHoaDonDAO
    {
        private static KetQuaTinhHoaDonDAO instance;

        public static KetQuaTinhHoaDonDAO Instance
        {
            get { if (instance == null) instance = new KetQuaTinhHoaDonDAO(); return instance; }
            private set => instance = value;
        }
        public KetQuaTinhHoaDonDAO()
        {

        }
        public List<KetQuaTinhHoaDon> GetKetQuaTinhHoaDons(string idhd)
        {
            List<KetQuaTinhHoaDon> KetQuaTinhHoaDonList = new List<KetQuaTinhHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec usp_tinh_hoadon_theo_idHD @idhoadon = "+idhd);
            foreach (DataRow item in data.Rows)
            {
                KetQuaTinhHoaDon ketQuaTinhHoaDon = new KetQuaTinhHoaDon(item);
                KetQuaTinhHoaDonList.Add(ketQuaTinhHoaDon);
            }
            return KetQuaTinhHoaDonList;
        }
        public List<KetQuaTinhHoaDon> XemTTHoaDon_DaThanhToan()
        {
            List<KetQuaTinhHoaDon> KetQuaTinhHoaDonList = new List<KetQuaTinhHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("exec usp_XemTThoadon");
            foreach (DataRow item in data.Rows)
            {
                KetQuaTinhHoaDon ketQuaTinhHoaDon = new KetQuaTinhHoaDon(item);
                KetQuaTinhHoaDonList.Add(ketQuaTinhHoaDon);
            }
            return KetQuaTinhHoaDonList;
        }
       
    }
}
