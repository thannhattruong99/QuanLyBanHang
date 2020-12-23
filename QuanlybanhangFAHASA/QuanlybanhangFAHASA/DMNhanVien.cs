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
    public partial class DMNhanVien : Form
    {
        ketnoi data = new ketnoi();
        BindingManagerBase MyBMB;
       

        public DMNhanVien()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DMNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.NhanVien' table. You can move, or remove it, as needed.
            /*this.nhanVienTableAdapter.Fill(this.bANHANGFAHASADataSet.NhanVien);*/
            load_DMNhanVien();
           
        }
        private void load_DMNhanVien()
        {
            string str = "select * from NhanVien";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;

            clearBindings();

            txtMaNhanVien.DataBindings.Add("text", dt, "MaNV");
            txtTenNhanVien.DataBindings.Add("text", dt, "HoTenNV");
            txtNgaySinh.DataBindings.Add("text", dt, "NgaySinhNV");
            txtGioitinh.DataBindings.Add("text", dt, "GioiTinh");
            txtDiaChi.DataBindings.Add("text", dt, "DiaChi");
            txtDTNV.DataBindings.Add("text", dt, "SDTNV");
            txtMaCV.DataBindings.Add("text", dt, "MaCV");
            MyBMB = this.BindingContext[dt];
        }

        private void clearBindings()
        {
            txtMaNhanVien.DataBindings.Clear();
            txtTenNhanVien.DataBindings.Clear();
            txtNgaySinh.DataBindings.Clear();
            txtGioitinh.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtDTNV.DataBindings.Clear();
            txtMaCV.DataBindings.Clear();
            txtMaCV.DataBindings.Clear();
        }
        public bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaNhanVien.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tim tên nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaNhanVien.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (Kiemtra())
            {
                try
                {
                    int currentcell = dgvNhanVien.CurrentCell.RowIndex;
                    //Dòng click vào
                    string MaNV = txtMaNhanVien.Text;
                    string HoTenNV = txtTenNhanVien.Text;
                    string NgaySinhNV = txtNgaySinh.Text;
                    string GioiTinh = txtGioitinh.Text;
                    string DiaChi = txtDiaChi.Text;
                    string SDTNV = txtDTNV.Text;
                    string MaCV = txtMaCV.Text;

                    data.ExecuteNonQuery("Insert NhanVien Values('" + MaNV + "',N'" + HoTenNV +"',N'"+NgaySinhNV+"',N'"+GioiTinh+"',N'"+DiaChi+"',N'"+SDTNV+"',N'"+MaCV+"')");
                    MessageBox.Show("Thêm thành công");
                    load_DMNhanVien();
                }
                catch (Exception ex)
                {
                    String errMsg = ex.Message;
                    if (errMsg.Contains("duplicate"))
                    {
                        MessageBox.Show("Mã nhân viên " + txtMaNhanVien.Text  + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else if(errMsg.Contains("FOREIGN KEY") && errMsg.ToUpper().Contains("MACV")){
                        MessageBox.Show("Mã chức vụ " + txtMaCV.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    /*int vitri = dgvNhanVien.CurrentCell.RowIndex;*/
                    string MaNV = txtMaNhanVien.Text;
                    string HoTenNV = txtTenNhanVien.Text;
                    /*string NgaySinhNV = txtNgaySinh.Text;
                    string GioiTinh = txtGioitinh.Text;
                    string DiaChi = txtDiaChi.Text;
                    string SDTNV = txtDTNV.Text;
                    string MaCV = txtMaCV.Text;*/

                    int affectedRows =  data.ExecuteNonQuery("Delete From NhanVien Where MaNV = '" + MaNV + "'");
                    if(affectedRows > 0)
                    {
                        MessageBox.Show("Xóa NhanVien " + HoTenNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("NhanVien " + HoTenNV + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    load_DMNhanVien();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int vitri = dgvNhanVien.CurrentCell.RowIndex;
                string MaNV = txtMaNhanVien.Text+"";
                string HoTenNV = txtTenNhanVien.Text+"";
                string NgaySinhNV = txtNgaySinh.Text+"";
                string GioiTinh = txtGioitinh.Text+"";
                string DiaChi = txtDiaChi.Text+"";
                string SDTNV = txtDTNV.Text+"";
                string MaCV = txtMaCV.Text+"";
                
                int affectedRows = data.ExecuteNonQuery("Update NhanVien Set HoTenNV = N'" + HoTenNV + "',  NgaySinhNV = '" + NgaySinhNV + "',GioiTinh=N'"+GioiTinh+"',DiaChi=N'"+DiaChi+"',SDTNV='"+SDTNV+"',MaCV='"+MaCV+"' Where MaNV = '" + MaNV + "'");
                if(affectedRows > 0)
                {
                    MessageBox.Show("Sửa NhanVien " + HoTenNV + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("MaNV " + txtMaNhanVien.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                load_DMNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int index = e.RowIndex;
        //    if (index >= 0)
        //    {
        //        txtMaNhanVien.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
        //        txtTenNhanVien.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
        //        txtNgaySinh.Text=dgvNhanVien.Rows[index].Cells[2].Value.ToString();
        //        txtDiaChi.Text=dgvNhanVien.Rows[index].Cells[4].Value.ToString();
        //        txtDTNV.Text=dgvNhanVien.Rows[index].Cells[5].Value.ToString();
        //        txtMaCV.Text=dgvNhanVien.Rows[index].Cells[6].Value.ToString();
        //    }
        //}

        private void dgvNhanVien_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNhanVien.Text = dgvNhanVien.Rows[index].Cells[0].Value.ToString();
                txtTenNhanVien.Text = dgvNhanVien.Rows[index].Cells[1].Value.ToString();
                txtNgaySinh.Text = dgvNhanVien.Rows[index].Cells[2].Value.ToString();
                txtGioitinh.Text= dgvNhanVien.Rows[index].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[index].Cells[4].Value.ToString();
                txtDTNV.Text = dgvNhanVien.Rows[index].Cells[5].Value.ToString();
                txtMaCV.Text = dgvNhanVien.Rows[index].Cells[6].Value.ToString();
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
            if (MyBMB.Position ==0)
            {
                btntruoc.Enabled = false;
                btndau.Enabled = false;
                
            }
            else
                btncuoi.Enabled = true;
            btnsau.Enabled = true;

        }

        private void btncuoi_Click(object sender, EventArgs e)
        {
            MyBMB.Position = MyBMB.Count;
            btndau.Enabled = true;
            btntruoc.Enabled = true;
            btnsau.Enabled = false;
            btncuoi.Enabled = false;

        }

        private void btndau_Click(object sender, EventArgs e)
        {
            MyBMB.Position =0;
            btndau.Enabled = false;
            btntruoc.Enabled =false;
            btnsau.Enabled = true;
            btncuoi.Enabled = true;
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string str = "select * from NhanVien where HoTenNV like '%" + txtTimKiem.Text.Trim() + "%'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;

            clearBindings();

            txtMaNhanVien.DataBindings.Add("text", dt, "MaNV");
            txtTenNhanVien.DataBindings.Add("text", dt, "HoTenNV");
            txtNgaySinh.DataBindings.Add("text", dt, "NgaySinhNV");
            txtGioitinh.DataBindings.Add("text", dt, "GioiTinh");
            txtDiaChi.DataBindings.Add("text", dt, "DiaChi");
            txtDTNV.DataBindings.Add("text", dt, "SDTNV");
            txtMaCV.DataBindings.Add("text", dt, "MaCV");
            MyBMB = this.BindingContext[dt];
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            string str = "select * from NhanVien where HoTenNV like '%" + txtTimKiem.Text.Trim() + "%'";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvNhanVien.DataSource = dt;

            clearBindings();

            txtMaNhanVien.DataBindings.Add("text", dt, "MaNV");
            txtTenNhanVien.DataBindings.Add("text", dt, "HoTenNV");
            txtNgaySinh.DataBindings.Add("text", dt, "NgaySinhNV");
            txtGioitinh.DataBindings.Add("text", dt, "GioiTinh");
            txtDiaChi.DataBindings.Add("text", dt, "DiaChi");
            txtDTNV.DataBindings.Add("text", dt, "SDTNV");
            txtMaCV.DataBindings.Add("text", dt, "MaCV");
            MyBMB = this.BindingContext[dt];
        }
    }
}

