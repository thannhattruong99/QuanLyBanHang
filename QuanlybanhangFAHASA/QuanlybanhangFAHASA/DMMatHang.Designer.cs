namespace QuanlybanhangFAHASA
{
    partial class DMMatHang
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
            System.Windows.Forms.Button btnTK;
            System.Windows.Forms.Button btnDong;
            System.Windows.Forms.Button btnBoqua;
            System.Windows.Forms.Button btnLuu;
            System.Windows.Forms.Button btnSua;
            System.Windows.Forms.Button btnXoa;
            System.Windows.Forms.Button btnThem;
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slTonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaNhapDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bANHANGFAHASADataSet = new QuanlybanhangFAHASA.BANHANGFAHASADataSet();
            this.matHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtDgBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDgNhap = new System.Windows.Forms.TextBox();
            this.txtTenMh = new System.Windows.Forms.TextBox();
            this.txtMaMh = new System.Windows.Forms.TextBox();
            this.txtMLH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btndung = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboMaloaihang = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSlTon = new System.Windows.Forms.TextBox();
            this.matHangTableAdapter = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.MatHangTableAdapter();
            this.tableAdapterManager = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager();
            btnTK = new System.Windows.Forms.Button();
            btnDong = new System.Windows.Forms.Button();
            btnBoqua = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.cboMaloaihang.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTK
            // 
            btnTK.Location = new System.Drawing.Point(1007, 27);
            btnTK.Name = "btnTK";
            btnTK.Size = new System.Drawing.Size(132, 41);
            btnTK.TabIndex = 6;
            btnTK.Text = "Tìm kiem";
            btnTK.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(844, 27);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(132, 41);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new System.Drawing.Point(681, 29);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new System.Drawing.Size(132, 41);
            btnBoqua.TabIndex = 4;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(518, 29);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(132, 41);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Luu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(355, 27);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(132, 41);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(192, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(132, 41);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(29, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(132, 41);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AutoGenerateColumns = false;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maMHDataGridViewTextBoxColumn,
            this.tenMHDataGridViewTextBoxColumn,
            this.slTonDataGridViewTextBoxColumn,
            this.giaNhapDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn,
            this.maLoaiHangDataGridViewTextBoxColumn,
            this.maDVDataGridViewTextBoxColumn});
            this.dgvMatHang.DataSource = this.matHangBindingSource1;
            this.dgvMatHang.Location = new System.Drawing.Point(9, 226);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.RowHeadersWidth = 51;
            this.dgvMatHang.RowTemplate.Height = 24;
            this.dgvMatHang.Size = new System.Drawing.Size(1142, 293);
            this.dgvMatHang.TabIndex = 15;
            this.dgvMatHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenMHDataGridViewTextBoxColumn
            // 
            this.tenMHDataGridViewTextBoxColumn.DataPropertyName = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.HeaderText = "TenMH";
            this.tenMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenMHDataGridViewTextBoxColumn.Name = "tenMHDataGridViewTextBoxColumn";
            this.tenMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // slTonDataGridViewTextBoxColumn
            // 
            this.slTonDataGridViewTextBoxColumn.DataPropertyName = "SlTon";
            this.slTonDataGridViewTextBoxColumn.HeaderText = "SlTon";
            this.slTonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.slTonDataGridViewTextBoxColumn.Name = "slTonDataGridViewTextBoxColumn";
            this.slTonDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaNhapDataGridViewTextBoxColumn
            // 
            this.giaNhapDataGridViewTextBoxColumn.DataPropertyName = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.HeaderText = "GiaNhap";
            this.giaNhapDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaNhapDataGridViewTextBoxColumn.Name = "giaNhapDataGridViewTextBoxColumn";
            this.giaNhapDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // maLoaiHangDataGridViewTextBoxColumn
            // 
            this.maLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.HeaderText = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiHangDataGridViewTextBoxColumn.Name = "maLoaiHangDataGridViewTextBoxColumn";
            this.maLoaiHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "MaDV";
            this.maDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            this.maDVDataGridViewTextBoxColumn.Width = 125;
            // 
            // matHangBindingSource1
            // 
            this.matHangBindingSource1.DataMember = "MatHang";
            this.matHangBindingSource1.DataSource = this.bANHANGFAHASADataSet;
            // 
            // bANHANGFAHASADataSet
            // 
            this.bANHANGFAHASADataSet.DataSetName = "BANHANGFAHASADataSet";
            this.bANHANGFAHASADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matHangBindingSource
            // 
            this.matHangBindingSource.DataMember = "MatHang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(681, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ĐgBan";
            // 
            // txtDgBan
            // 
            this.txtDgBan.Location = new System.Drawing.Point(786, 46);
            this.txtDgBan.Multiline = true;
            this.txtDgBan.Name = "txtDgBan";
            this.txtDgBan.Size = new System.Drawing.Size(175, 29);
            this.txtDgBan.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(681, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "ĐgNhap";
            // 
            // txtDgNhap
            // 
            this.txtDgNhap.Location = new System.Drawing.Point(786, 9);
            this.txtDgNhap.Multiline = true;
            this.txtDgNhap.Name = "txtDgNhap";
            this.txtDgNhap.Size = new System.Drawing.Size(175, 29);
            this.txtDgNhap.TabIndex = 11;
            // 
            // txtTenMh
            // 
            this.txtTenMh.Location = new System.Drawing.Point(220, 48);
            this.txtTenMh.Multiline = true;
            this.txtTenMh.Name = "txtTenMh";
            this.txtTenMh.Size = new System.Drawing.Size(175, 29);
            this.txtTenMh.TabIndex = 9;
            // 
            // txtMaMh
            // 
            this.txtMaMh.Location = new System.Drawing.Point(220, 9);
            this.txtMaMh.Multiline = true;
            this.txtMaMh.Name = "txtMaMh";
            this.txtMaMh.Size = new System.Drawing.Size(175, 29);
            this.txtMaMh.TabIndex = 8;
            // 
            // txtMLH
            // 
            this.txtMLH.FormattingEnabled = true;
            this.txtMLH.Location = new System.Drawing.Point(220, 85);
            this.txtMLH.Name = "txtMLH";
            this.txtMLH.Size = new System.Drawing.Size(175, 24);
            this.txtMLH.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã Loại Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mã Mh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Tên mặt hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btndung);
            this.panel2.Controls.Add(this.btncuoi);
            this.panel2.Controls.Add(this.btnsau);
            this.panel2.Controls.Add(this.btntruoc);
            this.panel2.Controls.Add(this.btndau);
            this.panel2.Controls.Add(btnTK);
            this.panel2.Controls.Add(btnDong);
            this.panel2.Controls.Add(btnBoqua);
            this.panel2.Controls.Add(btnLuu);
            this.panel2.Controls.Add(btnSua);
            this.panel2.Controls.Add(btnXoa);
            this.panel2.Controls.Add(btnThem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1163, 131);
            this.panel2.TabIndex = 16;
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(882, 86);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(76, 33);
            this.btndung.TabIndex = 43;
            this.btndung.Text = "||";
            this.btndung.UseVisualStyleBackColor = true;
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(650, 86);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(76, 33);
            this.btncuoi.TabIndex = 42;
            this.btncuoi.Text = ">|";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(518, 86);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(76, 33);
            this.btnsau.TabIndex = 41;
            this.btnsau.Text = ">";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(376, 86);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(76, 33);
            this.btntruoc.TabIndex = 40;
            this.btntruoc.Text = "<";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(256, 86);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(76, 33);
            this.btndau.TabIndex = 39;
            this.btndau.Text = "|<";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(384, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 32);
            this.label3.TabIndex = 13;
            this.label3.Text = "DANH MỤC MẶT HÀNG";
            // 
            // cboMaloaihang
            // 
            this.cboMaloaihang.Controls.Add(this.label8);
            this.cboMaloaihang.Controls.Add(this.txtMaDV);
            this.cboMaloaihang.Controls.Add(this.label7);
            this.cboMaloaihang.Controls.Add(this.txtSlTon);
            this.cboMaloaihang.Controls.Add(this.txtMLH);
            this.cboMaloaihang.Controls.Add(this.label6);
            this.cboMaloaihang.Controls.Add(this.txtDgBan);
            this.cboMaloaihang.Controls.Add(this.label5);
            this.cboMaloaihang.Controls.Add(this.txtDgNhap);
            this.cboMaloaihang.Controls.Add(this.txtTenMh);
            this.cboMaloaihang.Controls.Add(this.txtMaMh);
            this.cboMaloaihang.Controls.Add(this.label4);
            this.cboMaloaihang.Controls.Add(this.label2);
            this.cboMaloaihang.Controls.Add(this.label1);
            this.cboMaloaihang.Location = new System.Drawing.Point(9, 62);
            this.cboMaloaihang.Name = "cboMaloaihang";
            this.cboMaloaihang.Size = new System.Drawing.Size(1130, 158);
            this.cboMaloaihang.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(681, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "MaDV";
            // 
            // txtMaDV
            // 
            this.txtMaDV.Location = new System.Drawing.Point(786, 116);
            this.txtMaDV.Multiline = true;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Size = new System.Drawing.Size(175, 29);
            this.txtMaDV.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(681, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "SLTon";
            // 
            // txtSlTon
            // 
            this.txtSlTon.Location = new System.Drawing.Point(786, 81);
            this.txtSlTon.Multiline = true;
            this.txtSlTon.Name = "txtSlTon";
            this.txtSlTon.Size = new System.Drawing.Size(175, 29);
            this.txtSlTon.TabIndex = 16;
            // 
            // matHangTableAdapter
            // 
            this.matHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietCTKMTableAdapter = null;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = null;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.CTKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.DonViTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = this.matHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DMMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1163, 656);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboMaloaihang);
            this.Name = "DMMatHang";
            this.Text = "DMMatHang";
            this.Load += new System.EventHandler(this.DMMatHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matHangBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.cboMaloaihang.ResumeLayout(false);
            this.cboMaloaihang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.BindingSource matHangBindingSource;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDgBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDgNhap;
        private System.Windows.Forms.TextBox txtTenMh;
        private System.Windows.Forms.TextBox txtMaMh;
        private System.Windows.Forms.ComboBox txtMLH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel cboMaloaihang;
        private BANHANGFAHASADataSet bANHANGFAHASADataSet;
        private System.Windows.Forms.BindingSource matHangBindingSource1;
        private BANHANGFAHASADataSetTableAdapters.MatHangTableAdapter matHangTableAdapter;
        private BANHANGFAHASADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slTonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaNhapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSlTon;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btndau;
    }
}