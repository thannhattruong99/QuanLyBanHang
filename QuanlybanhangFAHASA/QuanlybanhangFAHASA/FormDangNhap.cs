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
    public partial class FormDangNhap : Form
    {
        public Boolean isLogined = false;
        ketnoi data = new ketnoi();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string str = "select * from TaiKhoan where TenNguoiDung = '" + txtNguoiDung.Text.Trim() + "' and MatKhau = '"+ txtMatKhau.Text.Trim() + "'";
            Console.WriteLine("QUERY: " + str);
            int affectedRows = data.ExecuteQuery(str).Rows.Count;
            if(affectedRows > 0)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                isLogined = true;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không chính xác! Vui lòng thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
