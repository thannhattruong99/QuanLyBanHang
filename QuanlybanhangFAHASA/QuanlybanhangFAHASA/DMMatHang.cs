using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanlybanhangFAHASA
{
    public partial class DMMatHang : Form
    {
        ketnoi data = new ketnoi();
        BindingManagerBase MyBMB;
        public DMMatHang()
        {
            InitializeComponent();
        }

        private void DMMatHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.MatHang' table. You can move, or remove it, as needed.
           /* this.matHangTableAdapter.Fill(this.bANHANGFAHASADataSet.MatHang);*/
            load_DMMatHang();
        }
        private void load_DMMatHang()

        {
            string str = "select * from MatHang";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMatHang.DataSource = dt;

            clearBindinds();

            txtMaMh.DataBindings.Add("text", dt, "MaMH");
            txtTenMh.DataBindings.Add("text", dt, "TenMH");
            txtSlTon.DataBindings.Add("text", dt, "SlTon");
            txtDgNhap.DataBindings.Add("text", dt, "GiaNhap");
            txtDgBan.DataBindings.Add("text", dt, "GiaBan");
            txtMLH.DataBindings.Add("text", dt, "MaLoaiHang");
            txtMaDV.DataBindings.Add("text", dt, "MaDV");

            MyBMB = this.BindingContext[dt];   
        }

        private void clearBindinds()
        {
            txtMaMh.DataBindings.Clear();
            txtTenMh.DataBindings.Clear();
            txtSlTon.DataBindings.Clear();
            txtDgNhap.DataBindings.Clear();
            txtDgBan.DataBindings.Clear();
            txtMLH.DataBindings.Clear();
            txtMaDV.DataBindings.Clear();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaMh.Text = dgvMatHang.Rows[index].Cells[0].Value.ToString();
                txtTenMh.Text = dgvMatHang.Rows[index].Cells[1].Value.ToString();
                txtSlTon.Text = dgvMatHang.Rows[index].Cells[2].Value.ToString();
                txtDgNhap.Text = dgvMatHang.Rows[index].Cells[3].Value.ToString();
                txtDgBan.Text = dgvMatHang.Rows[index].Cells[4].Value.ToString();
                txtMLH.Text = dgvMatHang.Rows[index].Cells[5].Value.ToString();
                txtMaDV.Text= dgvMatHang.Rows[index].Cells[6].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                int currentcell = dgvMatHang.CurrentCell.RowIndex;
                string MaMH = txtMaMh.Text;
                string TenMH= txtTenMh.Text;
                string SlTon = txtSlTon.Text;
                string GiaNhap = txtDgNhap.Text;
                string GiaBan = txtDgBan.Text;
                string MaLoaiHang = txtMLH.Text;
                string MaDV = txtMaDV.Text;
                int affectedRow = data.ExecuteNonQuery("Insert INTO MatHang Values('" + MaMH + "',N'" + TenMH + "','" + SlTon + "','" + GiaNhap + "','"+GiaBan+"','"+MaLoaiHang+"','"+MaDV+"')");
                MessageBox.Show("Thêm thành công");

                load_DMMatHang();
               
            }
            catch (Exception ex)
            {
                String errMsg = ex.Message;
                if (errMsg.Contains("duplicate"))
                {
                    MessageBox.Show("Mã Mặt hàng " + txtMaMh.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }else if(errMsg.Contains("FOREIGN KEY"))
                {
                    if (errMsg.ToUpper().Contains("MALH"))
                    {
                        MessageBox.Show("Mã loại hàng " + txtMLH.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (errMsg.ToUpper().Contains("MADV"))
                    {
                        MessageBox.Show("MaDV " + txtMaDV.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        public bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaMh.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mã mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMh.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaMh.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tim tên mặt hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMh.Focus();
                return false;
            }
            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int vitri = dgvMatHang.CurrentCell.RowIndex;
                    string MaMH = txtMaMh.Text;
                    string TenMH = txtTenMh.Text;
                    string SlTon = txtSlTon.Text;
                    string GiaNhap = txtDgNhap.Text;
                    string GiaBan = txtDgBan.Text;
                    string MaLoaiHang = txtMLH.Text;
                    string MaDV = txtMaDV.Text;

                    int affectedRows = data.ExecuteNonQuery("Delete From MatHang Where MaMH = '" + MaMH + "'");
                    if(affectedRows > 0)
                    {
                        MessageBox.Show("Xóa Mặt hàng " + TenMH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã Mặt hàng " + MaMH + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    load_DMMatHang();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string MaMH = txtMaMh.Text+"";
                string TenMH = txtTenMh.Text+"";
                string SlTon = txtSlTon.Text+"";
                string GiaNhap = txtDgNhap.Text+"";
                string GiaBan = txtDgBan.Text+"";
                string MaLoaiHang = txtMLH.Text+"";
                string MaDV = txtMaDV.Text+"";
                
                int affectedRows = data.ExecuteNonQuery("Update MatHang set TenMH= N'" + TenMH + "',SlTon=N'" + SlTon + "',GiaNhap='" + GiaNhap + "',GiaBan='"+GiaBan+"',MaLoaiHang='"+MaLoaiHang+"',MaDV='"+MaDV+"' Where MaMH = '" + MaMH + "'");
                if(affectedRows > 0)
                {
                    MessageBox.Show("Sửa Mặt hàng " + TenMH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mặt hàng " + txtMaMh.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                load_DMMatHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsau_Click(object sender, EventArgs e)
        {
            MyBMB.Position += 1;
            if (MyBMB.Position == MyBMB.Count - 1)
            {
                btnsau.Enabled = false;
                btncuoi.Enabled = false;

            }
            else
                btndau.Enabled = true;
            btntruoc.Enabled = true;
        }

        private void btntruoc_Click(object sender, EventArgs e)
        {
            MyBMB.Position -= 1;
            if (MyBMB.Position == 0)
            {
                btntruoc.Enabled = false;
                btndau.Enabled = false;

            }
            else
                btncuoi.Enabled = true;
            btnsau.Enabled = true;
        }

        private void btndau_Click(object sender, EventArgs e)
        {
            MyBMB.Position = 0;
            btndau.Enabled = false;
            btntruoc.Enabled = false;
            btnsau.Enabled = true;
            btncuoi.Enabled = true;
        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            MyBMB.Position = MyBMB.Count;
            btndau.Enabled = true;
            btntruoc.Enabled = true;
            btnsau.Enabled = false;
            btncuoi.Enabled = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string str = "select * from MatHang where TenMH like '%" + txtTimKiem.Text.Trim() + "%'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvMatHang.DataSource = dt;

            clearBindinds();

            txtMaMh.DataBindings.Add("text", dt, "MaMH");
            txtTenMh.DataBindings.Add("text", dt, "TenMH");
            txtSlTon.DataBindings.Add("text", dt, "SlTon");
            txtDgNhap.DataBindings.Add("text", dt, "GiaNhap");
            txtDgBan.DataBindings.Add("text", dt, "GiaBan");
            txtMLH.DataBindings.Add("text", dt, "MaLoaiHang");
            txtMaDV.DataBindings.Add("text", dt, "MaDV");

            MyBMB = this.BindingContext[dt];
        }
    }
}
