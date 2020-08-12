namespace QuanLiNhaHang
{
    partial class XuaHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.usp_xemCTHDtheoIDhdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HD = new QuanLiNhaHang.HD();
            this.usp_xemCTHDtheoIDhdTableAdapter = new QuanLiNhaHang.HDTableAdapters.usp_xemCTHDtheoIDhdTableAdapter();
            this.reportViewer_XHD = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usp_tinh_hoadon_theo_idHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usp_tinh_hoadon_theo_idHDTableAdapter = new QuanLiNhaHang.HDTableAdapters.usp_tinh_hoadon_theo_idHDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usp_xemCTHDtheoIDhdBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_tinh_hoadon_theo_idHDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usp_xemCTHDtheoIDhdBindingSource
            // 
            this.usp_xemCTHDtheoIDhdBindingSource.DataMember = "usp_xemCTHDtheoIDhd";
            this.usp_xemCTHDtheoIDhdBindingSource.DataSource = this.HD;
            // 
            // HD
            // 
            this.HD.DataSetName = "HD";
            this.HD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usp_xemCTHDtheoIDhdTableAdapter
            // 
            this.usp_xemCTHDtheoIDhdTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer_XHD
            // 
            this.reportViewer_XHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer_XHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.usp_xemCTHDtheoIDhdBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.usp_tinh_hoadon_theo_idHDBindingSource;
            this.reportViewer_XHD.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer_XHD.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer_XHD.LocalReport.ReportEmbeddedResource = "QuanLiNhaHang.ReportCTHDTheoIDHD.rdlc";
            this.reportViewer_XHD.Location = new System.Drawing.Point(0, 0);
            this.reportViewer_XHD.Name = "reportViewer_XHD";
            this.reportViewer_XHD.ServerReport.BearerToken = null;
            this.reportViewer_XHD.Size = new System.Drawing.Size(666, 447);
            this.reportViewer_XHD.TabIndex = 0;
            this.reportViewer_XHD.Load += new System.EventHandler(this.reportViewer_XHD_Load);
            // 
            // usp_tinh_hoadon_theo_idHDBindingSource
            // 
            this.usp_tinh_hoadon_theo_idHDBindingSource.DataMember = "usp_tinh_hoadon_theo_idHD";
            this.usp_tinh_hoadon_theo_idHDBindingSource.DataSource = this.HD;
            // 
            // usp_tinh_hoadon_theo_idHDTableAdapter
            // 
            this.usp_tinh_hoadon_theo_idHDTableAdapter.ClearBeforeFill = true;
            // 
            // XuaHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 447);
            this.Controls.Add(this.reportViewer_XHD);
            this.Name = "XuaHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "XuaHD";
            this.Load += new System.EventHandler(this.XuaHD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usp_xemCTHDtheoIDhdBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usp_tinh_hoadon_theo_idHDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource usp_xemCTHDtheoIDhdBindingSource;
        private HD HD;
        private HDTableAdapters.usp_xemCTHDtheoIDhdTableAdapter usp_xemCTHDtheoIDhdTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer_XHD;
        private System.Windows.Forms.BindingSource usp_tinh_hoadon_theo_idHDBindingSource;
        private HDTableAdapters.usp_tinh_hoadon_theo_idHDTableAdapter usp_tinh_hoadon_theo_idHDTableAdapter;
    }
}