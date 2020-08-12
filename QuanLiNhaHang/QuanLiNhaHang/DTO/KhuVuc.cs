using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiNhaHang.DTO
{
    public class KhuVuc
    {
        public KhuVuc(String IDKhuVuc)
        {
            
            this.IDKhuvuc1 = IDKhuVuc;
        

        }
        public KhuVuc(DataRow row)
        {
        
            this.IDKhuvuc1 = row["IDKhuVuc"].ToString();
      
        }

        private string IDKhuvuc;
  

       
        public string IDKhuvuc1 { get => IDKhuvuc; set => IDKhuvuc = value; }
       
    }
}
