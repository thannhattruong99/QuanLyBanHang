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
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
        private string KetNoiCTCSDL(string MayChu, string CSDL, string NguoiDung, string MatKhau)
        {
            string strError = "";
/*            NguoiDung = "truongtn";
            MatKhau = "Admin@1999";*/
            string strcon = "Data Source=" + MayChu + ";";
            strcon += "Initial Catalog=" + CSDL + ";";
            strcon += "Persist Security Info=True;User ID=" + NguoiDung + ";Password=" + MatKhau;
            /*"Data Source=truongtn-db.database.windows.net;Initial Catalog=BANHANGFAHASA;Persist Security Info=True;User ID=truongtn;Password=Admin@1999"*/
            SqlConnection sqlConn = new SqlConnection(strcon);
            // Kiểm soát lỗi
            try
            {
                // Mở kết nối
                sqlConn.Open();
            }
            catch (Exception ex)
            {
                strError = ex.Message;
            }
            return strError;
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            // Kết nối thông qua gọi phương thức KetNoiCSDL
            string strError = "";
            if ((txtMayChu.Text == "") || (txtCSDL.Text == "") || (txtNguoiDung.Text == "") || (txtMatKhau.Text == ""))
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin");
                return;
            }
            strError = KetNoiCTCSDL(txtMayChu.Text, txtCSDL.Text, txtNguoiDung.Text, txtMatKhau.Text);
            if (strError != "")
                MessageBox.Show("Kết nối không thành công");
            else
                MessageBox.Show("Kết nối thành công", "KetNoiSQL");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
