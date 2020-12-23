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
        FormDangNhap frDangNhap = new FormDangNhap();

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
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
           
        }

        private void mnuLoaihang_Click(object sender, EventArgs e)
        {
            DMLoaiHang frm = new DMLoaiHang();
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuKhachhang_Click(object sender, EventArgs e)
        {
            DMKhachHang frm = new DMKhachHang();
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuMathang_Click(object sender, EventArgs e)
        {
            DMMatHang frm = new DMMatHang();
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DMChiTietHoaDon frm = new DMChiTietHoaDon();
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuHoadonban_Click(object sender, EventArgs e)
        {
            DMHoaDon frm = new DMHoaDon();
            if (frDangNhap.isLogined)
                frm.Show();
            else
                MessageBox.Show("Vui lòng đăng nhập hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDangNhap.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frDangNhap.isLogined = false;
        }

        private void mnuFile_Click(object sender, EventArgs e)
        {
            if (frDangNhap.isLogined)
            {
                this.đăngXuấtToolStripMenuItem.Visible = true;
                this.đăngNhậpToolStripMenuItem.Visible = false;
            }
            else
            {
                this.đăngXuấtToolStripMenuItem.Visible = false;
                this.đăngNhậpToolStripMenuItem.Visible = true;
            }
        }
    }
}
