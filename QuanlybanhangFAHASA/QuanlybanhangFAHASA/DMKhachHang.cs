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
    public partial class DMKhachHang : Form
    {
        ketnoi data = new ketnoi();
        BindingManagerBase MyBMB;

        public DMKhachHang()
        {
            InitializeComponent();
        }

        private void DMKhachHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.KhachHang' table. You can move, or remove it, as needed.
           /* this.khachHangTableAdapter.Fill(this.bANHANGFAHASADataSet.KhachHang);*/
/*            string str = "select * from KhachHang";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvKhachHang.DataSource = dt;

            txtMaKhachHang.DataBindings.Add("text", dt, "MaKH");
            txtTenKhachhang.DataBindings.Add("text", dt, "HoTenKH");
            txtDC.DataBindings.Add("text", dt, "DiaChiKH");
            txtSdt.DataBindings.Add("text", dt, "SDTKH");

            MyBMB = this.BindingContext[dt];*/
            load_DMKhachHang();
        }
        private void load_DMKhachHang()

        {
           string str = "select * from KhachHang";
           SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
           DataTable dt = new DataTable();
           da.Fill(dt);
           dgvKhachHang.DataSource = dt;

           clearBindings();

           txtMaKhachHang.DataBindings.Add("text", dt, "MaKH");
           txtTenKhachhang.DataBindings.Add("text", dt, "HoTenKH");
           txtDC.DataBindings.Add("text", dt, "DiaChiKH");
           txtSdt.DataBindings.Add("text", dt, "SDTKH");

           MyBMB = this.BindingContext[dt];

            //string MaKH = txtMaKhachHang.Text;
            //string HoTenKH = txtTenKhachhang.Text;
            //string DiaChiKH = txtDC.Text;
            //string SDTKH = txtSdt.Text;

        }

        private void clearBindings()
        {
            txtMaKhachHang.DataBindings.Clear();
            txtTenKhachhang.DataBindings.Clear();
            txtDC.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
        }

        public bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mã khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaKhachHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tim tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaKhachHang.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                int currentcell = dgvKhachHang.CurrentCell.RowIndex;
                data.getConnect();
                string MaKH = txtMaKhachHang.Text;
                string HoTenKH = txtTenKhachhang.Text;
                string DiaChiKH = txtDC.Text;
                string SDTKH = txtSdt.Text;
                data.ExecuteNonQuery("Insert Khachhang Values('" + MaKH + "',N'" + HoTenKH + "','" + DiaChiKH + "','" + SDTKH + "')");
                MessageBox.Show("Thêm thành công");
                load_DMKhachHang();

            }
            catch(Exception ex)
            {
                String errMsg = ex.Message;
                if (ex.Message.Contains("duplicate"))
                {
                    MessageBox.Show("Mã khách hàng " + txtMaKhachHang.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string MaKH = txtMaKhachHang.Text+"";
                string HoTenKH = txtTenKhachhang.Text+"";
                string DiaChiKH = txtDC.Text+"";
                string SDTKH = txtSdt.Text+"";

                int affectedRows = data.ExecuteNonQuery("Update Khachhang set HoTenKH= N'" + HoTenKH + "',DiaChiKH=N'" + DiaChiKH + "',SDTKH=N'" + SDTKH + "' Where MaKH = '" + MaKH + "'");
                if(affectedRows > 0)
                {
                    MessageBox.Show("Sửa Khách hàng " + HoTenKH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã Khách " + txtMaKhachHang.Text + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                load_DMKhachHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaKhachHang.Text=dgvKhachHang.Rows[index].Cells[0].Value.ToString();
                txtTenKhachhang.Text = dgvKhachHang.Rows[index].Cells[1].Value.ToString();
                txtDC.Text = dgvKhachHang.Rows[index].Cells[2].Value.ToString();
                txtSdt.Text = dgvKhachHang.Rows[index].Cells[3].Value.ToString();
              
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    /*int vitri = dgvKhachHang.CurrentCell.RowIndex;*/
                    string MaKH = txtMaKhachHang.Text;
                    string HoTenKH = txtTenKhachhang.Text;
                    /*string DiaChiKH = txtDC.Text;
                    string SDTKH = txtSdt.Text;*/
                  
                    int affectedRows = data.ExecuteNonQuery("Delete From KhachHang Wher" +
                        "e MaKH = '" + MaKH + "'");
                    
                    if(affectedRows > 0)
                    {
                        MessageBox.Show("Xóa KhachHang " + HoTenKH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("KhachHang " + HoTenKH + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    load_DMKhachHang();
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

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
            btndau.Enabled = true; ;
            btntruoc.Enabled = true;
            btnsau.Enabled = false;
            btncuoi.Enabled = false;
        }

        private void btndung_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


