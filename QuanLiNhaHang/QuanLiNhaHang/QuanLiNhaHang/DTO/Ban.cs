using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class Ban
    {
        public Ban(String IDBan, String IDKhuVuc, String TinhTrang)
        {
            this.IDBan1 = IDBan;
            this.IDKhuvuc1 = IDKhuVuc;
            this.TinhTrang1 = TinhTrang;

        }
        public Ban(DataRow row)
        {
            this.IDBan1 = row["IDBan"].ToString();
            this.IDKhuvuc1 = row["IDKhuVuc"].ToString();
            this.TinhTrang1= row["TinhTrang"].ToString();
        }
        private string IDBan;
        private string IDKhuvuc;
        private string TinhTrang;

        public string IDBan1 { get => IDBan; set => IDBan = value; }
        public string IDKhuvuc1 { get => IDKhuvuc; set => IDKhuvuc = value; }
        public string TinhTrang1 { get => TinhTrang; set => TinhTrang = value; }
    }
}
