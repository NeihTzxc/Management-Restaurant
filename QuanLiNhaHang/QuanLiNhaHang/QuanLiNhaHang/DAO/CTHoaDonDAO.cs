using QuanLiNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DAO
{
    public class CTHoaDonDAO
    {
        private static CTHoaDonDAO instance;

        public static CTHoaDonDAO Instance
        {
            get { if (instance == null) instance = new CTHoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private CTHoaDonDAO()
        {

        }
        public List<CTHoaDon> GetCTHoaDons(string idhd)
        {
            List<CTHoaDon> CTHoaDonList = new List<CTHoaDon>();
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from CTHoaDon where IDHoaDon= '"+idhd+"'");
            foreach (DataRow item in data.Rows)
            {
                CTHoaDon cTHoaDon = new CTHoaDon(item);
                CTHoaDonList.Add(cTHoaDon);
            }
            return CTHoaDonList;
        }
        public bool Insert_CTHoaDon(string IDMon, string SoLuong,string IDHoaDon)
        {
            int i;
            i= DataProvider.Instance.ExecuteNonQuery("exec usp_AUTO_INSERT_CTHD '"+IDMon+"',"+ SoLuong+",'"+IDHoaDon+"'");
            if (i != 0)
            {
                return true;
            }
            else return false;
        }
       
        public bool Delete_CTHoaDon(string IDCTHoaDon)
        {
            int i;
            i = DataProvider.Instance.ExecuteNonQuery("delete CTHoaDon where IDCTHoaDon ="+"'"+IDCTHoaDon+"'");
            if (i != 0)
            {
                return true;
            }
            else return false;
        }
        public bool Delete_Mon_Trong_CTHD(string idcthd)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("exec XoaMon @idcthd = " + idcthd);
            if (i != 0)
            {
                return true;
            }
            else return false;
        }
        public string Get_ID_Mon(string idcthd)
        {
            object idmon = DataProvider.Instance.ExecuteScalar("select IDMonAn from CTHoaDon where idcthoadon = " + "'"+idcthd+"'");
            if (idmon != null)
            {
                return idmon.ToString();
            }
            else return null;
        }
        public bool ChuyenBan(string idhd_moi, string idhd_cu)
        {
            int i = DataProvider.Instance.ExecuteNonQuery("update CTHoaDon set IDHoaDon= "+"'"+idhd_moi+"'"+" where IDHoaDon = "+"'"+idhd_cu+"'"
                +" Delete from HoaDon where IDHoaDon = "+"'"+idhd_cu+"'");
            if (i != 0)
            {
                return true;
            }
            else return false;
        }
    }
}
