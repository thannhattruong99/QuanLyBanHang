﻿namespace QuanlybanhangFAHASA
{
    partial class DMNhanVien
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
            System.Windows.Forms.Button btnDong;
            System.Windows.Forms.Button btnSua;
            System.Windows.Forms.Button btnXoa;
            System.Windows.Forms.Button btnThem;
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndung = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.maNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioiTinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTNVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maCVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bANHANGFAHASADataSet = new QuanlybanhangFAHASA.BANHANGFAHASADataSet();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGioitinh = new System.Windows.Forms.TextBox();
            this.txtDTNV = new System.Windows.Forms.TextBox();
            this.txtNgaySinh = new System.Windows.Forms.TextBox();
            this.txtMaCV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nhanVienTableAdapter = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.NhanVienTableAdapter();
            this.tableAdapterManager = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            btnDong = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(1095, 3);
            btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(182, 59);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(844, 5);
            btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(189, 58);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(586, 5);
            btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(198, 64);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            btnThem.Location = new System.Drawing.Point(333, 5);
            btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(192, 64);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(990, 86);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(319, 31);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(273, 144);
            this.txtTenNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.Size = new System.Drawing.Size(266, 31);
            this.txtTenNhanVien.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(273, 86);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(266, 31);
            this.txtMaNhanVien.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(819, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(813, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 32);
            this.label6.TabIndex = 5;
            this.label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(852, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 32);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 144);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân Viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(471, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btndung);
            this.panel1.Controls.Add(this.btncuoi);
            this.panel1.Controls.Add(this.btnsau);
            this.panel1.Controls.Add(this.btntruoc);
            this.panel1.Controls.Add(this.btndau);
            this.panel1.Controls.Add(btnDong);
            this.panel1.Controls.Add(btnSua);
            this.panel1.Controls.Add(btnXoa);
            this.panel1.Controls.Add(btnThem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 794);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1664, 145);
            this.panel1.TabIndex = 6;
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(1350, 75);
            this.btndung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(114, 52);
            this.btndung.TabIndex = 23;
            this.btndung.Text = "||";
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(1002, 75);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(114, 52);
            this.btncuoi.TabIndex = 22;
            this.btncuoi.Text = ">|";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(804, 75);
            this.btnsau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(114, 52);
            this.btnsau.TabIndex = 21;
            this.btnsau.Text = ">";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(591, 75);
            this.btntruoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(114, 52);
            this.btntruoc.TabIndex = 20;
            this.btntruoc.Text = "<";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(411, 75);
            this.btndau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(114, 52);
            this.btndau.TabIndex = 19;
            this.btndau.Text = "|<";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoGenerateColumns = false;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNVDataGridViewTextBoxColumn,
            this.hoTenNVDataGridViewTextBoxColumn,
            this.ngaySinhNVDataGridViewTextBoxColumn,
            this.gioiTinhDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.sDTNVDataGridViewTextBoxColumn,
            this.maCVDataGridViewTextBoxColumn});
            this.dgvNhanVien.DataSource = this.nhanVienBindingSource1;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 412);
            this.dgvNhanVien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.RowTemplate.Height = 24;
            this.dgvNhanVien.Size = new System.Drawing.Size(1646, 377);
            this.dgvNhanVien.TabIndex = 8;
            this.dgvNhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellContentClick_1);
            // 
            // maNVDataGridViewTextBoxColumn
            // 
            this.maNVDataGridViewTextBoxColumn.DataPropertyName = "MaNV";
            this.maNVDataGridViewTextBoxColumn.HeaderText = "MaNV";
            this.maNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNVDataGridViewTextBoxColumn.Name = "maNVDataGridViewTextBoxColumn";
            this.maNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenNVDataGridViewTextBoxColumn
            // 
            this.hoTenNVDataGridViewTextBoxColumn.DataPropertyName = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.HeaderText = "HoTenNV";
            this.hoTenNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenNVDataGridViewTextBoxColumn.Name = "hoTenNVDataGridViewTextBoxColumn";
            this.hoTenNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhNVDataGridViewTextBoxColumn
            // 
            this.ngaySinhNVDataGridViewTextBoxColumn.DataPropertyName = "NgaySinhNV";
            this.ngaySinhNVDataGridViewTextBoxColumn.HeaderText = "NgaySinhNV";
            this.ngaySinhNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhNVDataGridViewTextBoxColumn.Name = "ngaySinhNVDataGridViewTextBoxColumn";
            this.ngaySinhNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // gioiTinhDataGridViewTextBoxColumn
            // 
            this.gioiTinhDataGridViewTextBoxColumn.DataPropertyName = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.HeaderText = "GioiTinh";
            this.gioiTinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gioiTinhDataGridViewTextBoxColumn.Name = "gioiTinhDataGridViewTextBoxColumn";
            this.gioiTinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTNVDataGridViewTextBoxColumn
            // 
            this.sDTNVDataGridViewTextBoxColumn.DataPropertyName = "SDTNV";
            this.sDTNVDataGridViewTextBoxColumn.HeaderText = "SDTNV";
            this.sDTNVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTNVDataGridViewTextBoxColumn.Name = "sDTNVDataGridViewTextBoxColumn";
            this.sDTNVDataGridViewTextBoxColumn.Width = 125;
            // 
            // maCVDataGridViewTextBoxColumn
            // 
            this.maCVDataGridViewTextBoxColumn.DataPropertyName = "MaCV";
            this.maCVDataGridViewTextBoxColumn.HeaderText = "MaCV";
            this.maCVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maCVDataGridViewTextBoxColumn.Name = "maCVDataGridViewTextBoxColumn";
            this.maCVDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienBindingSource1
            // 
            this.nhanVienBindingSource1.DataMember = "NhanVien";
            this.nhanVienBindingSource1.DataSource = this.bANHANGFAHASADataSet;
            // 
            // bANHANGFAHASADataSet
            // 
            this.bANHANGFAHASADataSet.DataSetName = "BANHANGFAHASADataSet";
            this.bANHANGFAHASADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtTimKiem);
            this.panel2.Controls.Add(this.txtGioitinh);
            this.panel2.Controls.Add(this.txtDTNV);
            this.panel2.Controls.Add(this.txtNgaySinh);
            this.panel2.Controls.Add(this.txtMaCV);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDiaChi);
            this.panel2.Controls.Add(this.txtTenNhanVien);
            this.panel2.Controls.Add(this.txtMaNhanVien);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1664, 402);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtGioitinh
            // 
            this.txtGioitinh.Location = new System.Drawing.Point(273, 220);
            this.txtGioitinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGioitinh.Name = "txtGioitinh";
            this.txtGioitinh.Size = new System.Drawing.Size(190, 31);
            this.txtGioitinh.TabIndex = 16;
            // 
            // txtDTNV
            // 
            this.txtDTNV.Location = new System.Drawing.Point(990, 158);
            this.txtDTNV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDTNV.Name = "txtDTNV";
            this.txtDTNV.Size = new System.Drawing.Size(319, 31);
            this.txtDTNV.TabIndex = 15;
            // 
            // txtNgaySinh
            // 
            this.txtNgaySinh.Location = new System.Drawing.Point(990, 223);
            this.txtNgaySinh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNgaySinh.Name = "txtNgaySinh";
            this.txtNgaySinh.Size = new System.Drawing.Size(319, 31);
            this.txtNgaySinh.TabIndex = 14;
            // 
            // txtMaCV
            // 
            this.txtMaCV.Location = new System.Drawing.Point(1448, 78);
            this.txtMaCV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaCV.Name = "txtMaCV";
            this.txtMaCV.Size = new System.Drawing.Size(151, 31);
            this.txtMaCV.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1371, 81);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "MaCV";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = this.nhanVienTableAdapter;
            this.tableAdapterManager.UpdateOrder = QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(586, 324);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(454, 31);
            this.txtTimKiem.TabIndex = 18;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(254, 324);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(195, 32);
            this.label9.TabIndex = 19;
            this.label9.Text = "Tên nhân viên";
            // 
            // DMNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 939);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvNhanVien);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DMNhanVien";
            this.Text = "DMNhanVien";
            this.Load += new System.EventHandler(this.DMNhanVien_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private System.Windows.Forms.Panel panel2;
        private BANHANGFAHASADataSet bANHANGFAHASADataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource1;
        private BANHANGFAHASADataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private BANHANGFAHASADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioiTinhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maCVDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtGioitinh;
        private System.Windows.Forms.TextBox txtDTNV;
        private System.Windows.Forms.TextBox txtNgaySinh;
        private System.Windows.Forms.TextBox txtMaCV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Label label9;
    }
}