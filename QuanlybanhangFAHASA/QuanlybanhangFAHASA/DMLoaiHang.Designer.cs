namespace QuanlybanhangFAHASA
{
    partial class DMLoaiHang
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenLoaiHang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaiHang = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndung = new System.Windows.Forms.Button();
            this.btncuoi = new System.Windows.Forms.Button();
            this.btnsau = new System.Windows.Forms.Button();
            this.btntruoc = new System.Windows.Forms.Button();
            this.btndau = new System.Windows.Forms.Button();
            this.dgvLoaiHang = new System.Windows.Forms.DataGridView();
            this.maLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiHangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bANHANGFAHASADataSet = new QuanlybanhangFAHASA.BANHANGFAHASADataSet();
            this.loaiHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.loaiHangTableAdapter = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.LoaiHangTableAdapter();
            this.tableAdapterManager = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            btnDong = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(948, 5);
            btnDong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(144, 66);
            btnDong.TabIndex = 23;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTenLoaiHang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaLoaiHang);
            this.panel2.Location = new System.Drawing.Point(18, 78);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1360, 110);
            this.panel2.TabIndex = 30;
            // 
            // txtTenLoaiHang
            // 
            this.txtTenLoaiHang.Location = new System.Drawing.Point(970, 27);
            this.txtTenLoaiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenLoaiHang.Multiline = true;
            this.txtTenLoaiHang.Name = "txtTenLoaiHang";
            this.txtTenLoaiHang.Size = new System.Drawing.Size(278, 48);
            this.txtTenLoaiHang.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "Mã Loại Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(746, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 32);
            this.label3.TabIndex = 15;
            this.label3.Text = "Tên Loại Hàng";
            // 
            // txtMaLoaiHang
            // 
            this.txtMaLoaiHang.Location = new System.Drawing.Point(240, 30);
            this.txtMaLoaiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMaLoaiHang.Multiline = true;
            this.txtMaLoaiHang.Name = "txtMaLoaiHang";
            this.txtMaLoaiHang.Size = new System.Drawing.Size(278, 49);
            this.txtMaLoaiHang.TabIndex = 16;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(436, 5);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(166, 66);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(682, 5);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 64);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(150, 5);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(166, 66);
            this.btnThem.TabIndex = 27;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btndung);
            this.panel1.Controls.Add(this.btncuoi);
            this.panel1.Controls.Add(this.btnsau);
            this.panel1.Controls.Add(this.btntruoc);
            this.panel1.Controls.Add(this.btndau);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(btnDong);
            this.panel1.Location = new System.Drawing.Point(18, 666);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 172);
            this.panel1.TabIndex = 29;
            // 
            // btndung
            // 
            this.btndung.Location = new System.Drawing.Point(1158, 95);
            this.btndung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndung.Name = "btndung";
            this.btndung.Size = new System.Drawing.Size(114, 52);
            this.btndung.TabIndex = 43;
            this.btndung.Text = "||";
            this.btndung.UseVisualStyleBackColor = true;
            this.btndung.Click += new System.EventHandler(this.btndung_Click);
            // 
            // btncuoi
            // 
            this.btncuoi.Location = new System.Drawing.Point(810, 95);
            this.btncuoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btncuoi.Name = "btncuoi";
            this.btncuoi.Size = new System.Drawing.Size(114, 52);
            this.btncuoi.TabIndex = 42;
            this.btncuoi.Text = ">|";
            this.btncuoi.UseVisualStyleBackColor = true;
            this.btncuoi.Click += new System.EventHandler(this.btncuoi_Click);
            // 
            // btnsau
            // 
            this.btnsau.Location = new System.Drawing.Point(612, 95);
            this.btnsau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnsau.Name = "btnsau";
            this.btnsau.Size = new System.Drawing.Size(114, 52);
            this.btnsau.TabIndex = 41;
            this.btnsau.Text = ">";
            this.btnsau.UseVisualStyleBackColor = true;
            this.btnsau.Click += new System.EventHandler(this.btnsau_Click);
            // 
            // btntruoc
            // 
            this.btntruoc.Location = new System.Drawing.Point(399, 95);
            this.btntruoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btntruoc.Name = "btntruoc";
            this.btntruoc.Size = new System.Drawing.Size(114, 52);
            this.btntruoc.TabIndex = 40;
            this.btntruoc.Text = "<";
            this.btntruoc.UseVisualStyleBackColor = true;
            this.btntruoc.Click += new System.EventHandler(this.btntruoc_Click);
            // 
            // btndau
            // 
            this.btndau.Location = new System.Drawing.Point(219, 95);
            this.btndau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btndau.Name = "btndau";
            this.btndau.Size = new System.Drawing.Size(114, 52);
            this.btndau.TabIndex = 39;
            this.btndau.Text = "|<";
            this.btndau.UseVisualStyleBackColor = true;
            this.btndau.Click += new System.EventHandler(this.btndau_Click);
            // 
            // dgvLoaiHang
            // 
            this.dgvLoaiHang.AutoGenerateColumns = false;
            this.dgvLoaiHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiHangDataGridViewTextBoxColumn,
            this.tenLoaiHangDataGridViewTextBoxColumn});
            this.dgvLoaiHang.DataSource = this.loaiHangBindingSource1;
            this.dgvLoaiHang.Location = new System.Drawing.Point(18, 275);
            this.dgvLoaiHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvLoaiHang.Name = "dgvLoaiHang";
            this.dgvLoaiHang.RowHeadersWidth = 51;
            this.dgvLoaiHang.RowTemplate.Height = 24;
            this.dgvLoaiHang.Size = new System.Drawing.Size(1364, 386);
            this.dgvLoaiHang.TabIndex = 28;
            this.dgvLoaiHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiHang_CellContentClick);
            // 
            // maLoaiHangDataGridViewTextBoxColumn
            // 
            this.maLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.HeaderText = "MaLoaiHang";
            this.maLoaiHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLoaiHangDataGridViewTextBoxColumn.Name = "maLoaiHangDataGridViewTextBoxColumn";
            this.maLoaiHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLoaiHangDataGridViewTextBoxColumn
            // 
            this.tenLoaiHangDataGridViewTextBoxColumn.DataPropertyName = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.HeaderText = "TenLoaiHang";
            this.tenLoaiHangDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiHangDataGridViewTextBoxColumn.Name = "tenLoaiHangDataGridViewTextBoxColumn";
            this.tenLoaiHangDataGridViewTextBoxColumn.Width = 125;
            // 
            // loaiHangBindingSource1
            // 
            this.loaiHangBindingSource1.DataMember = "LoaiHang";
            this.loaiHangBindingSource1.DataSource = this.bANHANGFAHASADataSet;
            // 
            // bANHANGFAHASADataSet
            // 
            this.bANHANGFAHASADataSet.DataSetName = "BANHANGFAHASADataSet";
            this.bANHANGFAHASADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangBindingSource
            // 
            this.loaiHangBindingSource.DataMember = "LoaiHang";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(406, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(628, 61);
            this.label1.TabIndex = 27;
            this.label1.Text = "DANH MỤC LOẠI HÀNG";
            // 
            // loaiHangTableAdapter
            // 
            this.loaiHangTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LoaiHangTableAdapter = this.loaiHangTableAdapter;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(388, 214);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(313, 32);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tìm kiếm tên Loại Hàng";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(736, 198);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(278, 48);
            this.txtTimKiem.TabIndex = 31;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // DMLoaiHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1418, 861);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvLoaiHang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DMLoaiHang";
            this.Text = "DMLoaiHang";
            this.Load += new System.EventHandler(this.DMLoaiHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenLoaiHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaiHang;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource loaiHangBindingSource;
        private System.Windows.Forms.DataGridView dgvLoaiHang;
        private System.Windows.Forms.Label label1;
        private BANHANGFAHASADataSet bANHANGFAHASADataSet;
        private System.Windows.Forms.BindingSource loaiHangBindingSource1;
        private BANHANGFAHASADataSetTableAdapters.LoaiHangTableAdapter loaiHangTableAdapter;
        private BANHANGFAHASADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiHangDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btndung;
        private System.Windows.Forms.Button btncuoi;
        private System.Windows.Forms.Button btnsau;
        private System.Windows.Forms.Button btntruoc;
        private System.Windows.Forms.Button btndau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}