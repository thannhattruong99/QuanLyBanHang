namespace QuanlybanhangFAHASA
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMathang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaihang = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoadonban = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindhoadon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindkhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaocao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBChangton = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBCdoanhthu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHientrogiup = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoadon,
            this.mnuTimkiem,
            this.mnuBaocao,
            this.mnuTrogiup});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(831, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngNhậpToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(46, 24);
            this.mnuFile.Text = "File";
            // 
            // đăngNhậpToolStripMenuItem
            // 
            this.đăngNhậpToolStripMenuItem.Name = "đăngNhậpToolStripMenuItem";
            this.đăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngNhậpToolStripMenuItem.Text = "Đăng nhập";
            this.đăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.đăngNhậpToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhanVien,
            this.mnuKhachhang,
            this.mnuMathang,
            this.mnuLoaihang,
            this.chiTiếtHóaĐơnToolStripMenuItem});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(90, 24);
            this.mnuDanhMuc.Text = "Danh Mục";
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.Size = new System.Drawing.Size(224, 26);
            this.mnuNhanVien.Text = "Nhân Viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachhang
            // 
            this.mnuKhachhang.Name = "mnuKhachhang";
            this.mnuKhachhang.Size = new System.Drawing.Size(224, 26);
            this.mnuKhachhang.Text = "Khách Hàng";
            this.mnuKhachhang.Click += new System.EventHandler(this.mnuKhachhang_Click);
            // 
            // mnuMathang
            // 
            this.mnuMathang.Name = "mnuMathang";
            this.mnuMathang.Size = new System.Drawing.Size(224, 26);
            this.mnuMathang.Text = "Mặt Hàng";
            this.mnuMathang.Click += new System.EventHandler(this.mnuMathang_Click);
            // 
            // mnuLoaihang
            // 
            this.mnuLoaihang.Name = "mnuLoaihang";
            this.mnuLoaihang.Size = new System.Drawing.Size(224, 26);
            this.mnuLoaihang.Text = "Loại Hàng";
            this.mnuLoaihang.Click += new System.EventHandler(this.mnuLoaihang_Click);
            // 
            // chiTiếtHóaĐơnToolStripMenuItem
            // 
            this.chiTiếtHóaĐơnToolStripMenuItem.Name = "chiTiếtHóaĐơnToolStripMenuItem";
            this.chiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.chiTiếtHóaĐơnToolStripMenuItem.Text = "Chi Tiết Hóa Đơn";
            this.chiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // mnuHoadon
            // 
            this.mnuHoadon.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mnuHoadon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mnuHoadon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoadonban});
            this.mnuHoadon.Name = "mnuHoadon";
            this.mnuHoadon.Size = new System.Drawing.Size(83, 24);
            this.mnuHoadon.Text = "Hóa Đơn";
            // 
            // mnuHoadonban
            // 
            this.mnuHoadonban.Name = "mnuHoadonban";
            this.mnuHoadonban.Size = new System.Drawing.Size(179, 26);
            this.mnuHoadonban.Text = "Hóa đơn bán";
            this.mnuHoadonban.Click += new System.EventHandler(this.mnuHoadonban_Click);
            // 
            // mnuTimkiem
            // 
            this.mnuTimkiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindhoadon,
            this.mnuFindhang,
            this.mnuFindkhachhang});
            this.mnuTimkiem.Name = "mnuTimkiem";
            this.mnuTimkiem.Size = new System.Drawing.Size(84, 24);
            this.mnuTimkiem.Text = "Tìm kiếm";
            // 
            // mnuFindhoadon
            // 
            this.mnuFindhoadon.Name = "mnuFindhoadon";
            this.mnuFindhoadon.Size = new System.Drawing.Size(232, 26);
            this.mnuFindhoadon.Text = "Tìm kiếm hóa đơn";
            // 
            // mnuFindhang
            // 
            this.mnuFindhang.Name = "mnuFindhang";
            this.mnuFindhang.Size = new System.Drawing.Size(232, 26);
            this.mnuFindhang.Text = "Tìm kiếm hàng";
            // 
            // mnuFindkhachhang
            // 
            this.mnuFindkhachhang.Name = "mnuFindkhachhang";
            this.mnuFindkhachhang.Size = new System.Drawing.Size(232, 26);
            this.mnuFindkhachhang.Text = "Tìm kiếm khách hàng";
            // 
            // mnuBaocao
            // 
            this.mnuBaocao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBChangton,
            this.mnuBCdoanhthu});
            this.mnuBaocao.Name = "mnuBaocao";
            this.mnuBaocao.Size = new System.Drawing.Size(83, 24);
            this.mnuBaocao.Text = "Báo Cáo ";
            // 
            // mnuBChangton
            // 
            this.mnuBChangton.Name = "mnuBChangton";
            this.mnuBChangton.Size = new System.Drawing.Size(219, 26);
            this.mnuBChangton.Text = "Báo cáo hàng tồn";
            // 
            // mnuBCdoanhthu
            // 
            this.mnuBCdoanhthu.Name = "mnuBCdoanhthu";
            this.mnuBCdoanhthu.Size = new System.Drawing.Size(219, 26);
            this.mnuBCdoanhthu.Text = "Báo cáo Doanh thu";
            // 
            // mnuTrogiup
            // 
            this.mnuTrogiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHientrogiup});
            this.mnuTrogiup.Name = "mnuTrogiup";
            this.mnuTrogiup.Size = new System.Drawing.Size(79, 24);
            this.mnuTrogiup.Text = "Trợ Gíup";
            // 
            // mnuHientrogiup
            // 
            this.mnuHientrogiup.Name = "mnuHientrogiup";
            this.mnuHientrogiup.Size = new System.Drawing.Size(147, 26);
            this.mnuHientrogiup.Text = "Trợ giúp";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(106, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 256);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(194, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "CHƯƠNG TRÌNH QUẢN LÝ ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(117, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "BÁN HÀNG TẠI NHÀ SÁCH FAHASA";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(831, 480);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuMathang;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaihang;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoadonban;
        private System.Windows.Forms.ToolStripMenuItem mnuTimkiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindhoadon;
        private System.Windows.Forms.ToolStripMenuItem mnuFindhang;
        private System.Windows.Forms.ToolStripMenuItem mnuFindkhachhang;
        private System.Windows.Forms.ToolStripMenuItem mnuBaocao;
        private System.Windows.Forms.ToolStripMenuItem mnuBChangton;
        private System.Windows.Forms.ToolStripMenuItem mnuBCdoanhthu;
        private System.Windows.Forms.ToolStripMenuItem mnuTrogiup;
        private System.Windows.Forms.ToolStripMenuItem mnuHientrogiup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem đăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}

