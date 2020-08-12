using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    class XemCTHoaDonDAO
    {
        private static XemCTHoaDonDAO instance;


        private XemCTHoaDonDAO()
        {

        }

        internal static XemCTHoaDonDAO Instance
        {
            get { if (instance == null) instance = new XemCTHoaDonDAO(); return instance; }
            private set => instance = value;
        }

        public List<XemCTHoaDon> Get_XemCTHoaDons(string IDhd)
        {
            List<XemCTHoaDon> HoadonList = new List<XemCTHoaDon>();
            try {
                DataTable data = DataProvider.Instance.ExecuteQuery("exec usp_xemCTHDtheoIDhd @IDhd = " + IDhd);
                foreach (DataRow item in data.Rows)
                {
                    XemCTHoaDon hoaDon = new XemCTHoaDon(item);
                    HoadonList.Add(hoaDon);
                }
                return HoadonList;
            }
            catch (Exception)
            {
                return null;
            }
        }
         
    }
   
}
