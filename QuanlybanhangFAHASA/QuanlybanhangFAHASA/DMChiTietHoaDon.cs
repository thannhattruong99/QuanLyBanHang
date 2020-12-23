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
    public partial class DMChiTietHoaDon : Form
    {
        ketnoi data = new ketnoi();
        private BindingSource bdsource = new BindingSource();

        public DMChiTietHoaDon()
        {
            InitializeComponent();
        }

        private void DMChiTietHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.ChiTietDonHang' table. You can move, or remove it, as needed.
           /* this.chiTietDonHangTableAdapter.Fill(this.bANHANGFAHASADataSet.ChiTietDonHang);*/
            load_DMChiTietHoaDon();
        }
        private void load_DMChiTietHoaDon()
        {
            string str = "select * from ChiTietDonHang";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvCTHD.DataSource = dt;
        }
        public bool Kiemtra()
        {
            if (string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin Mã loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHD.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtMaMh.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tim Tên loại hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaMh.Focus();
                return false;
            }
            return true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                int currentcell = dgvCTHD.CurrentCell.RowIndex;
                string MaHD = txtMaHD.Text;
                string MaMH = txtMaMh.Text;
                string SLDat = txtSLDat.Text;
                string GiaBan = txtĐgban.Text;

                data.ExecuteNonQuery("Insert INTO ChiTietDonHang Values('" + MaHD + "','" + MaMH + "','" + SLDat + "','" + GiaBan + "',");
                MessageBox.Show("Thêm thành công");
                load_DMChiTietHoaDon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa hay không", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    int vitri = dgvCTHD.CurrentCell.RowIndex;
                    string MaHD = dgvCTHD.Rows[vitri].Cells[0].Value.ToString();
                    string MaMH = dgvCTHD.Rows[vitri].Cells[1].Value.ToString();
                    string SLDat = dgvCTHD.Rows[vitri].Cells[2].Value.ToString();
                    string DgBan = dgvCTHD.Rows[vitri].Cells[3].Value.ToString();

                    data.ExecuteNonQuery("Delete from ChiTietDonHang where MaHD ='" + MaHD + "'");
                    MessageBox.Show("Xóa Mat hang " + MaMH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    load_DMChiTietHoaDon();
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
                int vitri = dgvCTHD.CurrentCell.RowIndex;
                string MaHD = dgvCTHD.Rows[vitri].Cells[0].Value.ToString();
                string MaMH = dgvCTHD.Rows[vitri].Cells[1].Value.ToString();
                string SLDat = dgvCTHD.Rows[vitri].Cells[2].Value.ToString();
                string DgBan = dgvCTHD.Rows[vitri].Cells[3].Value.ToString();

                data.ExecuteNonQuery("Update ChiTietDonHang set MaHD ='" + MaHD + "',MaMH= '" + MaMH + "' where MaHD='" + MaHD + "'");
                MessageBox.Show("Sửa Mặt hàng " + MaMH + " thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                load_DMChiTietHoaDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {

                txtMaHD.Text = dgvCTHD.Rows[index].Cells[0].Value.ToString();
                txtMaMh.Text = dgvCTHD.Rows[index].Cells[1].Value.ToString();
                txtSLDat.Text = dgvCTHD.Rows[index].Cells[2].Value.ToString();
                txtĐgban.Text = dgvCTHD.Rows[index].Cells[3].Value.ToString();

            }
        }
    }
}