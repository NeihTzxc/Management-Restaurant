using QuanLiNhaHang.DTO;

namespace QuanLiNhaHang
{
    partial class CTBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CTBanHang));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label_idban = new System.Windows.Forms.Label();
            this.labelban = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView_HoaDon = new System.Windows.Forms.ListView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button_XoaMon = new System.Windows.Forms.Button();
            this.button_Xuat = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listView_NhanVien = new System.Windows.Forms.ListView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label_IDHD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.label_GiamGia = new System.Windows.Forms.Label();
            this.label_Gio = new System.Windows.Forms.Label();
            this.label_NV = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_mon = new System.Windows.Forms.ListView();
            this.panel13 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.label_idban);
            this.panel4.Controls.Add(this.labelban);
            this.panel4.Location = new System.Drawing.Point(0, 53);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(941, 43);
            this.panel4.TabIndex = 19;
            // 
            // label_idban
            // 
            this.label_idban.AutoSize = true;
            this.label_idban.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idban.ForeColor = System.Drawing.Color.White;
            this.label_idban.Location = new System.Drawing.Point(454, 9);
            this.label_idban.Name = "label_idban";
            this.label_idban.Size = new System.Drawing.Size(62, 31);
            this.label_idban.TabIndex = 1;
            this.label_idban.Text = "A01";
            // 
            // labelban
            // 
            this.labelban.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelban.AutoSize = true;
            this.labelban.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelban.ForeColor = System.Drawing.Color.Snow;
            this.labelban.Location = new System.Drawing.Point(395, 9);
            this.labelban.Name = "labelban";
            this.labelban.Size = new System.Drawing.Size(65, 31);
            this.labelban.TabIndex = 0;
            this.labelban.Text = "Bàn";
            this.labelban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelban.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(-3, 45);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(944, 478);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.listView_HoaDon);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.listView_NhanVien);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.listView_mon);
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(3, 51);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(938, 424);
            this.panel2.TabIndex = 1;
            // 
            // listView_HoaDon
            // 
            this.listView_HoaDon.HideSelection = false;
            this.listView_HoaDon.Location = new System.Drawing.Point(391, 32);
            this.listView_HoaDon.Name = "listView_HoaDon";
            this.listView_HoaDon.Size = new System.Drawing.Size(547, 160);
            this.listView_HoaDon.TabIndex = 1;
            this.listView_HoaDon.UseCompatibleStateImageBehavior = false;
            this.listView_HoaDon.SelectedIndexChanged += new System.EventHandler(this.listView_HoaDon_SelectedIndexChanged);
            this.listView_HoaDon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_HoaDon_KeyDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Maroon;
            this.panel8.Controls.Add(this.button_XoaMon);
            this.panel8.Controls.Add(this.button_Xuat);
            this.panel8.Controls.Add(this.button1);
            this.panel8.Location = new System.Drawing.Point(391, 198);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(547, 29);
            this.panel8.TabIndex = 3;
            // 
            // button_XoaMon
            // 
            this.button_XoaMon.Location = new System.Drawing.Point(464, 3);
            this.button_XoaMon.Name = "button_XoaMon";
            this.button_XoaMon.Size = new System.Drawing.Size(72, 23);
            this.button_XoaMon.TabIndex = 3;
            this.button_XoaMon.Text = "Xóa món";
            this.button_XoaMon.UseVisualStyleBackColor = true;
            this.button_XoaMon.Click += new System.EventHandler(this.button_XoaMon_Click);
            // 
            // button_Xuat
            // 
            this.button_Xuat.Location = new System.Drawing.Point(386, 3);
            this.button_Xuat.Name = "button_Xuat";
            this.button_Xuat.Size = new System.Drawing.Size(72, 23);
            this.button_Xuat.TabIndex = 1;
            this.button_Xuat.Text = "Thanh toán";
            this.button_Xuat.UseVisualStyleBackColor = true;
            this.button_Xuat.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(308, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tách";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView_NhanVien
            // 
            this.listView_NhanVien.HideSelection = false;
            this.listView_NhanVien.Location = new System.Drawing.Point(197, 32);
            this.listView_NhanVien.Name = "listView_NhanVien";
            this.listView_NhanVien.Size = new System.Drawing.Size(188, 392);
            this.listView_NhanVien.TabIndex = 5;
            this.listView_NhanVien.UseCompatibleStateImageBehavior = false;
            this.listView_NhanVien.SelectedIndexChanged += new System.EventHandler(this.listView_NhanVien_SelectedIndexChanged);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.label_IDHD);
            this.panel10.Controls.Add(this.label10);
            this.panel10.Controls.Add(this.label_TongTien);
            this.panel10.Controls.Add(this.label_GiamGia);
            this.panel10.Controls.Add(this.label_Gio);
            this.panel10.Controls.Add(this.label_NV);
            this.panel10.Controls.Add(this.label8);
            this.panel10.Controls.Add(this.label7);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Controls.Add(this.label4);
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(391, 225);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(547, 199);
            this.panel10.TabIndex = 4;
            this.panel10.Paint += new System.Windows.Forms.PaintEventHandler(this.panel10_Paint);
            // 
            // label_IDHD
            // 
            this.label_IDHD.AutoSize = true;
            this.label_IDHD.Location = new System.Drawing.Point(104, 26);
            this.label_IDHD.Name = "label_IDHD";
            this.label_IDHD.Size = new System.Drawing.Size(0, 13);
            this.label_IDHD.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Mã Hóa đơn:";
            // 
            // label_TongTien
            // 
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Location = new System.Drawing.Point(93, 131);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(0, 13);
            this.label_TongTien.TabIndex = 9;
            // 
            // label_GiamGia
            // 
            this.label_GiamGia.AutoSize = true;
            this.label_GiamGia.Location = new System.Drawing.Point(89, 103);
            this.label_GiamGia.Name = "label_GiamGia";
            this.label_GiamGia.Size = new System.Drawing.Size(0, 13);
            this.label_GiamGia.TabIndex = 8;
            // 
            // label_Gio
            // 
            this.label_Gio.AutoSize = true;
            this.label_Gio.Location = new System.Drawing.Point(106, 75);
            this.label_Gio.Name = "label_Gio";
            this.label_Gio.Size = new System.Drawing.Size(0, 13);
            this.label_Gio.TabIndex = 7;
            // 
            // label_NV
            // 
            this.label_NV.AutoSize = true;
            this.label_NV.Location = new System.Drawing.Point(139, 48);
            this.label_NV.Name = "label_NV";
            this.label_NV.Size = new System.Drawing.Size(0, 13);
            this.label_NV.TabIndex = 5;
            this.label_NV.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Giảm giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Thời gian vào:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhân viên phục vụ:";
            // 
            // listView_mon
            // 
            this.listView_mon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView_mon.HideSelection = false;
            this.listView_mon.Location = new System.Drawing.Point(0, 32);
            this.listView_mon.Name = "listView_mon";
            this.listView_mon.Size = new System.Drawing.Size(191, 392);
            this.listView_mon.TabIndex = 5;
            this.listView_mon.UseCompatibleStateImageBehavior = false;
            this.listView_mon.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_mon_ItemSelectionChanged);
            this.listView_mon.SelectedIndexChanged += new System.EventHandler(this.listView_mon_SelectedIndexChanged);
            this.listView_mon.Click += new System.EventHandler(this.listView_mon_Click);
            this.listView_mon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listView_mon_KeyDown);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Maroon;
            this.panel13.Controls.Add(this.label9);
            this.panel13.Location = new System.Drawing.Point(197, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(188, 34);
            this.panel13.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(39, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "Nhân viên";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Maroon;
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(191, 34);
            this.panel6.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Món";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Maroon;
            this.panel7.Controls.Add(this.label1);
            this.panel7.Location = new System.Drawing.Point(391, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(550, 34);
            this.panel7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(196, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Location = new System.Drawing.Point(-3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 97);
            this.panel1.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel9.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel9.BackgroundImage")));
            this.panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(303, 35);
            this.panel9.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(39, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bán hàng";
            // 
            // CTBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 524);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CTBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhà hàng Thịnh Vương";
            this.Load += new System.EventHandler(this.CTBanHang_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelban;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_idban;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button_Xuat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView_HoaDon;
        private System.Windows.Forms.ListView listView_mon;
        private System.Windows.Forms.Label label_NV;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.Label label_GiamGia;
        private System.Windows.Forms.Label label_Gio;
        private System.Windows.Forms.Button button_XoaMon;
        private System.Windows.Forms.ListView listView_NhanVien;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_IDHD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
    }
}