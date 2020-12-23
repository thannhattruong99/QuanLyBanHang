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
    public partial class DMLoaiHang : Form
    {
        //Khai báo các biến toàn cục
        ketnoi data = new ketnoi();
        BindingManagerBase MyBMB;
        public DMLoaiHang()
        {
            InitializeComponent();
        }

        private void DMLoaiHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.LoaiHang' table. You can move, or remove it, as needed.
            /*this.loaiHangTableAdapter.Fill(this.bANHANGFAHASADataSet.LoaiHang);*/
            load_LoaiHang();
        }
        private void load_LoaiHang()
        {
            string str = "select * from LoaiHang";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvLoaiHang.DataSource = dt;

            clearBindings();
            
            txtMaLoaiHang.DataBindings.Add("text", dt, "MaLoaiHang");
            txtTenLoaiHang.DataBindings.Add("text", dt, "TenLoaiHang");
                      
            MyBMB = this.BindingContext[dt];
        }

        private void clearBindings()
        {
            txtMaLoaiHang.DataBindings.Clear();
            txtTenLoaiHang.DataBindings.Clear();
        }
        public bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaLoaiHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mã loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHang.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTenLoaiHang.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tim Tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaLoaiHang.Focus();
                return false;
            }
            return true;
        }
        

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            if (Kiemtra())
            {
                try
                {
                    int currentcell = dgvLoaiHang.CurrentCell.RowIndex;
                    //Dòng click vào
                    string MaLoaiHang = txtMaLoaiHang.Text;
                    string TenLoaiHang = txtTenLoaiHang.Text;
                    data.ExecuteNonQuery("Insert LoaiHang Values('" + MaLoaiHang + "',N'" + TenLoaiHang + "')");
                    MessageBox.Show("Thêm thành công");
                    load_LoaiHang();
                }
                catch (Exception ex)
                {
                    String errMsg = ex.Message;
                    if (errMsg.Contains("duplicate"))
                    {
                        MessageBox.Show("Mạ Loại Hàng " + txtMaLoaiHang.Text + " đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    int vitri = dgvLoaiHang.CurrentCell.RowIndex;
                    string MaLoaiHang = dgvLoaiHang.Rows[vitri].Cells[0].Value.ToString();
                    string TenLoaiHang = dgvLoaiHang.Rows[vitri].Cells[1].Value.ToString();
                    
                    int affectedRows = data.ExecuteNonQuery("Delete from LoaiHang where MaLoaiHang ='" + MaLoaiHang + "'");
                    if(affectedRows > 0)
                    {
                        MessageBox.Show("Xóa Loại hàng " + TenLoaiHang + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã Loại hàng " + MaLoaiHang + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                    load_LoaiHang();
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
                int vitri = dgvLoaiHang.CurrentCell.RowIndex;
                string MaLoaiHang = txtMaLoaiHang.Text+"";
                string TenLoaiHang = txtTenLoaiHang.Text+"";
                
                int affectedRows = data.ExecuteNonQuery("Update LoaiHang set TenLoaiHang= N'" + TenLoaiHang + "' where MaLoaiHang='" + MaLoaiHang + "'");
                if(affectedRows > 0)
                {
                    MessageBox.Show("Sửa Loại hàng " + TenLoaiHang + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Mã Loại hàng " + MaLoaiHang + " không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
                load_LoaiHang();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvLoaiHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaLoaiHang.Text = dgvLoaiHang.Rows[index].Cells[0].Value.ToString();
                txtTenLoaiHang.Text = dgvLoaiHang.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
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
            btndau.Enabled = true;
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
