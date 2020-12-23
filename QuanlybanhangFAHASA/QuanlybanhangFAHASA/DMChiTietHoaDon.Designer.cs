namespace QuanlybanhangFAHASA
{
    partial class DMChiTietHoaDon
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
            System.Windows.Forms.Button btnThem;
            System.Windows.Forms.Button btnXoa;
            System.Windows.Forms.Button btnBoqua;
            System.Windows.Forms.Button btnSua;
            System.Windows.Forms.Button btnLuu;
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.maHDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maMHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiTietDonHangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bANHANGFAHASADataSet = new QuanlybanhangFAHASA.BANHANGFAHASADataSet();
            this.chiTietDonHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtĐgban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSLDat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtMaMh = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chiTietDonHangTableAdapter = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.ChiTietDonHangTableAdapter();
            this.tableAdapterManager = new QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager();
            btnDong = new System.Windows.Forms.Button();
            btnThem = new System.Windows.Forms.Button();
            btnXoa = new System.Windows.Forms.Button();
            btnBoqua = new System.Windows.Forms.Button();
            btnSua = new System.Windows.Forms.Button();
            btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            btnDong.Location = new System.Drawing.Point(716, 20);
            btnDong.Name = "btnDong";
            btnDong.Size = new System.Drawing.Size(88, 41);
            btnDong.TabIndex = 23;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnThem
            // 
            btnThem.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            btnThem.Location = new System.Drawing.Point(36, 20);
            btnThem.Name = "btnThem";
            btnThem.Size = new System.Drawing.Size(84, 41);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            btnXoa.Location = new System.Drawing.Point(161, 21);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new System.Drawing.Size(88, 41);
            btnXoa.TabIndex = 19;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoqua
            // 
            btnBoqua.Location = new System.Drawing.Point(579, 20);
            btnBoqua.Name = "btnBoqua";
            btnBoqua.Size = new System.Drawing.Size(88, 41);
            btnBoqua.TabIndex = 22;
            btnBoqua.Text = "Bỏ qua";
            btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new System.Drawing.Point(307, 21);
            btnSua.Name = "btnSua";
            btnSua.Size = new System.Drawing.Size(88, 41);
            btnSua.TabIndex = 20;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            btnLuu.Location = new System.Drawing.Point(447, 21);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new System.Drawing.Size(88, 41);
            btnLuu.TabIndex = 21;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AutoGenerateColumns = false;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHDDataGridViewTextBoxColumn,
            this.maMHDataGridViewTextBoxColumn,
            this.sLDatDataGridViewTextBoxColumn,
            this.giaBanDataGridViewTextBoxColumn});
            this.dgvCTHD.DataSource = this.chiTietDonHangBindingSource1;
            this.dgvCTHD.Location = new System.Drawing.Point(7, 202);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(949, 270);
            this.dgvCTHD.TabIndex = 31;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // maHDDataGridViewTextBoxColumn
            // 
            this.maHDDataGridViewTextBoxColumn.DataPropertyName = "MaHD";
            this.maHDDataGridViewTextBoxColumn.HeaderText = "MaHD";
            this.maHDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maHDDataGridViewTextBoxColumn.Name = "maHDDataGridViewTextBoxColumn";
            this.maHDDataGridViewTextBoxColumn.Width = 125;
            // 
            // maMHDataGridViewTextBoxColumn
            // 
            this.maMHDataGridViewTextBoxColumn.DataPropertyName = "MaMH";
            this.maMHDataGridViewTextBoxColumn.HeaderText = "MaMH";
            this.maMHDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maMHDataGridViewTextBoxColumn.Name = "maMHDataGridViewTextBoxColumn";
            this.maMHDataGridViewTextBoxColumn.Width = 125;
            // 
            // sLDatDataGridViewTextBoxColumn
            // 
            this.sLDatDataGridViewTextBoxColumn.DataPropertyName = "SLDat";
            this.sLDatDataGridViewTextBoxColumn.HeaderText = "SLDat";
            this.sLDatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLDatDataGridViewTextBoxColumn.Name = "sLDatDataGridViewTextBoxColumn";
            this.sLDatDataGridViewTextBoxColumn.Width = 125;
            // 
            // giaBanDataGridViewTextBoxColumn
            // 
            this.giaBanDataGridViewTextBoxColumn.DataPropertyName = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.HeaderText = "GiaBan";
            this.giaBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.giaBanDataGridViewTextBoxColumn.Name = "giaBanDataGridViewTextBoxColumn";
            this.giaBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // chiTietDonHangBindingSource1
            // 
            this.chiTietDonHangBindingSource1.DataMember = "ChiTietDonHang";
            this.chiTietDonHangBindingSource1.DataSource = this.bANHANGFAHASADataSet;
            // 
            // bANHANGFAHASADataSet
            // 
            this.bANHANGFAHASADataSet.DataSetName = "BANHANGFAHASADataSet";
            this.bANHANGFAHASADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chiTietDonHangBindingSource
            // 
            this.chiTietDonHangBindingSource.DataMember = "ChiTietDonHang";
            // 
            // txtĐgban
            // 
            this.txtĐgban.Location = new System.Drawing.Point(657, 70);
            this.txtĐgban.Multiline = true;
            this.txtĐgban.Name = "txtĐgban";
            this.txtĐgban.Size = new System.Drawing.Size(179, 30);
            this.txtĐgban.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(519, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "ĐgBan";
            // 
            // txtSLDat
            // 
            this.txtSLDat.Location = new System.Drawing.Point(163, 70);
            this.txtSLDat.Multiline = true;
            this.txtSLDat.Name = "txtSLDat";
            this.txtSLDat.Size = new System.Drawing.Size(179, 30);
            this.txtSLDat.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "SLDat";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(btnDong);
            this.panel2.Controls.Add(btnThem);
            this.panel2.Controls.Add(btnXoa);
            this.panel2.Controls.Add(btnBoqua);
            this.panel2.Controls.Add(btnSua);
            this.panel2.Controls.Add(btnLuu);
            this.panel2.Location = new System.Drawing.Point(12, 478);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 86);
            this.panel2.TabIndex = 30;
            // 
            // txtMaMh
            // 
            this.txtMaMh.Location = new System.Drawing.Point(661, 18);
            this.txtMaMh.Multiline = true;
            this.txtMaMh.Name = "txtMaMh";
            this.txtMaMh.Size = new System.Drawing.Size(175, 29);
            this.txtMaMh.TabIndex = 33;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(163, 18);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(179, 30);
            this.txtMaHD.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "MãHd";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtĐgban);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSLDat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMaMh);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaHD);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(7, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 123);
            this.panel1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(508, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã Mh";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(208, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 38);
            this.label5.TabIndex = 29;
            this.label5.Text = "CHI TIẾT HÓA ĐƠN BÁN HÀNG";
            // 
            // chiTietDonHangTableAdapter
            // 
            this.chiTietDonHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiTietCTKMTableAdapter = null;
            this.tableAdapterManager.ChiTietDonHangTableAdapter = this.chiTietDonHangTableAdapter;
            this.tableAdapterManager.ChucVuTableAdapter = null;
            this.tableAdapterManager.CTKhuyenMaiTableAdapter = null;
            this.tableAdapterManager.DonViTableAdapter = null;
            this.tableAdapterManager.HoaDonTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.LoaiHangTableAdapter = null;
            this.tableAdapterManager.MatHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QuanlybanhangFAHASA.BANHANGFAHASADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // DMChiTietHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(970, 583);
            this.Controls.Add(this.dgvCTHD);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "DMChiTietHoaDon";
            this.Text = "DMChiTietHoaDon";
            this.Load += new System.EventHandler(this.DMChiTietHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bANHANGFAHASADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chiTietDonHangBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.TextBox txtĐgban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSLDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtMaMh;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private BANHANGFAHASADataSet bANHANGFAHASADataSet;
        private System.Windows.Forms.BindingSource chiTietDonHangBindingSource1;
        private BANHANGFAHASADataSetTableAdapters.ChiTietDonHangTableAdapter chiTietDonHangTableAdapter;
        private BANHANGFAHASADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maMHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaBanDataGridViewTextBoxColumn;
    }
}