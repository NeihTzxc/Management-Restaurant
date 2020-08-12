using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiNhaHang
{
    public partial class XuaHD : Form
    {

        public XuaHD(string idhd)
        {
            this.IDHD = idhd;
            InitializeComponent();
        }
        public XuaHD()
        {
            
            InitializeComponent();
        }
        string IDHD;
        private void XuaHD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'HD.usp_tinh_hoadon_theo_idHD' table. You can move, or remove it, as needed.
            this.usp_tinh_hoadon_theo_idHDTableAdapter.Fill(this.HD.usp_tinh_hoadon_theo_idHD,IDHD);

            // TODO: This line of code loads data into the 'HD.usp_xemCTHDtheoIDhd' table. You can move, or remove it, as needed.
            //     reportViewer_XHD.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.usp_xemCTHDtheoIDhdTableAdapter.Fill(this.HD.usp_xemCTHDtheoIDhd, IDHD);
           
            this.reportViewer_XHD.RefreshReport();
        }

        private void reportViewer_XHD_Load(object sender, EventArgs e)
        {

        }
    }
}
