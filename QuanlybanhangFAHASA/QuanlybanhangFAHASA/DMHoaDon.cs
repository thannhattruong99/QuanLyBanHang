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
    public partial class DMHoaDon : Form
    {
        ketnoi data = new ketnoi();
        BindingManagerBase MyBMB;
        public DMHoaDon()
        {
            InitializeComponent();
        }

        private void DMHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bANHANGFAHASADataSet.HoaDon' table. You can move, or remove it, as needed.
           /* this.hoaDonTableAdapter.Fill(this.bANHANGFAHASADataSet.HoaDon);*/
            load_DMHoaDon();
        }
        private void load_DMHoaDon()

        {
            string str = "select * from HoaDon";
            SqlDataAdapter da = new SqlDataAdapter(str, data.getConnect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHoaDon.DataSource = dt;

            txtMaHoaDon.DataBindings.Add("text", dt, "MaHD");
            txtMaKhach.DataBindings.Add("text", dt, "MaKH");
            txtMaNhanVien.DataBindings.Add("text", dt, "MaNV");
            txtNgayLHD.DataBindings.Add("text", dt, "NgayLHD");
            txtPTTT.DataBindings.Add("text", dt, "PTTT");

            MyBMB = this.BindingContext[dt];

            
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaHoaDon.Text = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
                txtMaKhach.Text = dgvHoaDon.Rows[index].Cells[1].Value.ToString();
                txtMaNhanVien.Text = dgvHoaDon.Rows[index].Cells[2].Value.ToString();
                txtNgayLHD.Text = dgvHoaDon.Rows[index].Cells[3].Value.ToString();
                txtPTTT.Text = dgvHoaDon.Rows[index].Cells[4].Value.ToString();
               
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }
    }
}
