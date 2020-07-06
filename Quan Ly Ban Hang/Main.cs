using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quan_Ly_Ban_Hang
{
    
    public partial class FmQLBH : Form
    {
        
        public FmQLBH()
        {
            InitializeComponent();
            Form frm = new FmLogin();
            frm.ShowDialog();
        }

        //Hàm xem danh mục
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Danh_muc_khach_hang();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void FmQLBH_Load(object sender, EventArgs e)
        {

        }

        private void xemDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDoiMatKhau();
            frm.Text = "Đổi Mật Khẩu";
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }

        private void chiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }

        private void thànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new QL_DM_Thanh_Pho();
            frm.Text = "Quản lý Danh mục Thành Phố";
            frm.ShowDialog();
        }

        private void kháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new QL_DM_Khach_Hang();
            frm.Text = "Quản lý Danh mục Khách Hàng";
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new QL_DM_Nhan_Vien();
            //frm.Text = "Quản lý Danh mục Nhân Viên";
            frm.ShowDialog();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new QLDM.QL_DM_San_Pham();
            //frm.Text = "Quản lý Danh mục Nhân Viên";
            frm.ShowDialog();
        }

        private void hóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new QLDM.QL_DM_Hoa_Don();
            //frm.Text = "Quản lý Danh mục Nhân Viên";
            frm.ShowDialog();
        }
    }
}
