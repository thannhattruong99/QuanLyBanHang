using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanlybanhangFAHASA
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            DMNhanVien frm = new DMNhanVien();
            frm.Show();
           
        }

        private void mnuLoaihang_Click(object sender, EventArgs e)
        {
            DMLoaiHang frm = new DMLoaiHang();
            //frm.MdiParent = this;
            frm.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            DMKhachHang frm = new DMKhachHang();
            frm.Show();
        }

        private void mnuMathang_Click(object sender, EventArgs e)
        {
            DMMatHang frm = new DMMatHang();
            frm.Show();
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMChiTietHoaDon frm = new DMChiTietHoaDon();
            frm.Show();
        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            DMHoaDon frm = new DMHoaDon();
            frm.Show();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap frm = new FormDangNhap();
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
